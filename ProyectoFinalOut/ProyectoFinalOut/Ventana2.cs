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
    public partial class Ventana2 : Form
    {
        // Lista de rutas predefinidas
        private Dictionary<string, List<string>> rutas;
        private Dictionary<string, Form> rutasDictionary;
        public Ventana2()
        {
            InitializeComponent();
            //Datos
            InicializarDatos();
            //Ventana
            Size = new Size(940, 660);
            StartPosition = FormStartPosition.CenterScreen;

            MaximizeBox = false; // Deshabilitar el botón de maximizar
            FormBorderStyle = FormBorderStyle.FixedSingle;

            // Asignar eventos para cada botón
            btnAtras.MouseEnter += new EventHandler(Button_MouseEnter);
            btnAtras.MouseLeave += new EventHandler(Button_MouseLeave);

            btnBuscar.MouseEnter += new EventHandler(Button_MouseEnter);
            btnBuscar.MouseLeave += new EventHandler(Button_MouseLeave);

            btnSSalir.MouseEnter += new EventHandler(Button_MouseEnter);
            btnSSalir.MouseLeave += new EventHandler(Button_MouseLeave);

            btnVerRutas.MouseEnter += new EventHandler(Button_MouseEnter);
            btnVerRutas.MouseLeave += new EventHandler(Button_MouseLeave);

            btnNoticias.MouseEnter += new EventHandler(Button_MouseEnter);
            btnNoticias.MouseLeave += new EventHandler(Button_MouseLeave);

            // Llenar el ComboBox con las horas del día
            for (int i = 6; i < 21; i++)
            {
                comboBoxHora.Items.Add(i.ToString("D2") + ":00");
            }

            //rutas a ventanas
            InicializarRutasDictionary();

        }

        //Metodos de botones de animacion
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

        //Metodo de rutas
        private void InicializarDatos()
        {
            string[] ubicaciones = {
                "Penal de Yanamilla", "Mercado Popular Yanamilla", "Hostal Oro Verde",
                "Calle Malecon", "Lotizacion Cesar Mujica Cacho", "Jr. Ica",
                "Av. Daniel Alcides Carrion", "Av. 9 de Diciembre", "Jr. Arica",
                "Jr. Lucanas hasta la 5ta cuadra", "Av. Arenales", "Via Aprovisa (9 de Diciembre)",
                "Jr. Calle A", "Jr. José Carlos Mariátegui", "Av. Venezuela", "Av. Cusco",
                "Av. Ramón Castilla", "Puente Nuevo", "Av. Valdelirios", "Jr. Dos de Mayo",
                "Calle Itana", "Jr. 28 de Julio", "Jr. Chorro", "Jr. Grau",
                "Jr. Garcilazo de la Vega", "Av. Mariscal Cáceres", "Jr. Asamblea",
                "Av. Independencia", "Av. Universitaria", "Av. Señor de Los Milagros",
                "Vía Evitamiento", "Prolongación Av. Los Incas", "AA.HH. Inti Raymi",
                "Carretera Huanta Ayacucho", "Terminal Totora", "Servicentro Plaza S.A.C.",
                "Jr. Progreso", "Jr. Manuel Alarcón", "Jr. Ciro Alegría", "Jr. Mariano Melgar",
                "Jr. Cesar Vallejo", "Jr. Gonzales Prado", "Jr. Libertad", "Calle Nazareno",
                "Jr. Carlos F. Vivanco", "Pasaje 01 (frontis del Penal)", "Vía Andahuaylas Km 7.6",
                "Av. Vraem", "Mercado Modelo (de Yanama)", "Loza Deportiva R1-S1-T1 (Manzana U-P1-Q1)",
                "Av. Esteban Campos", "Av. Machupicchu", "Av. Javier Heraud", "Av. San Lorenzo",
                "Puente de la Alameda Valdelirios", "Calle San Juan de Dios", "Jr. Las Magnolias",
                "Jr. Las Palmeras", "Via Los Libertadores", "Av. Luis Fassio Masprone",
                "Paradero Inicial", "Av. Héroes de la Pacificación Mz. \"N Lote 11", "Psj. la Mar",
                "Av. los Robles", "Av. General Edwin Donayre", "Av.República", "Calle 13",
                "Calle Numero 2", "Av. Tres (Puerta del Nuevo Hospital)", "Repartición Huatatas Av. Arenales",
                "Av. los Angeles", "Av. las Mercedes", "Av. del Ejercito", "Ovalo Via Evitamiento",
                "Jr. Bella Vista", "Jr.Salvador Cavero (Paradero Huanta)", "Jr.Abraham Valdelomar",
                "Av. del Deporte", "Grifo Gomebol", "Parque Mollepata", "Ingreso Mollepata",
                "Av. Apumayla", "Mollepata Sector I", "Av. Javier Perez De Cuellar",
                "Cuartel \"Los Cabitos\"", "Pasaje Cáceres", "Jr. Manco Capac",
                "Jr. María Montesori (Costado De La Clínica \"El Nazareno\")", "Jr. Arriba Peru",
                "Jr. Morro de Arica", "Jr. Razuhuillca", "Jr. Pisco", "Jr.Cordova",
                "Jose Olaya", "Jr. Agustin Gamarra", "Ovalo del Puente Nuevo", "Jr. Munive",
                "Jr. Madrid", "Jr. Ayacucho", "Posta San Juan", "Plazoleta de Capillapata",
                "Jr. Vista Alegre", "Jr. las Casuarinas", "Urbanización Magisterial",
                "27 de Octubre", "Asoc de Vivienda los Warpas (Nahuinpuquio)"
            };

            comboBoxUbicacion.Items.AddRange(ubicaciones);
            comboBoxDestino.Items.AddRange(ubicaciones);

            // Inicializar rutas
            rutas = new Dictionary<string, List<string>>()
            {
                { "Carmen alto-Puente nuevo", new List<string>{ "Ruta 1", "Ruta 6" } },
                { "Alameda-Jr. Lima", new List<string>{ "Ruta 8" } },
                { "Puente nuevo-Alameda", new List<string>{ "Ruta 14", "Ruta 21" } },
                
            };
        }

        // Función para determinar si es hora de congestión
        private bool EsHoraDeCongestion(int hora)
        {
            // Definir horas de alta congestión (por ejemplo, de 7 a 9 AM y de 5 a 7 PM)
            return (hora >= 7 && hora <= 8) || (hora >= 13 && hora <= 14) || (hora >= 18 && hora <= 20);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ventana2_Load(object sender, EventArgs e)
        {
            lblBienvenida.Text = $"¡Bienvenido {Usuario.Nombre} estamos para \n ayudarlo en su recorrido!";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmNoticias Vt2 = new frmNoticias();
            this.Hide();
            Vt2.ShowDialog(); //Muestro formulario
        }

        private void btnAtras_Click_1(object sender, EventArgs e)
        {
            frmTransporti vp = new frmTransporti();
            this.Hide();
            vp.ShowDialog();
        }

        private void btnSiguiente_Click_1(object sender, EventArgs e)
        {
            string ubicacion = comboBoxUbicacion.SelectedItem?.ToString();
            string destino = comboBoxDestino.SelectedItem?.ToString();

            if (ubicacion == null || destino == null)
            {
                MessageBox.Show("Por favor seleccione una ubicación y un destino.");
                return;
            }

            string claveRuta = $"{ubicacion}-{destino}";
            if (rutas.ContainsKey(claveRuta))
            {
                listBoxRutas.Items.Clear();
                listBoxRutas.Items.AddRange(rutas[claveRuta].ToArray());
            }
            else
            {
                listBoxRutas.Items.Clear();
                listBoxRutas.Items.Add("No hay rutas disponibles para la selección dada.");
            }


            // Obtener la hora seleccionada
            string horaSeleccionada = comboBoxHora.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(horaSeleccionada))
            {
                MessageBox.Show("Por favor, selecciona una hora.");
                return;
            }

            // Convertir la hora seleccionada a un entero
            int hora = int.Parse(horaSeleccionada.Split(':')[0]);

            // Determinar si es una hora de congestión vehicular
            string resultado = EsHoraDeCongestion(hora) ? "Hora de alta congestión vehicular, tome sus precauciones" : "Hora de baja congestión vehicular";

            // Mostrar el resultado en el TextBox
            textBoxResultado.Text = resultado;


        }

        private void btnSSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnVerRutas_Click(object sender, EventArgs e)
        {
            frmTutransporti tp = new frmTutransporti();
            this.Hide();
            tp.ShowDialog(); //Muestro formulario
        }

        private void lblBienvenida_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxUbicacion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }


        //Metodo texto a ventana

        private void InicializarRutasDictionary()
        {
            rutasDictionary = new Dictionary<string, Form>
        {
            { "Ruta 1", new frmRuta1() },
            { "Ruta 6", new frmRuta6() },
            { "Ruta 8", new frmRuta8() },
            { "Ruta 14", new frmRurta14() },
            { "Ruta 7", new frmRuta7() },
            { "Ruta 10", new frmRuta10() },
            { "Ruta 21", new frmRuta21() }
        };
        }


        private void listBoxRutas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedRuta = listBoxRutas.SelectedItem.ToString();
            if (rutasDictionary.ContainsKey(selectedRuta))
            {
                this.Hide();
                rutasDictionary[selectedRuta].ShowDialog();
            }
        }

        private void btnRecomendaciones_Click(object sender, EventArgs e)
        {
            //frmForoRecomendaciones fr = new frmForoRecomendaciones();
            //this.Hide();
            //fr.ShowDialog(); //Muestro formulario
        }
    }
}
