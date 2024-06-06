namespace ProyectoFinalOut
{
    public partial class frmTransporti : Form
    {

        public frmTransporti()
        {
            InitializeComponent();
            Size = new Size(940, 660);
            StartPosition = FormStartPosition.CenterScreen;

            MaximizeBox = false; // Deshabilitar el botón de maximizar
            FormBorderStyle = FormBorderStyle.FixedSingle;


            // Asignar eventos para cada botón

            btnSiguiente.MouseEnter += new EventHandler(Button_MouseEnter);
            btnSiguiente.MouseLeave += new EventHandler(Button_MouseLeave);

            btnSSalir.MouseEnter += new EventHandler(Button_MouseEnter);
            btnSSalir.MouseLeave += new EventHandler(Button_MouseLeave);

            btnNoticias.MouseEnter += new EventHandler(Button_MouseEnter);
            btnNoticias.MouseLeave += new EventHandler(Button_MouseLeave);


        }

        //Metodos de animacion de botones
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

        private void frmTransporti_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmNoticias Vt2 = new frmNoticias();
            this.Hide();
            Vt2.ShowDialog(); //Muestro formulario

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSiguiente_Click_1(object sender, EventArgs e)
        {
            Usuario.Nombre = txtNombre.Text;
            Ventana2 Vt2 = new Ventana2();
            this.Hide();
            Vt2.ShowDialog(); //Muestro formulario
        }

        private void btnSSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

