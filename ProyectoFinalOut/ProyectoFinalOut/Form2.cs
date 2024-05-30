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

            // Asignar eventos para cada botón
            btnCasa.MouseEnter += new EventHandler(Button_MouseEnter);
            btnCasa.MouseLeave += new EventHandler(Button_MouseLeave);

            btnSiguiente.MouseEnter += new EventHandler(Button_MouseEnter);
            btnSiguiente.MouseLeave += new EventHandler(Button_MouseLeave);

            btnSSalir.MouseEnter += new EventHandler(Button_MouseEnter);
            btnSSalir.MouseLeave += new EventHandler(Button_MouseLeave);

            btnRuta1.MouseEnter += new EventHandler(Button_MouseEnter);
            btnRuta1.MouseLeave += new EventHandler(Button_MouseLeave);

            btnRuta6.MouseEnter += new EventHandler(Button_MouseEnter);
            btnRuta6.MouseLeave += new EventHandler(Button_MouseLeave);

            btnRuta10.MouseEnter += new EventHandler(Button_MouseEnter);
            btnRuta10.MouseLeave += new EventHandler(Button_MouseLeave);

            btnRuta7.MouseEnter += new EventHandler(Button_MouseEnter);
            btnRuta7.MouseLeave += new EventHandler(Button_MouseLeave);

        }


        //Metodos de botones dinamicos
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
