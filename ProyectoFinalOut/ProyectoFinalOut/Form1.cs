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



        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            Ventana2 Vt2 = new Ventana2();
            this.Hide();
            Vt2.ShowDialog(); //Muestro formulario

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmTransporti_Load(object sender, EventArgs e)
        {
            //HOLA CON TODOS vomate tu gaaaaaaa
            //gasajhjhdddf
            //AAAAAAAASASSDSAFSAG
            //ultimo comentario
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
//gaaaaaaaaaaaaaaaaa
//ella no te amma
