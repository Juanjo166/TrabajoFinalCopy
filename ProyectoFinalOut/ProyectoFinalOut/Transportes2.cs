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
    public partial class Transportes2 : Form
    {
        public Transportes2()
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

            btnRuta8.MouseEnter += new EventHandler(Button_MouseEnter);
            btnRuta8.MouseLeave += new EventHandler(Button_MouseLeave);

            btnRuta14.MouseEnter += new EventHandler(Button_MouseEnter);
            btnRuta14.MouseLeave += new EventHandler(Button_MouseLeave);

            btnRuta21.MouseEnter += new EventHandler(Button_MouseEnter);
            btnRuta21.MouseLeave += new EventHandler(Button_MouseLeave);

            btnRuta3.MouseEnter += new EventHandler(Button_MouseEnter);
            btnRuta3.MouseLeave += new EventHandler(Button_MouseLeave);


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



        private void Transportes2_Load(object sender, EventArgs e)
        {
            lblBienvenida.Text = $"¡Hola {Usuario.Nombre}, elige el numero de la ruta \n del que quiera informarse!";
        }

        private void btnRuta8_Click_1(object sender, EventArgs e)
        {
            frmRuta8 rt8 = new frmRuta8();
            this.Hide();
            rt8.ShowDialog(); //Muestro formulario
        }

        private void btnRuta14_Click(object sender, EventArgs e)
        {
            frmRurta14 rt14 = new frmRurta14();
            this.Hide();
            rt14.ShowDialog(); //Muestro formulario
        }

        private void btnRuta21_Click(object sender, EventArgs e)
        {
            frmRuta21 rt21 = new frmRuta21();
            this.Hide();
            rt21.ShowDialog(); //Muestro formulario
        }

        private void btnCasa_Click(object sender, EventArgs e)
        {
            Ventana2 vt2 = new Ventana2();
            this.Hide();
            vt2.ShowDialog(); //Muestro formulario
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            frmTutransporti tp3 = new frmTutransporti();
            this.Hide();
            tp3.ShowDialog(); //Muestro formulario
        }

        private void btnSSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
