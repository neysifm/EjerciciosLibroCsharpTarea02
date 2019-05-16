using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea02.Capitulo05
{
    public partial class Factorial : Form
    {
        public Factorial()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int x, s = 1; //Se declaran dos variables.
            x = Convert.ToInt32(textBoxNumero.Text); //Se realiza la conversion a tipo entero.
            if (x == 0)
            {
                textBoxFactorial.Text = s.ToString();
            }
            else
            {
                for (int i = 1; i <= x; i++)
                {
                    s = s * i;
                    textBoxResultado.Text = s.ToString();
                    textBoxFactorial.Text = textBoxNumero.Text;
                }
            }
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Factorial_Load(object sender, EventArgs e)
        {

        }

        private void ButtonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxNumero.Clear();
            textBoxFactorial.Clear();
            textBoxResultado.Clear();
        }
    }
}
