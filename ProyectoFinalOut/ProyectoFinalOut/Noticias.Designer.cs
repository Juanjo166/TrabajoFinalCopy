namespace ProyectoFinalOut
{
    partial class frmNoticias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNoticias));
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            textBox1 = new TextBox();
            pictureBox4 = new PictureBox();
            pictureBox1 = new PictureBox();
            textBox2 = new TextBox();
            btnCasa = new Botones();
            btnSSalir = new Botones();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(306, 5);
            label1.Name = "label1";
            label1.Size = new Size(226, 38);
            label1.TabIndex = 36;
            label1.Text = "Noticias y anuncios importantes \r\nsobre el servicio de autobuses";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(231, 1);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(62, 46);
            pictureBox2.TabIndex = 37;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(2, -3);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(56, 48);
            pictureBox3.TabIndex = 39;
            pictureBox3.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(53, 13);
            label2.Name = "label2";
            label2.Size = new Size(94, 19);
            label2.TabIndex = 38;
            label2.Text = "Transporti";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(10, 188);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(297, 143);
            textBox1.TabIndex = 40;
            textBox1.Text = resources.GetString("textBox1.Text");
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(313, 247);
            pictureBox4.Margin = new Padding(3, 2, 3, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(202, 185);
            pictureBox4.TabIndex = 41;
            pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(313, 41);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(193, 202);
            pictureBox1.TabIndex = 43;
            pictureBox1.TabStop = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(10, 60);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(297, 120);
            textBox2.TabIndex = 42;
            textBox2.Text = resources.GetString("textBox2.Text");
            // 
            // btnCasa
            // 
            btnCasa.BackColor = Color.SteelBlue;
            btnCasa.Cursor = Cursors.Hand;
            btnCasa.FlatAppearance.BorderSize = 0;
            btnCasa.FlatStyle = FlatStyle.Flat;
            btnCasa.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCasa.ForeColor = Color.Black;
            btnCasa.Image = (Image)resources.GetObject("btnCasa.Image");
            btnCasa.ImageAlign = ContentAlignment.TopCenter;
            btnCasa.Location = new Point(10, 336);
            btnCasa.Name = "btnCasa";
            btnCasa.Size = new Size(83, 77);
            btnCasa.TabIndex = 44;
            btnCasa.Text = "CASA";
            btnCasa.TextAlign = ContentAlignment.BottomCenter;
            btnCasa.UseVisualStyleBackColor = false;
            btnCasa.Click += btnCasa_Click;
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
            btnSSalir.Location = new Point(150, 336);
            btnSSalir.Name = "btnSSalir";
            btnSSalir.Size = new Size(83, 77);
            btnSSalir.TabIndex = 45;
            btnSSalir.Text = "SALIR";
            btnSSalir.TextAlign = ContentAlignment.BottomCenter;
            btnSSalir.UseVisualStyleBackColor = false;
            btnSSalir.Click += btnSSalir_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(512, 45);
            pictureBox5.Margin = new Padding(3, 2, 3, 2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(193, 202);
            pictureBox5.TabIndex = 46;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(512, 247);
            pictureBox6.Margin = new Padding(3, 2, 3, 2);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(193, 202);
            pictureBox6.TabIndex = 47;
            pictureBox6.TabStop = false;
            // 
            // frmNoticias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 460);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(btnSSalir);
            Controls.Add(btnCasa);
            Controls.Add(pictureBox1);
            Controls.Add(textBox2);
            Controls.Add(pictureBox4);
            Controls.Add(textBox1);
            Controls.Add(pictureBox3);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmNoticias";
            Text = "Noticias";
            Load += frmNoticias_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label2;
        private TextBox textBox1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox1;
        private TextBox textBox2;
        private Botones btnCasa;
        private Botones btnSSalir;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
    }
}