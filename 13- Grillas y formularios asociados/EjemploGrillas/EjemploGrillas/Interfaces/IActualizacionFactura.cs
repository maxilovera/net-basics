using Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploGrillas.Interfaces
{
    public interface IActualizacionFactura
    {
        Factura ObtenerFacturaPorCodigo(int codigo);
    }
}
