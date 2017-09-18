using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Clases
{
    public class Mamifero : Animal
    {
        public int CantidadClan { get; set; }
        public int CantidadParientesDirectos { get; set; }

        public override void MoverZona(Zonas nuevaZona)
        {
            if (this.Edad > 1)
                base.MoverZona(nuevaZona);
        }
    }
}
