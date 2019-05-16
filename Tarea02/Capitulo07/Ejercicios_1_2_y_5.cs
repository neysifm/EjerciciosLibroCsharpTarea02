using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Tarea02.Capitulo07
{
    class Ejercicios_1_2_y_5
    {
        //Calcular promedio, calificacion maxima y minima utiliando arrayList de collections.

        public static void Ejercicio01()
        {
            int salida = 0;
            int i = 0;
            ArrayList acalificaciones = new ArrayList();
            float calificacion = 0f;
            float maxima = 0f;
            float minima = 100f;

            Console.WriteLine("Cuando Desee terminar de agregar notas , digite -1\n");
            do
            {
                Console.WriteLine("Digite la calificacion del estudiante: {0}", i + 1);
                calificacion = Convert.ToSingle(Console.ReadLine());

                if (maxima < calificacion)
                    maxima = calificacion;
                if (minima > calificacion && calificacion != -1)
                    minima = calificacion;
                if (calificacion == -1)
                    salida = Convert.ToInt32(calificacion);
                else
                    acalificaciones.Add(calificacion);
                i++;

            } while (salida != -1);

            float promedio = 0f;

            foreach (float n in acalificaciones)
            {
                promedio += n;
            }
            Console.WriteLine("Promedio: " + promedio / acalificaciones.Count);
            Console.WriteLine("NotaMaxima: " + maxima);
            Console.WriteLine("NotaMinima: " + minima);
        }

        //Utilizar una tabla hash para crear un diccionario.

        public static void Ejercicio02()
        {
            Hashtable dic = new Hashtable();
            Console.WriteLine("Cantidad de conceptos a agregar:");
            int j = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < j; i++)
            {
                Console.WriteLine("Palabra: ");
                String palabra = Console.ReadLine();
                Console.WriteLine("Significado: ");
                String definicion = Console.ReadLine();
                dic.Add(palabra, definicion);
            }
            foreach (DictionaryEntry d in dic)
            {
                Console.WriteLine("{0}: {1}", d.Key, d.Value);
            }
        }
        
        //Hacer una agenda telefonica que guarde el nombre de la persona y su numero de telefono.

        public static void Ejercicio05()
        {
            Hashtable contactos = new Hashtable();
            Console.WriteLine("Cantidad Contactos: ");
            int j = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < j; i++)
            {
                Console.WriteLine("Nombre: ");
                String nombre = Console.ReadLine();
                Console.WriteLine("Numero telefonico: ");
                int numero = Convert.ToInt32(Console.ReadLine());
                contactos.Add(nombre, numero);
            }
            foreach (DictionaryEntry d in contactos)
            {
                Console.WriteLine("{0}: {1}", d.Key, d.Value);
            }
        }
    }
}
