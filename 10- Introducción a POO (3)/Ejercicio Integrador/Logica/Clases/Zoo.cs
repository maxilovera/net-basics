using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Clases
{
    public class Zoo
    {
        public Zoo()
        {            
            this.Aves = new List<Ave>();
            this.Mamiferos = new List<Mamifero>();
            this.Reptiles = new List<Reptil>();
        }
        
        public List<Ave> Aves { get; set; }
        public List<Mamifero> Mamiferos { get; set; }
        public List<Reptil> Reptiles { get; set; }

        public void AgregarAnimal(Ave ave)
        {
            this.Aves.Add(ave);
        }

        public void AgregarAnimal(Mamifero mamifero)
        {
            this.Mamiferos.Add(mamifero);
        }

        public void AgregarAnimal(Reptil reptil)
        {
            this.Reptiles.Add(reptil);
        }

        public List<Animal> ObtenerAnimalesMayores50Años()
        {
            List<Animal> lista = new List<Animal>();

            foreach (Ave ave in this.Aves)
            {
                if (ave.Edad > 50)
                    lista.Add((Animal)ave);
            }

            foreach (Reptil reptil in this.Reptiles)
            {
                if (reptil.Edad > 50)
                    lista.Add((Animal)reptil);
            }

            foreach (Mamifero mamifero in this.Mamiferos)
            {
                if (mamifero.Edad > 50)
                    lista.Add((Animal)mamifero);
            }

            return lista;
        }
    }
}
