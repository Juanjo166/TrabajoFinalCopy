namespace ProyectoFinalOut
{
    partial class frmTutransporti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTutransporti));
            label2 = new Label();
            btnRuta1 = new Button();
            btnSiguiente = new Button();
            btnSalir = new Button();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(120, 65);
            label2.Name = "label2";
            label2.Size = new Size(313, 42);
            label2.TabIndex = 1;
            label2.Text = " ¡Hola, elige el numero del autobus \r\ndel que quieres informarte!";
            label2.Click += label2_Click;
            // 
            // btnRuta1
            // 
            btnRuta1.BackColor = SystemColors.GradientActiveCaption;
            btnRuta1.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRuta1.Image = (Image)resources.GetObject("btnRuta1.Image");
            btnRuta1.ImageAlign = ContentAlignment.TopCenter;
            btnRuta1.Location = new Point(111, 138);
            btnRuta1.Name = "btnRuta1";
            btnRuta1.Size = new Size(108, 93);
            btnRuta1.TabIndex = 6;
            btnRuta1.Text = "Ruta 1";
            btnRuta1.TextAlign = ContentAlignment.BottomCenter;
            btnRuta1.UseVisualStyleBackColor = false;
            btnRuta1.Click += btnRuta1_Click;
            // 
            // btnSiguiente
            // 
            btnSiguiente.BackColor = SystemColors.GradientActiveCaption;
            btnSiguiente.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSiguiente.Image = (Image)resources.GetObject("btnSiguiente.Image");
            btnSiguiente.ImageAlign = ContentAlignment.TopCenter;
            btnSiguiente.Location = new Point(111, 443);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(108, 96);
            btnSiguiente.TabIndex = 4;
            btnSiguiente.Text = "Siguiente";
            btnSiguiente.TextAlign = ContentAlignment.BottomCenter;
            btnSiguiente.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = SystemColors.GradientActiveCaption;
            btnSalir.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.Image = (Image)resources.GetObject("btnSalir.Image");
            btnSalir.ImageAlign = ContentAlignment.TopCenter;
            btnSalir.Location = new Point(302, 443);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(108, 96);
            btnSalir.TabIndex = 10;
            btnSalir.Text = "Salir";
            btnSalir.TextAlign = ContentAlignment.BottomCenter;
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(596, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(326, 622);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.Location = new Point(302, 138);
            button1.Name = "button1";
            button1.Size = new Size(108, 93);
            button1.TabIndex = 12;
            button1.Text = "Ruta 6";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.GradientActiveCaption;
            button2.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.TopCenter;
            button2.Location = new Point(111, 278);
            button2.Name = "button2";
            button2.Size = new Size(108, 93);
            button2.TabIndex = 13;
            button2.Text = "Ruta 10";
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.GradientActiveCaption;
            button3.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.TopCenter;
            button3.Location = new Point(302, 278);
            button3.Name = "button3";
            button3.Size = new Size(108, 93);
            button3.TabIndex = 14;
            button3.Text = "Ruta 7";
            button3.TextAlign = ContentAlignment.BottomCenter;
            button3.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(284, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(62, 62);
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(139, 19);
            label3.Name = "label3";
            label3.Size = new Size(139, 24);
            label3.TabIndex = 15;
            label3.Text = "TuTransporti";
            // 
            // frmTutransporti
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 613);
            Controls.Add(pictureBox2);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(btnSalir);
            Controls.Add(btnRuta1);
            Controls.Add(btnSiguiente);
            Controls.Add(label2);
            Name = "frmTutransporti";
            Text = "TuTransporti";
            Load += frmTutransporti_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Button btnRuta1;
        private Button btnSiguiente;
        private Button btnSalir;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private PictureBox pictureBox2;
        private Label label3;
    }
}