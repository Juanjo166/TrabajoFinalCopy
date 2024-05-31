namespace ProyectoFinalOut
{
    partial class frmTransporti
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransporti));
            txtNombre = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnNoticias = new Button();
            label3 = new Label();
            pictureBox3 = new PictureBox();
            btnSSalir = new Botones();
            btnSiguiente = new Botones();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.BackColor = SystemColors.InactiveCaption;
            txtNombre.Location = new Point(151, 223);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(175, 27);
            txtNombre.TabIndex = 8;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(151, 189);
            label2.Name = "label2";
            label2.Size = new Size(176, 21);
            label2.TabIndex = 7;
            label2.Text = "Ingresa tu nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(181, 56);
            label1.Name = "label1";
            label1.Size = new Size(114, 24);
            label1.TabIndex = 6;
            label1.Text = "Transporti";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(476, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(623, 619);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(191, 83);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(104, 100);
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // btnNoticias
            // 
            btnNoticias.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnNoticias.Image = (Image)resources.GetObject("btnNoticias.Image");
            btnNoticias.ImageAlign = ContentAlignment.MiddleRight;
            btnNoticias.Location = new Point(113, 278);
            btnNoticias.Name = "btnNoticias";
            btnNoticias.Size = new Size(283, 48);
            btnNoticias.TabIndex = 15;
            btnNoticias.Text = "Noticias y anuncios importantes \r\nsobre el servicio de autobuses";
            btnNoticias.TextAlign = ContentAlignment.MiddleLeft;
            btnNoticias.UseVisualStyleBackColor = true;
            btnNoticias.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Green;
            label3.ImageAlign = ContentAlignment.MiddleLeft;
            label3.Location = new Point(123, 520);
            label3.Name = "label3";
            label3.Size = new Size(328, 42);
            label3.TabIndex = 16;
            label3.Text = "El uso del transporte público es \r\nbueno para reducir la contaminación.";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(48, 505);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(70, 75);
            pictureBox3.TabIndex = 17;
            pictureBox3.TabStop = false;
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
            btnSSalir.Location = new Point(257, 389);
            btnSSalir.Margin = new Padding(3, 4, 3, 4);
            btnSSalir.Name = "btnSSalir";
            btnSSalir.Size = new Size(119, 96);
            btnSSalir.TabIndex = 37;
            btnSSalir.Text = "SALIR";
            btnSSalir.TextAlign = ContentAlignment.BottomCenter;
            btnSSalir.UseVisualStyleBackColor = false;
            btnSSalir.Click += btnSSalir_Click;
            // 
            // btnSiguiente
            // 
            btnSiguiente.BackColor = Color.SteelBlue;
            btnSiguiente.Cursor = Cursors.Hand;
            btnSiguiente.FlatAppearance.BorderSize = 0;
            btnSiguiente.FlatStyle = FlatStyle.Flat;
            btnSiguiente.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSiguiente.ForeColor = Color.Black;
            btnSiguiente.Image = (Image)resources.GetObject("btnSiguiente.Image");
            btnSiguiente.ImageAlign = ContentAlignment.TopCenter;
            btnSiguiente.Location = new Point(113, 389);
            btnSiguiente.Margin = new Padding(3, 4, 3, 4);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(122, 100);
            btnSiguiente.TabIndex = 38;
            btnSiguiente.Text = "SIGUIENTE";
            btnSiguiente.TextAlign = ContentAlignment.BottomCenter;
            btnSiguiente.UseVisualStyleBackColor = false;
            btnSiguiente.Click += btnSiguiente_Click_1;
            // 
            // frmTransporti
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(922, 613);
            Controls.Add(btnSiguiente);
            Controls.Add(btnSSalir);
            Controls.Add(pictureBox3);
            Controls.Add(label3);
            Controls.Add(btnNoticias);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmTransporti";
            Text = "v";
            Load += frmTransporti_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtNombre;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btnNoticias;
        private Label label3;
        private PictureBox pictureBox3;
        private Botones btnSSalir;
        private Botones btnSiguiente;
    }
}
