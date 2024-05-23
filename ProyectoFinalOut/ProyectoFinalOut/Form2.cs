﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalOut
{
    public partial class frmTutransporti : Form
    {
        public frmTutransporti()
        {
            InitializeComponent();
            Size = new Size(940, 660);
            StartPosition = FormStartPosition.CenterScreen;
            MaximizeBox = false; // Deshabilitar el botón de maximizar
            FormBorderStyle = FormBorderStyle.FixedSingle; // Establecer el borde del formulario a un tamaño fijo
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRuta1_Click(object sender, EventArgs e)
        {
            frmRuta1 rt1 = new frmRuta1();
            this.Hide();
            rt1.ShowDialog(); //Muestro formulario
        }

        private void frmTutransporti_Load(object sender, EventArgs e)
        {
            
        }
    }
}