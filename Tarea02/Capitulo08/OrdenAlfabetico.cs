using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea02.Capitulo08
{
    public partial class OrdenAlfabetico : Form
    {
        public OrdenAlfabetico()
        {
            InitializeComponent();
        }

        private void OrdenAlfabetico_Load(object sender, EventArgs e)
        {

        }
    }
}

/*
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
 */
