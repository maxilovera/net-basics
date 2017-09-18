using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logica;
using System.Configuration;
using Logica.Clases;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Zoo zoo = new Zoo();

            //Pedir los datos por pantalla
            
            for (int i = 0; i < 5; i++)
            {
                int edad = int.Parse(Console.ReadLine());

                Ave ave = new Ave();

                ave.Edad = edad;
                //Agregar todas las otras propiedades

                zoo.AgregarAnimal(ave);
            }

            List<Animal> animales = zoo.ObtenerAnimalesMayores50Años();

            foreach (Animal animal in animales)
            {
                Console.WriteLine("Animal " + animal.Nombre + " - Edad: " + animal.Edad);
            }            
        }
    }    
}
