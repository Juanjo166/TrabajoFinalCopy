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
    public partial class MapaRuta1 : Form
    {
        public MapaRuta1()
        {
            InitializeComponent();
            Size = new Size(900, 1000);
            StartPosition = FormStartPosition.CenterScreen;
            MaximizeBox = false; // Deshabilitar el botón de maximizar
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void MapaRuta1_Load(object sender, EventArgs e)
        {
            
            
        }

        private void btnSSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            frmRuta1 tp4 = new frmRuta1();
            this.Hide();
            tp4.ShowDialog(); //Muestro formulario
        }
    }
}
