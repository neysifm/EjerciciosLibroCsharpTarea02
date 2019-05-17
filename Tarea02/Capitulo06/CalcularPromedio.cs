using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea02.Capitulo06
{
    public partial class CalcularPromedio : Form
    {
        public CalcularPromedio()
        {
            InitializeComponent();
        }

        private void CalcularPromedio_Load(object sender, EventArgs e)
        {

        }
    }
}
/*
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
    */
