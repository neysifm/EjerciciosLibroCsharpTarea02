using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea02.Capitulo06
{
    class Ejercicios_1_2_3_4_y_5
    {
        //Agregar el cálculo del promedio para el programa con arreglo jagged.

        public static void Ejercicio01()
        {
            int alumnos = 0, salon = 0;
            float acum = 0.0f;
            float promedio = 0.0f;

            Console.Write("Salones: ");
            salon = Convert.ToInt32(Console.ReadLine());

            float[][] calificaciones = new float[salon][];

            for (int i = 0; i < salon; i++)
            {
                Console.Write("Alumnos en Curso: " + (i + 1));
                alumnos = Convert.ToInt32(Console.ReadLine());
                calificaciones[i] = new float[alumnos];
            }

            for (int i = 0; i < salon; i++)
            {
                Console.WriteLine("Salon: " + (i + 1));
                for (int j = 0; j < calificaciones[i].GetLength(0); j++)
                {
                    Console.Write("Estudiante  " + (1 + j));
                    calificaciones[i][j] = Convert.ToSingle(Console.ReadLine());
                }
            }

            for (int i = 0; i < salon; i++)
            {
                for (int j = 0; j < calificaciones[i].GetLength(0); j++)
                {
                    acum += (float)calificaciones[i][j];
                }
            }
            promedio = acum / (alumnos * salon);
            Console.WriteLine("El promedio es:" + promedio);
        }

        //Agregar el cálculo de la menor calificación para el programa con arreglo jagged.

        public static void Ejercicio02()
        {
            int alumnos = 0, cursos = 0, i = 0, j = 0;
            float minima = 100.0f;
            Console.Write("Cantidad Cursos: ");
            cursos = Convert.ToInt32(Console.ReadLine());
            float[][] calificaciones = new float[cursos][];

            for (i = 0; i < cursos; i++)
            {
                Console.Write("Salon " + (i + 1) + " Cantidad estudiantes: ");
                alumnos = Convert.ToInt32(Console.ReadLine());
                calificaciones[i] = new float[alumnos];
            }

            for (i = 0; i < cursos; i++)
            {
                Console.WriteLine("Aula: " + (i + 1));
                for (j = 0; j < calificaciones[i].GetLength(0); j++)
                {
                    Console.Write("Nota: ");
                    calificaciones[i][j] = Convert.ToSingle(Console.ReadLine());
                }
            }

            for (i = 0; i < cursos; i++)
            {
                for (j = 0; j < calificaciones[i].GetLength(0); j++)
                {
                    if (calificaciones[i][j] < minima)
                    {
                        minima = calificaciones[i][j];
                    }
                }
            }
            Console.WriteLine("Nota Minima: " + minima);
        }

        //Agregar el cálculo de la mayor calificación para el programa con arreglo jagged.

        public static void Ejercicio03()
        {
            int nalumnos = 0, ncursos = 0, i = 0, j = 0;
            float maxima = 0;
            Console.Write("Cantidad Cursos: ");
            ncursos = Convert.ToInt32(Console.ReadLine());
            float[][] calificaciones = new float[ncursos][];
            for (i = 0; i < ncursos; i++)
            {
                Console.Write("Salon " + (i + 1) + " Cantidad estudiantes: ");
                nalumnos = Convert.ToInt32(Console.ReadLine());
                calificaciones[i] = new float[nalumnos];
            }

            for (i = 0; i < ncursos; i++)
            {
                Console.WriteLine("Aula: " + (i + 1));
                for (j = 0; j < calificaciones[i].GetLength(0); j++)
                {
                    Console.Write("Nota: ");
                    calificaciones[i][j] = Convert.ToSingle(Console.ReadLine());
                }
            }

            for (i = 0; i < ncursos; i++)
            {
                for (j = 0; j < calificaciones[i].GetLength(0); j++)
                {
                    if (calificaciones[i][j] > maxima)
                    {
                        maxima = calificaciones[i][j];
                    }
                }
            }
            Console.WriteLine("Nota Maxima: " + maxima);
        }

        //Modificar el programa de la escuela para que utilice funciones.

        public static void Ejercicio04()
        {
            int alumnos = 0, salon = 0;
            float acum = 0.0f;
            float promedio = 0.0f;
            Console.Write("Cantidad Aulas:  ");
            salon = Convert.ToInt32(Console.ReadLine());
            float[][] calificaciones = new float[salon][];

            for (int i = 0; i < salon; i++)
            {
                Console.Write("Estudiantes para aula: " + (i + 1));
                alumnos = Convert.ToInt32(Console.ReadLine());
                calificaciones[i] = new float[alumnos];
            }

            for (int i = 0; i < salon; i++)
            {
                Console.WriteLine("Para el aula:  " + (i + 1));
                for (int j = 0; j < calificaciones[i].GetLength(0); j++)
                {
                    Console.Write("Nota estudiante: " + (1 + j));
                    calificaciones[i][j] = Convert.ToSingle(Console.ReadLine());
                }
            }

            for (int i = 0; i < salon; i++)
            {
                for (int j = 0; j < calificaciones[i].GetLength(0); j++)
                {
                    acum += calificaciones[i][j];
                }
            }
            promedio = acum / (alumnos * salon);
            Console.WriteLine("Promedio es: " + promedio);
        }

        //Crear un programa que pase un arreglo jagged como parámetro a una función.

        public static void Ejercicio05(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.WriteLine("Elementos({0},{1})={2}", i, j, arr[i, j]);
                }
            }
        }
    }
}
