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
    public partial class Agenda : Form
    {
        public Agenda()
        {
            InitializeComponent();
        }

        private void Agenda_Load(object sender, EventArgs e)
        {

        }
    }
}

/*
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
 */
