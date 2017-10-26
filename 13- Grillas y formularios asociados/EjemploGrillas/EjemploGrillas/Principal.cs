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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        public Ejemplo Ejemplo { get; set; }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Ejemplo = new Ejemplo();

            //Esto se hace cuando el filtro es opcional, no se ensucia el codigo de
            //la clase de logica agregando este item, se hace en la interfaz.
            List<Cliente> clientes = new List<Cliente>();
            clientes.Add(new Cliente() { Codigo = 0, Nombre = "Seleccione..." });
            clientes.AddRange(this.Ejemplo.ObtenerClientes());

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

        private void ActualizarGrilla()
        {
            Cliente clienteSeleccionado = comboClientes.SelectedItem as Cliente;

            gridFacturas.AutoGenerateColumns = true;
            gridFacturas.DataSource = this.Ejemplo.ObtenerFacturas(clienteSeleccionado.Codigo);            
            
            gridFacturas2.AutoGenerateColumns = false;
            gridFacturas2.DataSource = this.Ejemplo.ObtenerFacturas(clienteSeleccionado.Codigo);
            
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

                    this.Ejemplo.EliminarFactura(facturaSeleccionada.Codigo);

                    this.ActualizarGrilla();
                }
            }

            if (column.Name == "Modificar")
            {

            }
        }

        private void gridFacturas2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
