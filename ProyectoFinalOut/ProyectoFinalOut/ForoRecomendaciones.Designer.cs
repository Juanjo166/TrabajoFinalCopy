namespace ProyectoFinalOut
{
    partial class frmForoRecomendaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmForoRecomendaciones));
            pictureBox1 = new PictureBox();
            txtMensaje = new TextBox();
            pictureBox4 = new PictureBox();
            textBox1 = new TextBox();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            btnSalir = new Botones();
            btnCasa = new Botones();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 215);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(383, 246);
            pictureBox1.TabIndex = 53;
            pictureBox1.TabStop = false;
            // 
            // txtMensaje
            // 
            txtMensaje.Location = new Point(12, 70);
            txtMensaje.Margin = new Padding(3, 2, 3, 2);
            txtMensaje.Multiline = true;
            txtMensaje.Name = "txtMensaje";
            txtMensaje.ReadOnly = true;
            txtMensaje.Size = new Size(385, 141);
            txtMensaje.TabIndex = 52;
            txtMensaje.Text = "Mensaje";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(411, 56);
            pictureBox4.Margin = new Padding(3, 2, 3, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(385, 185);
            pictureBox4.TabIndex = 51;
            pictureBox4.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(401, 264);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(386, 102);
            textBox1.TabIndex = 50;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(11, 8);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(56, 48);
            pictureBox3.TabIndex = 49;
            pictureBox3.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(63, 23);
            label2.Name = "label2";
            label2.Size = new Size(94, 19);
            label2.TabIndex = 48;
            label2.Text = "Transporti";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(241, 11);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(62, 55);
            pictureBox2.TabIndex = 47;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(308, 23);
            label1.Name = "label1";
            label1.Size = new Size(278, 19);
            label1.TabIndex = 46;
            label1.Text = "FORO DE RECOMENDACIONES Y QUEJAS";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.SteelBlue;
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = Color.Black;
            btnSalir.Image = (Image)resources.GetObject("btnSalir.Image");
            btnSalir.ImageAlign = ContentAlignment.TopCenter;
            btnSalir.Location = new Point(638, 371);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(93, 79);
            btnSalir.TabIndex = 54;
            btnSalir.Text = "SALIR";
            btnSalir.TextAlign = ContentAlignment.BottomCenter;
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click_1;
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
            btnCasa.Location = new Point(426, 371);
            btnCasa.Name = "btnCasa";
            btnCasa.Size = new Size(93, 79);
            btnCasa.TabIndex = 55;
            btnCasa.Text = "CASA";
            btnCasa.TextAlign = ContentAlignment.BottomCenter;
            btnCasa.UseVisualStyleBackColor = false;
            btnCasa.Click += btnCasa_Click;
            // 
            // frmForoRecomendaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 460);
            Controls.Add(btnCasa);
            Controls.Add(btnSalir);
            Controls.Add(pictureBox1);
            Controls.Add(txtMensaje);
            Controls.Add(pictureBox4);
            Controls.Add(textBox1);
            Controls.Add(pictureBox3);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmForoRecomendaciones";
            Text = "ForoRecomendaciones";
            Load += ForoRecomendaciones_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private TextBox txtMensaje;
        private PictureBox pictureBox4;
        private TextBox textBox1;
        private PictureBox pictureBox3;
        private Label label2;
        private PictureBox pictureBox2;
        private Label label1;
        private Botones btnSalir;
        private Botones btnCasa;
    }
}