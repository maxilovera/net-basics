using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Clases
{
    public class Reptil : Animal
    {
        public bool EstaEnReservorio { get; set; }

        public override void MoverZona(Zonas nuevaZona)
        {
            if (!EstaEnReservorio)
                base.MoverZona(nuevaZona);
        }
    }
}
