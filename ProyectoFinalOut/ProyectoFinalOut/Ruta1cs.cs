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
    public partial class frmRuta1 : Form
    {
        public frmRuta1()
        {
            InitializeComponent();
            Size = new Size(940, 660);
            StartPosition = FormStartPosition.CenterScreen;
            MaximizeBox = false; // Deshabilitar el botón de maximizar
            FormBorderStyle = FormBorderStyle.FixedSingle; // Establecer el borde del formulario a un tamaño fijo

            // Asignar eventos para cada botón
            btnAtras.MouseEnter += new EventHandler(Button_MouseEnter);
            btnAtras.MouseLeave += new EventHandler(Button_MouseLeave);

            btnSSalir.MouseEnter += new EventHandler(Button_MouseEnter);
            btnSSalir.MouseLeave += new EventHandler(Button_MouseLeave);

            btnCasa.MouseEnter += new EventHandler(Button_MouseEnter);
            btnCasa.MouseLeave += new EventHandler(Button_MouseLeave);

            btnRecomendaciones.MouseEnter += new EventHandler(Button_MouseEnter);
            btnRecomendaciones.MouseLeave += new EventHandler(Button_MouseLeave);

            btnVerMapa.MouseEnter += new EventHandler(Button_MouseEnter);
            btnVerMapa.MouseLeave += new EventHandler(Button_MouseLeave);

        }


        //Metodos para los botones dinamicos
        private void Button_MouseEnter(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                // Aumentar el tamaño del botón
                button.Size = new Size(button.Width + 10, button.Height + 10);
            }
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                // Restaurar el tamaño del botón
                button.Size = new Size(button.Width - 10, button.Height - 10);
            }
        }



        private void frmRuta1_Load(object sender, EventArgs e)
        {

        }

        private void btnRecomendaciones_Click(object sender, EventArgs e)
        {
            //frmForoRecomendaciones fr1 = new frmForoRecomendaciones();
            //this.Hide();
            //fr1.ShowDialog(); //Muestro formulario
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void btnCasa_Click_1(object sender, EventArgs e)
        {
            Ventana2 vt2 = new Ventana2();
            this.Hide();
            vt2.ShowDialog(); //Muestro formulario
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            frmTutransporti tp4 = new frmTutransporti();
            this.Hide();
            tp4.ShowDialog(); //Muestro formulario
        }

        private void btnSSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Confirrmar Envio", "QUEJAS Y RECOMENDACIONES", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                string mensaje = txtRecomendaciones.Text;
                frmForoRecomendaciones fr = new frmForoRecomendaciones(mensaje);
                this.Hide();
                fr.ShowDialog();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void botones1_Click(object sender, EventArgs e)
        {
            MapaRuta1 tp4 = new MapaRuta1();
            this.Hide();
            tp4.ShowDialog(); //Muestro formulario
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtRecomendaciones_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
