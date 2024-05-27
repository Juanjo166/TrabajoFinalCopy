using System;
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
    public partial class Ventana2 : Form
    {
        public Ventana2()
        {
            InitializeComponent();
            Size = new Size(940, 660);
            StartPosition = FormStartPosition.CenterScreen;

            MaximizeBox = false; // Deshabilitar el botón de maximizar
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ventana2_Load(object sender, EventArgs e)
        {
            lblBienvenida.Text = $"¡Bienvenido {Usuario.Nombre} Estamos para \n ayudarlo en su recorrido!";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmTutransporti tp = new frmTutransporti();
            this.Hide();
            tp.ShowDialog(); //Muestro formulario
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            frmVentana3Respuesta vtr3 = new frmVentana3Respuesta();
            this.Hide();
            vtr3.ShowDialog(); //Muestro formulario
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmNoticias Vt2 = new frmNoticias();
            this.Hide();
            Vt2.ShowDialog(); //Muestro formulario
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            frmTransporti vp = new frmTransporti();
            this.Hide();
            vp.ShowDialog();
        }
    }
}
