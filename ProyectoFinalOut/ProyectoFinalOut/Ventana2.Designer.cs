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
            btnSalir = new Button();
            btnSiguiente = new Button();
            label2 = new Label();
            label1 = new Label();
            lblBienvenida = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            button2 = new Button();
            btnAtras = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-3, -2);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(56, 48);
            pictureBox2.TabIndex = 22;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(451, -2);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(355, 462);
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = SystemColors.GradientActiveCaption;
            btnSalir.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = SystemColors.ActiveCaptionText;
            btnSalir.Image = (Image)resources.GetObject("btnSalir.Image");
            btnSalir.ImageAlign = ContentAlignment.TopCenter;
            btnSalir.Location = new Point(141, 370);
            btnSalir.Margin = new Padding(3, 2, 3, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(100, 73);
            btnSalir.TabIndex = 20;
            btnSalir.Text = "Salir";
            btnSalir.TextAlign = ContentAlignment.BottomCenter;
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnSiguiente
            // 
            btnSiguiente.BackColor = SystemColors.GradientActiveCaption;
            btnSiguiente.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSiguiente.ForeColor = SystemColors.ActiveCaptionText;
            btnSiguiente.Image = (Image)resources.GetObject("btnSiguiente.Image");
            btnSiguiente.ImageAlign = ContentAlignment.TopCenter;
            btnSiguiente.Location = new Point(16, 370);
            btnSiguiente.Margin = new Padding(3, 2, 3, 2);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(94, 73);
            btnSiguiente.TabIndex = 19;
            btnSiguiente.Text = "Siguiente";
            btnSiguiente.TextAlign = ContentAlignment.BottomCenter;
            btnSiguiente.UseVisualStyleBackColor = false;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(111, 98);
            label2.Name = "label2";
            label2.Size = new Size(155, 17);
            label2.TabIndex = 17;
            label2.Text = "Ingresa su ubicación:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(49, 14);
            label1.Name = "label1";
            label1.Size = new Size(94, 19);
            label1.TabIndex = 16;
            label1.Text = "Transporti";
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBienvenida.Location = new Point(90, 40);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(272, 38);
            lblBienvenida.TabIndex = 23;
            lblBienvenida.Text = "¡Bienvenido! \r\nEstamos para ayudarlo en su recorrido.";
            lblBienvenida.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(112, 161);
            label4.Name = "label4";
            label4.Size = new Size(188, 17);
            label4.TabIndex = 24;
            label4.Text = "Ingresa a donde se dirige:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(112, 220);
            label5.Name = "label5";
            label5.Size = new Size(118, 17);
            label5.TabIndex = 26;
            label5.Text = "Ingresa la hora:";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(271, 370);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(158, 73);
            button1.TabIndex = 28;
            button1.Text = "VER TODAS \r\nLAS RUTAS";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(111, 123);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(238, 23);
            comboBox1.TabIndex = 30;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(111, 190);
            comboBox2.Margin = new Padding(3, 2, 3, 2);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(238, 23);
            comboBox2.TabIndex = 31;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(111, 254);
            comboBox3.Margin = new Padding(3, 2, 3, 2);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(130, 23);
            comboBox3.TabIndex = 32;
            // 
            // button2
            // 
            button2.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 178);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleRight;
            button2.Location = new Point(111, 296);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(248, 36);
            button2.TabIndex = 33;
            button2.Text = "Noticias y anuncios importantes \r\nsobre el servicio de autobuses";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnAtras
            // 
            btnAtras.BackColor = SystemColors.GradientActiveCaption;
            btnAtras.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAtras.Image = (Image)resources.GetObject("btnAtras.Image");
            btnAtras.ImageAlign = ContentAlignment.TopCenter;
            btnAtras.Location = new Point(11, 281);
            btnAtras.Margin = new Padding(3, 2, 3, 2);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(94, 72);
            btnAtras.TabIndex = 48;
            btnAtras.Text = "Atras";
            btnAtras.TextAlign = ContentAlignment.BottomCenter;
            btnAtras.UseVisualStyleBackColor = false;
            btnAtras.Click += btnAtras_Click;
            // 
            // Ventana2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 460);
            Controls.Add(btnAtras);
            Controls.Add(button2);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lblBienvenida);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnSalir);
            Controls.Add(btnSiguiente);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Ventana2";
            Text = "Ventana2";
            Load += Ventana2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button btnSalir;
        private Button btnSiguiente;
        private Label label2;
        private Label label1;
        private Label lblBienvenida;
        private Label label4;
        private Label label5;
        private Button button1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private Button button2;
        private Button btnAtras;
    }
}