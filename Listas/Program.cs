using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> colores =
                new List<string>();
            colores.Add("azul");
            colores.Add("amarillo");
            colores.Add("rojo");
            colores.Add("morado");
            colores.Add("verde");

            colores.RemoveAt(1);
            colores.Remove("amarillo");

            Console.WriteLine("Número de elementos: " +
                colores.Count);

            int indicecolor = 1;
            foreach(string color in colores)
            {
                Console.WriteLine(
                   "Elemento " + indicecolor.ToString() + 
                    ": " + color);
                indicecolor++;
            }

            Console.Read();
        }
    }
}
