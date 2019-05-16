using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarea02.Capitulo05;


namespace Tarea02
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void FactorialDeNumeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Capitulo05.Factorial factorial = new Capitulo05.Factorial();
            factorial.Show();
        }

        private void OpcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
