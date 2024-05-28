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

        private void frmTutransporti_Load(object sender, EventArgs e)
        {
            lblBienvenida.Text = $"¡Hola {Usuario.Nombre}, elige el numero de la ruta \n del que quiera informarse!";
        }
        // ¡Hola, elige el numero del autobus 
        //del que quieres informarte!

        private void btnRuta1_Click_1(object sender, EventArgs e)
        {
            frmRuta1 rt1 = new frmRuta1();
            this.Hide();
            rt1.ShowDialog(); //Muestro formulario
        }

        private void btnRuta6_Click(object sender, EventArgs e)
        {
            frmRuta6 r6 = new frmRuta6();
            this.Hide();
            r6.ShowDialog(); //Muestro formulario
        }

        private void btnRuta10_Click(object sender, EventArgs e)
        {
            frmRuta10 r10 = new frmRuta10();
            this.Hide();
            r10.ShowDialog();
        }

        private void btnRuta7_Click(object sender, EventArgs e)
        {
            frmRuta7 r7 = new frmRuta7();
            this.Hide();
            r7.ShowDialog();
        }

        private void btnCasa_Click(object sender, EventArgs e)
        {
            Ventana2 vt2 = new Ventana2();
            this.Hide();
            vt2.ShowDialog(); //Muestro formulario
        }

        private void btnSiguiente_Click_1(object sender, EventArgs e)
        {
            Transportes2 tp22 = new Transportes2();
            this.Hide();
            tp22.ShowDialog(); //Muestro formulario
        }

        private void btnSSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
