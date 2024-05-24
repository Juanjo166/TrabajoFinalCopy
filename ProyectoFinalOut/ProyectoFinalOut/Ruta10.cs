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
    public partial class frmRuta10 : Form
    {
        public frmRuta10()
        {
            InitializeComponent();
            Size = new Size(940, 660);
            StartPosition = FormStartPosition.CenterScreen;
            MaximizeBox = false; // Deshabilitar el botón de maximizar
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void frmRuta10_Load(object sender, EventArgs e)
        {

        }

        private void btnCasa_Click(object sender, EventArgs e)
        {
            Ventana2 vt2 = new Ventana2();
            this.Hide();
            vt2.ShowDialog();
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

    }
}
