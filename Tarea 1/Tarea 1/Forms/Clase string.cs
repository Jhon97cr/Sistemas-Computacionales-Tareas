using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_1
{
    public partial class Clase_string : Form
    {
        public Clase_string()
        {
            InitializeComponent();
        }

        string Palabra_1;
        string Palabra_2;
        string Palabra_3;
        string Palabra_4;

        private void btnConcat_Click(object sender, EventArgs e)
        {
            Palabra_1 = txtPalabra1.Text;
            Palabra_2 = txtPalabra2.Text;

            txtResultado.Text = String.Concat(Palabra_1," ", Palabra_2);
        }

        private void btnUpper_Click(object sender, EventArgs e)
        {
            Palabra_3 = txtPalabra3.Text;

            txtResultado2.Text = Palabra_3.ToUpper();
        }

        private void btnTrim_Click(object sender, EventArgs e)
        {
            Palabra_4 = txtPalabra4.Text;
            txtResultado3.Text = Palabra_4.Trim();

        }
        private void txtPalabra_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
