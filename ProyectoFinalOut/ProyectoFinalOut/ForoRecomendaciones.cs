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
    public partial class frmForoRecomendaciones : Form
    {
        public frmForoRecomendaciones( string mensaje)
        {
            InitializeComponent();
            txtMensaje.Text = mensaje;
            
            Size = new Size(940, 660);
            StartPosition = FormStartPosition.CenterScreen;

            MaximizeBox = false; // Deshabilitar el botón de maximizar
            FormBorderStyle = FormBorderStyle.FixedSingle;

            // Asignar eventos para cada botón
            

            btnSalir.MouseEnter += new EventHandler(Button_MouseEnter);
            btnSalir.MouseLeave += new EventHandler(Button_MouseLeave);

            btnCasa.MouseEnter += new EventHandler(Button_MouseEnter);
            btnCasa.MouseLeave += new EventHandler(Button_MouseLeave);

            


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

        private void ForoRecomendaciones_Load(object sender, EventArgs e)
        {

        }

        private void btnCasa_Click(object sender, EventArgs e)
        {
            Ventana2 vt2 = new Ventana2();
            this.Hide();
            vt2.ShowDialog();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
