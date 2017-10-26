using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Factura
    {
        public int Codigo { get; set; }
        public DateTime Fecha { get; set; }
        public double Monto { get; set; }
        public int CodigoCliente { get; set; }
    }

    public class Cliente
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
    }

    public class Ejemplo
    {
        private List<Cliente> clientes;
        private List<Factura> facturas;

        public Ejemplo()
        {
            //cargo las listas con lo que tenga guardado en disco.
            this.clientes = new List<Cliente>();
            this.facturas = new List<Factura>();

            this.clientes.Add(new Cliente() { Codigo = 1, Nombre = "Maxi" });
            this.clientes.Add(new Cliente() { Codigo = 2, Nombre = "Gonza" });
            this.clientes.Add(new Cliente() { Codigo = 3, Nombre = "Juan" });
            this.clientes.Add(new Cliente() { Codigo = 4, Nombre = "Pedro" });

            this.facturas.Add(new Factura() { Codigo = 1, CodigoCliente = 1, Fecha = DateTime.Now.AddDays(-4), Monto = 1000 });
            this.facturas.Add(new Factura() { Codigo = 2, CodigoCliente = 1, Fecha = DateTime.Now.AddDays(-14), Monto =2000 });
            this.facturas.Add(new Factura() { Codigo = 3, CodigoCliente = 2, Fecha = DateTime.Now.AddDays(-24), Monto = 3000 });
            this.facturas.Add(new Factura() { Codigo = 4, CodigoCliente = 3, Fecha = DateTime.Now.AddDays(-34), Monto = 5000 });
            this.facturas.Add(new Factura() { Codigo = 5, CodigoCliente = 4, Fecha = DateTime.Now.AddDays(-15), Monto = 6500 });
            this.facturas.Add(new Factura() { Codigo = 6, CodigoCliente = 2, Fecha = DateTime.Now.AddDays(-12), Monto =74000 });
            this.facturas.Add(new Factura() { Codigo = 7, CodigoCliente = 3, Fecha = DateTime.Now.AddDays(-10), Monto = 1200 });
            this.facturas.Add(new Factura() { Codigo = 8, CodigoCliente = 1, Fecha = DateTime.Now.AddDays(-8), Monto = 5400 });
            this.facturas.Add(new Factura() { Codigo = 9, CodigoCliente = 1, Fecha = DateTime.Now.AddDays(-6), Monto = 1020 });
            this.facturas.Add(new Factura() { Codigo = 10, CodigoCliente =2, Fecha = DateTime.Now.AddDays(-4), Monto = 1700 });
            this.facturas.Add(new Factura() { Codigo = 11, CodigoCliente = 1, Fecha = DateTime.Now.AddDays(-1), Monto = 1800 });
            this.facturas.Add(new Factura() { Codigo = 12, CodigoCliente = 4, Fecha = DateTime.Now.AddDays(-29), Monto = 1090 });
            this.facturas.Add(new Factura() { Codigo = 13, CodigoCliente = 3, Fecha = DateTime.Now.AddDays(-64), Monto = 3980 });
            this.facturas.Add(new Factura() { Codigo = 14, CodigoCliente = 2, Fecha = DateTime.Now.AddDays(-184), Monto = 8000 });
        }

        /// <summary>
        /// Obtiene los clientes guardados en el sistema
        /// </summary>
        /// <returns></returns>
        public List<Cliente> ObtenerClientes()
        {
            return this.clientes;
        }

        /// <summary>
        /// Obtiene las facturas guardadas en el sistema.
        /// </summary>
        /// <returns></returns>
        public List<Factura> ObtenerFacturas(int codigoCliente)
        {
            return codigoCliente == 0 ? this.facturas : this.facturas.Where(x=>x.CodigoCliente == codigoCliente).ToList();
        }

        /// <summary>
        /// Crea / Actualiza una factura. Si codigo = 0 es una nueva, sino es una para actualizar
        /// </summary>
        /// <param name="factura"></param>
        /// <returns></returns>
        public bool GuardarFactura(Factura factura)
        {
            if (factura.Codigo == 0)
            {
                this.facturas.Add(factura);
            }
            else
            {
                var facturasSinLaActualizada = this.facturas.Where(x => x.Codigo != factura.Codigo).ToList();

                facturasSinLaActualizada.Add(factura);

                this.facturas = facturasSinLaActualizada;
            }

            return true;
        }

        /// <summary>
        /// Elimina una factura que coincida con el codigo pasado como parametro
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        public bool EliminarFactura(int codigo)
        {
            var facturasSinLaActualizada = this.facturas.Where(x => x.Codigo != codigo).ToList();
            
            this.facturas = facturasSinLaActualizada;

            return true;
        }
    }
}
