using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Tarea02.Capitulo08
{
    class Ejercicios_3_y_5
    {
        //Hacer un programa que muestre la hora del día en formato AM/FM seguida del año, el día y el mes actual.

        public static void Ejercicio03()
        {
            Console.WriteLine(DateTime.Now.ToString("hh:mm tt yyyy/dd/MM"));
        }

        //Hacer un programa que le solicite al usuario dos cadenas y luego las muestreen orden alfabético.

        public static void Ejercicio05()
        {
            Console.WriteLine("Entrada1: ");
            String cadena1 = Console.ReadLine();
            Console.WriteLine("Entrada2: ");
            String cadena2 = Console.ReadLine();
            ArrayList order = new ArrayList
            {
                cadena1,
                cadena2
            };
            order.Sort();
            Console.WriteLine("Ordenado: ");
            foreach (String cadena in order)
            {
                Console.WriteLine("{0}", cadena);
            }
        }
    }
}
