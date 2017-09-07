using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Directivo profe1 = new Directivo(100);
            Directivo profe2 = new Directivo(200);

            Console.WriteLine("Ingrese nombre de método (M1 o M2):");
            string key = Console.ReadLine();

            switch (key)
            {
                case "M1":
                    Console.WriteLine(profe1.M1());
                    Console.WriteLine(profe2.M1());
                    break;
                case "M2":
                    Console.WriteLine(profe1.M2());
                    Console.WriteLine(profe2.M2());
                    break;
                default:
                    break;
            }

            Console.Read();
        }
    }

    public class Persona
    {
        public int Prop1 { get; set; }

        /// <summary>
        /// Ejemplo de un método. La implementación no tiene sentido lógico
        /// </summary>
        /// <returns></returns>
        public string M1()
        {
            return (this.Prop1 * 100).ToString();
        }
    }

    public class Directivo : Persona
    {
        protected int Prop2 { get; set; }
        public int Prop3 { get; set; }

        public Directivo(int id)
        {
            this.Prop2 = 1000;
            this.Prop3 = id;
        }

        /// <summary>
        /// Ejemplo de un método. La implementación no tiene sentido lógico
        /// </summary>
        /// <returns></returns>
        public string M2()
        {            
            return this.Prop2.ToString() + " - " + this.Prop3.ToString();
        }
    }
}
