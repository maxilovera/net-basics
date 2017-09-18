using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Clases
{
    public enum Zonas
    {
        Zona1, Zona2, Zona3
    }

    public class Animal
    {
        public string Nombre { get; set; }
        public int Peso { get; set; }
        public Zonas Zona { get; set; }
        public int Edad { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public virtual void MoverZona(Zonas nuevaZona)
        {
            this.Zona = nuevaZona;
        }

        public void Cumple()
        {
            if (this.FechaNacimiento == DateTime.Today)
                this.Edad += 1;
        }        
    }
    
}
