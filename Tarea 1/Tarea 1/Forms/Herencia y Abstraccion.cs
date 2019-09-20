using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarea_1.Herencia;
using Tarea_1.Abstraccion;

namespace Tarea_1.Forms
{
    public partial class Herencia_y_Abstraccion : Form
    {
        public Herencia_y_Abstraccion()
        {
            InitializeComponent();
        }

        private void btnHerencia_Click(object sender, EventArgs e)
        {
            Empleado emp = new Empleado();
            emp.Nombre = "Jhonattan";
            emp.Edad = 22;
            emp.Cedula = 116830591;
            emp.LugarResidencia = "El alto, Guadalupe";
            emp.Puesto = "Estudiante";

            MessageBox.Show("Bienvenido " +  emp.Nombre + " de: " + emp.Edad + " años de edad, de la cedula: " + 
                emp.Cedula + ", que reside en: " + emp.LugarResidencia + " y posee el puesto de: " +
                emp.Puesto + " ","Test 1");
            


        }

        double Altura;
        double BaseT;
        private void btnCalculo_Click(object sender, EventArgs e)
        {
            Triangulo T = new Triangulo();
            Altura = Convert.ToDouble(txtAltura.Text);
            BaseT = Convert.ToDouble(txtBase.Text);

            txtResultado.Text = Convert.ToString((Altura * BaseT) / 2);

            if (Convert.ToDouble(txtResultado.Text) > 10)
            {
                txtTipoT.Text = "Triangulo 1";

            } else if (Convert.ToDouble(txtResultado.Text) < 10)
            {
                txtTipoT.Text = "Triangulo 2";
            }
}

        
    }
}
