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
    public partial class frmRuta10 : Form
    {
        public frmRuta10()
        {
            InitializeComponent();
            Size = new Size(940, 660);
            StartPosition = FormStartPosition.CenterScreen;
            MaximizeBox = false; // Deshabilitar el botón de maximizar
            FormBorderStyle = FormBorderStyle.FixedSingle;

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



        private void button1_Click(object sender, EventArgs e)
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

        private void frmRuta10_Load(object sender, EventArgs e)
        {

        }

        private void btnRecomendaciones_Click(object sender, EventArgs e)
        {
            //frmForoRecomendaciones fr = new frmForoRecomendaciones();
            //this.Hide();
            //fr.ShowDialog(); //Muestro formulario
        }

        private void btnCasa_Click_1(object sender, EventArgs e)
        {
            Ventana2 vt2 = new Ventana2();
            this.Hide();
            vt2.ShowDialog();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            frmTutransporti tp4 = new frmTutransporti();
            this.Hide();
            tp4.ShowDialog();
        }

        private void btnSSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void btnVerMapa_Click(object sender, EventArgs e)
        {
            MapaRuta9 vt2 = new MapaRuta9();
            this.Hide();
            vt2.ShowDialog();
        }
    }
}
