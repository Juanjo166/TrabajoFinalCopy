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
    public partial class MapaRuta17 : Form
    {
        public MapaRuta17()
        {
            InitializeComponent();
            Size = new Size(900, 1000);
            StartPosition = FormStartPosition.CenterScreen;
            MaximizeBox = false; // Deshabilitar el botón de maximizar
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            frmRuta8 tp4 = new frmRuta8();
            this.Hide();
            tp4.ShowDialog(); //Muestro formulario
        }

        private void MapaRuta6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
