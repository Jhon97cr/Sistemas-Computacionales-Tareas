﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_1.Forms
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void mathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Instanciar clase formulario
            Form formulario = new Clase_Math();

            //Metodo show para mostrar el form Clase_Math
            formulario.Show();
        }

        private void stringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Instanciar clase formulario
            Form formulario = new Clase_string();

            
            //Metodo show para mostrar el form Clase_Math
            formulario.Show();
        }

        private void herenciaYAbstraccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Instanciar clase formulario
            Form formulario = new Herencia_y_Abstraccion();

            //Metodo show para mostrar el form Clase_Math
            formulario.Show();
        }
    }
}
