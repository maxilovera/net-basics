using EjemploGrillas.Interfaces;
using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploGrillas
{
    public partial class Principal : Form, IActualizacionFactura, IObtenerDatos
    {
        public Principal()
        {
            InitializeComponent();
        }

        private Ejemplo logica { get; set; }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.logica = new Ejemplo();

            //Esto se hace cuando el filtro es opcional, no se ensucia el codigo de
            //la clase de logica agregando este item, se hace en la interfaz.
            List<Cliente> clientes = new List<Cliente>();
            clientes.Add(new Cliente() { Codigo = 0, Nombre = "Seleccione..." });
            clientes.AddRange(this.logica.ObtenerClientes());

            //Origen de datos: Lista de los elementos a mostrar en el control
            comboClientes.DataSource = clientes;
            //Nombre de la propiedad que queremos que se muestre en el control
            comboClientes.DisplayMember = "Nombre";
            //Nombre de la propiedad de la que queremos obtener el valor 
            //cuando se seleccione un item
            comboClientes.ValueMember = "Codigo";
            
        }

        private void comboClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Este evento se dispara cuando cambia la selección del control.

            //Aca deberia actualizar la grilla trayendo la lista filtrada por el código de cliente seleccionado.          
            ActualizarGrilla();
        }
        
        private void gridFacturas2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var column = gridFacturas2.Columns[e.ColumnIndex];
            var row = gridFacturas2.Rows[e.RowIndex];

            //En column podemos encontrar el nombre de la columna que definimos en el diseñador.

            if (column.Name == "Eliminar")
            {
                var mensaje = MessageBox.Show("Está seguro que desea eliminar la factura?", "Eliminar factura", MessageBoxButtons.OKCancel);

                if (mensaje == DialogResult.OK)
                {
                    Factura facturaSeleccionada = row.DataBoundItem as Factura;
                    facturaSeleccionada.FechaBaja = DateTime.Now;

                    this.logica.GuardarFactura(facturaSeleccionada);

                    this.ActualizarGrilla();
                }
            }

            if (column.Name == "Modificar")
            {
                Factura filaSeleccionada = row.DataBoundItem as Factura;
                //Esto lo hago por si cambio algun dato.
                Factura factura = this.logica.ObtenerFacturaPorCodigo(filaSeleccionada.Codigo);

                CargaFactura formCarga = new CargaFactura(factura);
                formCarga.Owner = this;
                //formCarga.Show(); //Este abre un form y se puede modificar el de atras
                formCarga.ShowDialog(); //abre la ventana nueva como un dialog, no se puede modificar el de atras.
            }
        }

        private void gridFacturas2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Evento cuando se hace clic en una celda.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CargaFactura formCarga = new CargaFactura(new Factura());
            formCarga.Owner = this;
            formCarga.ShowDialog(); 
        }
        private void ActualizarGrilla()
        {
            Cliente clienteSeleccionado = comboClientes.SelectedItem as Cliente;

            gridFacturas2.AutoGenerateColumns = false;
            gridFacturas2.DataSource = this.logica.ObtenerFacturas(clienteSeleccionado.Codigo);

        }

        //Implementaciones de la interfaz
        public void GuardarFactura(Factura factura)
        {
            this.logica.GuardarFactura(factura);

            this.ActualizarGrilla();
        }

        public List<Factura> ObtenerFacturas(int codigoCliente)
        {
            return this.logica.ObtenerFacturas(codigoCliente);
        }

        public Factura ObtenerFacturaPorCodigo(int codigo)
        {
            return this.logica.ObtenerFacturaPorCodigo(codigo);
        }

        public List<Cliente> ObtenerClientes()
        {
            return this.logica.ObtenerClientes();
        }        
    }
}
