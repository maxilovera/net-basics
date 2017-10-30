using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
using EjemploGrillas.Interfaces;

namespace EjemploGrillas
{
    public partial class CargaFactura : Form
    {
        private Factura facturaSeleccionada; //En la carga de una factura nueva es un objeto vacio, en la edicion tiene el objeto factura a actualizar

        public CargaFactura()
        {
            InitializeComponent();
        }
        
        public CargaFactura(Factura facturaSeleccionada)
        {
            this.facturaSeleccionada = facturaSeleccionada;

            InitializeComponent();
        }

        private void CargaFactura_Load(object sender, EventArgs e)
        {
            txtCodigoFactura.Text = this.facturaSeleccionada.Codigo.ToString();
            comboClientes.SelectedValue = this.facturaSeleccionada.CodigoCliente;
            dtpFechaFactura.Text = this.facturaSeleccionada.Fecha.ToString();
            txtMonto.Text = this.facturaSeleccionada.Monto.ToString();

            IObtenerDatos form = this.Owner as IObtenerDatos;

            List<Cliente> clientes = new List<Cliente>();
            clientes.AddRange(form.ObtenerClientes());

            comboClientes.DataSource = clientes;
            comboClientes.DisplayMember = "Nombre";
            comboClientes.ValueMember = "Codigo";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Pongo en las propiedades de factura seleccionada, los valores cargados por el usuario.
            this.facturaSeleccionada.CodigoCliente = ((Cliente)comboClientes.SelectedItem).Codigo;
            this.facturaSeleccionada.Fecha = DateTime.Parse(dtpFechaFactura.Text);
            this.facturaSeleccionada.Monto = double.Parse(txtMonto.Text);

            //Llamo al método de guardar factura del padre.
            IActualizacionFactura form = this.Owner as IActualizacionFactura;
            if (form != null) //si el padre implementa esa interfaz
            {
                form.GuardarFactura(this.facturaSeleccionada);
            }

            this.Close();
        }
    }
}
