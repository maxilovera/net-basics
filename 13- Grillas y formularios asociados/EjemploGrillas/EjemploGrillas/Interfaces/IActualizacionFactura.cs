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
        /// <summary>
        /// Este metodo actualiza la factura y luego recarga la grilla.
        /// </summary>
        /// <param name="factura"></param>
        void GuardarFactura(Factura factura);        
    }
}
