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
    public partial class Clase_Math : Form
    {
        public Clase_Math()
        {
            InitializeComponent();
        }

        double Numero1;
        double Numero2;
        double Potencia;

        private void btnLog_Click(object sender, EventArgs e)
        {
            Numero1 = Convert.ToDouble(txtNumero1.Text);
            txtResultado1.Text = Math.Log(Numero1).ToString();
        }

        private void btnElevar_Click(object sender, EventArgs e)
        {
            Numero2 = Convert.ToDouble(txtNumero2.Text);
            Potencia = Convert.ToDouble(txtPotencia.Text);

            txtResultado2.Text = Math.Pow(Numero1, Potencia).ToString();
        }

        private void Clase_Math_Load(object sender, EventArgs e)
        {
        }

      
    }
}
