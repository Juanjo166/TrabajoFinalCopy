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
    public partial class frmRuta1 : Form
    {
        public frmRuta1()
        {
            InitializeComponent();
            Size = new Size(940, 660);
            StartPosition = FormStartPosition.CenterScreen;
            MaximizeBox = false; // Deshabilitar el botón de maximizar
            FormBorderStyle = FormBorderStyle.FixedSingle; // Establecer el borde del formulario a un tamaño fijo
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCasa_Click(object sender, EventArgs e)
        {
            frmTutransporti ttp = new frmTutransporti();
            this.Hide();
            ttp.ShowDialog(); //Muestro formulario
        }

        private void frmRuta1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
