using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea02.Capitulo07
{
    public partial class Diccionario : Form
    {
        public Diccionario()
        {
            InitializeComponent();
        }

        private void Diccionario_Load(object sender, EventArgs e)
        {

        }
    }
}

/*
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
    */
