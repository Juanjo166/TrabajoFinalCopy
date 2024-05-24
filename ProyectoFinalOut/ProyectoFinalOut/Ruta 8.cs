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
    public partial class frmRuta8 : Form
    {
        public frmRuta8()
        {
            InitializeComponent();
          
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            Transportes2 tr2 = new Transportes2();
            this.Hide();
            tr2.ShowDialog(); //Muestro formulario
        }

        private void btnCasa_Click(object sender, EventArgs e)
        {
            Ventana2 vt2 = new Ventana2();
            this.Hide();
            vt2.ShowDialog(); //Muestro formulario
        }

        private void frmRuta8_Load(object sender, EventArgs e)
        {

        }
    }
}
