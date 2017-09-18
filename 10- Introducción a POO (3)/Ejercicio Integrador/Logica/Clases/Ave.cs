using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Clases
{
    public class Ave : Animal
    {
        public bool EstaEnReproduccion()
        {
            return true;
            //controlar la fecha contra primavera
        }

        public override void MoverZona(Zonas nuevaZona)
        {
            if (this.EstaEnReproduccion())
                base.MoverZona(nuevaZona);
        }

        
    }
}
