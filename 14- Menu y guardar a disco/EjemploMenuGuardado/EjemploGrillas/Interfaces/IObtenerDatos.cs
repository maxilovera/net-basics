using Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploGrillas.Interfaces
{
    /// <summary>
    /// Esta interfaz tiene la definicion de los metodos que van a permitir retornar datos a los formularios hijos
    /// </summary>
    public interface IObtenerDatos
    {
        List<Factura> ObtenerFacturas(int codigoCliente);

        Factura ObtenerFacturaPorCodigo(int codigo);

        List<Cliente> ObtenerClientes();
    }
}
