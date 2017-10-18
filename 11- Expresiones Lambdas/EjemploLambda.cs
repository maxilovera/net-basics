using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Persona
    {
        public int Numero { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public double Sueldo { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Persona> personas = new List<Persona>();

            personas.Add(new Persona() { Numero = 1, Nombre = "Maxi", FechaNacimiento = new DateTime(2010, 4, 15), Sueldo = 1000 });
            personas.Add(new Persona() { Numero = 2, Nombre = "Pedro", FechaNacimiento = new DateTime(2000, 3, 25), Sueldo = 2000 });
            personas.Add(new Persona() { Numero = 3, Nombre = "Juan", FechaNacimiento = new DateTime(1987, 6, 8), Sueldo = 350 });
            personas.Add(new Persona() { Numero = 4, Nombre = "Roberto", FechaNacimiento = new DateTime(1950, 8, 6), Sueldo = 5000 });
            personas.Add(new Persona() { Numero = 5, Nombre = "Martin", FechaNacimiento = new DateTime(1990, 9, 5), Sueldo = 5500 });
            personas.Add(new Persona() { Numero = 6, Nombre = "Alberto", FechaNacimiento = new DateTime(1987, 1, 2), Sueldo = 3490 });
            personas.Add(new Persona() { Numero = 7, Nombre = "Maria", FechaNacimiento = new DateTime(1988, 3, 29), Sueldo = 9000 });
            personas.Add(new Persona() { Numero = 8, Nombre = "Mariana", FechaNacimiento = new DateTime(1967, 3, 14), Sueldo = 8000 });
            personas.Add(new Persona() { Numero = 9, Nombre = "Maxi", FechaNacimiento = new DateTime(1967, 2, 3), Sueldo = 8000 });
            personas.Add(new Persona() { Numero = 10, Nombre = "Maxi", FechaNacimiento = new DateTime(1967, 9, 7), Sueldo = 8000 });

            //Analice los resultados de cada expresion.
            List<Persona> p1 = personas.Where(x=>x.FechaNacimiento == DateTime.Today).ToList();
            double p2 = personas.Sum(x => x.Sueldo);
            bool p3 = personas.Any(x => x.Numero != 10);
            Persona p4 = personas.First(x => x.Nombre == "Pedro"); //Que pasa si pone un nombre que no este en el listado?            
            Persona p5 = personas.FirstOrDefault(x => x.Numero > 8); //probar ambos metodos con Single y SingleOrDefault, que cambios observan?

            List<Persona> p6 = new List<Persona>();
            p6.ForEach(x => x.Sueldo += 100);

            double p7 = personas.Max(x => x.Sueldo);
            List<Persona> p8 = personas.OrderBy(x => x.FechaNacimiento).ToList();
            List<Persona> p9 = personas.OrderByDescending(x => x.Numero).ThenBy(x=>x.Nombre).ToList();
            List<string> p10 = personas.Select(x => x.Nombre).ToList();            
        }
    }
}
