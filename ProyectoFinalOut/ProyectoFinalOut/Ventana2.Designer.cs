namespace ProyectoFinalOut
{
    partial class Ventana2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventana2));
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            lblBienvenida = new Label();
            label4 = new Label();
            label5 = new Label();
            comboBoxUbicacion = new ComboBox();
            comboBoxDestino = new ComboBox();
            comboBoxHora = new ComboBox();
            btnNoticias = new Button();
            btnAtras = new Botones();
            btnSSalir = new Botones();
            btnBuscar = new Botones();
            btnVerRutas = new Botones();
            pictureBox3 = new PictureBox();
            textBoxResultado = new TextBox();
            listBoxRutas = new ListBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-3, -3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(98, 91);
            pictureBox2.TabIndex = 22;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-3, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(923, 615);
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(127, 112);
            label2.Name = "label2";
            label2.Size = new Size(194, 21);
            label2.TabIndex = 17;
            label2.Text = "Ingresa su ubicación:";
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBienvenida.Location = new Point(128, 51);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(321, 46);
            lblBienvenida.TabIndex = 23;
            lblBienvenida.Text = "¡Bienvenido! \r\nEstamos para ayudarlo en su recorrido.";
            lblBienvenida.TextAlign = ContentAlignment.MiddleCenter;
            lblBienvenida.Click += lblBienvenida_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(128, 196);
            label4.Name = "label4";
            label4.Size = new Size(234, 21);
            label4.TabIndex = 24;
            label4.Text = "Ingresa a donde se dirige:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(127, 279);
            label5.Name = "label5";
            label5.Size = new Size(146, 21);
            label5.TabIndex = 26;
            label5.Text = "Ingresa la hora:";
            // 
            // comboBoxUbicacion
            // 
            comboBoxUbicacion.FormattingEnabled = true;
            comboBoxUbicacion.Location = new Point(127, 145);
            comboBoxUbicacion.Name = "comboBoxUbicacion";
            comboBoxUbicacion.Size = new Size(271, 28);
            comboBoxUbicacion.TabIndex = 30;
            // 
            // comboBoxDestino
            // 
            comboBoxDestino.FormattingEnabled = true;
            comboBoxDestino.Location = new Point(127, 234);
            comboBoxDestino.Name = "comboBoxDestino";
            comboBoxDestino.Size = new Size(271, 28);
            comboBoxDestino.TabIndex = 31;
            // 
            // comboBoxHora
            // 
            comboBoxHora.FormattingEnabled = true;
            comboBoxHora.Location = new Point(127, 316);
            comboBoxHora.Name = "comboBoxHora";
            comboBoxHora.Size = new Size(148, 28);
            comboBoxHora.TabIndex = 32;
            // 
            // btnNoticias
            // 
            btnNoticias.Cursor = Cursors.Hand;
            btnNoticias.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnNoticias.Image = (Image)resources.GetObject("btnNoticias.Image");
            btnNoticias.ImageAlign = ContentAlignment.MiddleRight;
            btnNoticias.Location = new Point(515, 85);
            btnNoticias.Name = "btnNoticias";
            btnNoticias.Size = new Size(283, 48);
            btnNoticias.TabIndex = 33;
            btnNoticias.Text = "Noticias y anuncios importantes \r\nsobre el servicio de autobuses";
            btnNoticias.TextAlign = ContentAlignment.MiddleLeft;
            btnNoticias.UseVisualStyleBackColor = true;
            btnNoticias.Click += button2_Click;
            // 
            // btnAtras
            // 
            btnAtras.BackColor = Color.SteelBlue;
            btnAtras.Cursor = Cursors.Hand;
            btnAtras.FlatAppearance.BorderSize = 0;
            btnAtras.FlatStyle = FlatStyle.Flat;
            btnAtras.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAtras.ForeColor = Color.Black;
            btnAtras.Image = (Image)resources.GetObject("btnAtras.Image");
            btnAtras.ImageAlign = ContentAlignment.TopCenter;
            btnAtras.Location = new Point(669, 503);
            btnAtras.Margin = new Padding(3, 4, 3, 4);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(97, 97);
            btnAtras.TabIndex = 35;
            btnAtras.Text = "ATRAS";
            btnAtras.TextAlign = ContentAlignment.BottomCenter;
            btnAtras.UseVisualStyleBackColor = false;
            btnAtras.Click += btnAtras_Click_1;
            // 
            // btnSSalir
            // 
            btnSSalir.BackColor = Color.SteelBlue;
            btnSSalir.Cursor = Cursors.Hand;
            btnSSalir.FlatAppearance.BorderSize = 0;
            btnSSalir.FlatStyle = FlatStyle.Flat;
            btnSSalir.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSSalir.ForeColor = Color.Black;
            btnSSalir.Image = (Image)resources.GetObject("btnSSalir.Image");
            btnSSalir.ImageAlign = ContentAlignment.TopCenter;
            btnSSalir.Location = new Point(808, 504);
            btnSSalir.Margin = new Padding(3, 4, 3, 4);
            btnSSalir.Name = "btnSSalir";
            btnSSalir.Size = new Size(102, 96);
            btnSSalir.TabIndex = 36;
            btnSSalir.Text = "SALIR";
            btnSSalir.TextAlign = ContentAlignment.BottomCenter;
            btnSSalir.UseVisualStyleBackColor = false;
            btnSSalir.Click += btnSSalir_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.SteelBlue;
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = Color.Gold;
            btnBuscar.Image = (Image)resources.GetObject("btnBuscar.Image");
            btnBuscar.ImageAlign = ContentAlignment.TopCenter;
            btnBuscar.Location = new Point(389, 378);
            btnBuscar.Margin = new Padding(3, 4, 3, 4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(108, 93);
            btnBuscar.TabIndex = 37;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.TextAlign = ContentAlignment.BottomCenter;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnSiguiente_Click_1;
            // 
            // btnVerRutas
            // 
            btnVerRutas.BackColor = Color.SteelBlue;
            btnVerRutas.Cursor = Cursors.Hand;
            btnVerRutas.FlatAppearance.BorderSize = 0;
            btnVerRutas.FlatStyle = FlatStyle.Flat;
            btnVerRutas.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVerRutas.ForeColor = Color.Gold;
            btnVerRutas.Image = (Image)resources.GetObject("btnVerRutas.Image");
            btnVerRutas.ImageAlign = ContentAlignment.MiddleRight;
            btnVerRutas.Location = new Point(531, 158);
            btnVerRutas.Margin = new Padding(3, 4, 3, 4);
            btnVerRutas.Name = "btnVerRutas";
            btnVerRutas.Size = new Size(187, 97);
            btnVerRutas.TabIndex = 38;
            btnVerRutas.Text = "VER TODAS\r\nLAS RUTAS";
            btnVerRutas.TextAlign = ContentAlignment.MiddleLeft;
            btnVerRutas.UseVisualStyleBackColor = false;
            btnVerRutas.Click += btnVerRutas_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(128, 378);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(39, 41);
            pictureBox3.TabIndex = 47;
            pictureBox3.TabStop = false;
            // 
            // textBoxResultado
            // 
            textBoxResultado.ForeColor = Color.Red;
            textBoxResultado.Location = new Point(173, 364);
            textBoxResultado.Multiline = true;
            textBoxResultado.Name = "textBoxResultado";
            textBoxResultado.Size = new Size(193, 66);
            textBoxResultado.TabIndex = 46;
            // 
            // listBoxRutas
            // 
            listBoxRutas.FormattingEnabled = true;
            listBoxRutas.Location = new Point(322, 274);
            listBoxRutas.Name = "listBoxRutas";
            listBoxRutas.Size = new Size(150, 84);
            listBoxRutas.TabIndex = 48;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(93, 35);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(404, 403);
            pictureBox4.TabIndex = 49;
            pictureBox4.TabStop = false;
            // 
            // Ventana2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 613);
            Controls.Add(listBoxRutas);
            Controls.Add(pictureBox3);
            Controls.Add(textBoxResultado);
            Controls.Add(btnVerRutas);
            Controls.Add(btnBuscar);
            Controls.Add(btnSSalir);
            Controls.Add(btnAtras);
            Controls.Add(btnNoticias);
            Controls.Add(comboBoxHora);
            Controls.Add(comboBoxDestino);
            Controls.Add(comboBoxUbicacion);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lblBienvenida);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox1);
            Name = "Ventana2";
            Text = "Ventana2";
            Load += Ventana2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label2;
        private Label lblBienvenida;
        private Label label4;
        private Label label5;
        private ComboBox comboBoxUbicacion;
        private ComboBox comboBoxDestino;
        private ComboBox comboBoxHora;
        private Button btnNoticias;
        private Botones btnAtras;
        private Botones btnSSalir;
        private Botones btnBuscar;
        private Botones btnVerRutas;
        private PictureBox pictureBox3;
        private TextBox textBoxResultado;
        private ListBox listBoxRutas;
        private PictureBox pictureBox4;
    }
}