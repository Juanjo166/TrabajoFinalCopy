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
    public partial class frmRuta7 : Form
    {
        public frmRuta7()
        {
            InitializeComponent();
            Size = new Size(940, 660);
            StartPosition = FormStartPosition.CenterScreen;
            MaximizeBox = false; // Deshabilitar el botón de maximizar
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void frmRuta7_Load(object sender, EventArgs e)
        {

        }

        private void btnCasa_Click(object sender, EventArgs e)
        {
            Ventana2 vt2 = new Ventana2();
            this.Hide();
            vt2.ShowDialog(); //Muestro formulario
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            frmTutransporti tp4 = new frmTutransporti();
            this.Hide();
            tp4.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void lblRuta7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnRecomendaciones_Click(object sender, EventArgs e)
        {
            frmForoRecomendaciones fr = new frmForoRecomendaciones();
            this.Hide();
            fr.ShowDialog(); //Muestro formulario
        }
    }
}