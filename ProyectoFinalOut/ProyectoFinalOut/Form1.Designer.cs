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
            btnSiguiente = new Button();
            txtNombre = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnSalir = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnSiguiente
            // 
            btnSiguiente.BackColor = SystemColors.GradientActiveCaption;
            btnSiguiente.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSiguiente.ForeColor = SystemColors.ActiveCaptionText;
            btnSiguiente.Image = (Image)resources.GetObject("btnSiguiente.Image");
            btnSiguiente.ImageAlign = ContentAlignment.TopCenter;
            btnSiguiente.Location = new Point(104, 248);
            btnSiguiente.Margin = new Padding(3, 2, 3, 2);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(94, 96);
            btnSiguiente.TabIndex = 10;
            btnSiguiente.Text = "Siguiente";
            btnSiguiente.TextAlign = ContentAlignment.BottomCenter;
            btnSiguiente.UseVisualStyleBackColor = false;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(132, 172);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(154, 23);
            txtNombre.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(132, 142);
            label2.Name = "label2";
            label2.Size = new Size(144, 17);
            label2.TabIndex = 7;
            label2.Text = "Ingresa tu nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(142, 41);
            label1.Name = "label1";
            label1.Size = new Size(115, 19);
            label1.TabIndex = 6;
            label1.Text = "TuTransporti";
            // 
            // btnSalir
            // 
            btnSalir.BackColor = SystemColors.GradientActiveCaption;
            btnSalir.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = SystemColors.ActiveCaptionText;
            btnSalir.Image = (Image)resources.GetObject("btnSalir.Image");
            btnSalir.ImageAlign = ContentAlignment.TopCenter;
            btnSalir.Location = new Point(220, 248);
            btnSalir.Margin = new Padding(3, 2, 3, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(100, 96);
            btnSalir.TabIndex = 12;
            btnSalir.Text = "Salir";
            btnSalir.TextAlign = ContentAlignment.BottomCenter;
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(477, 16);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(303, 425);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(174, 62);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(64, 57);
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // frmTransporti
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(807, 460);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnSalir);
            Controls.Add(btnSiguiente);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmTransporti";
            Text = "TransPorti";
            Load += frmTransporti_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSiguiente;
        private TextBox txtNombre;
        private Label label2;
        private Label label1;
        private Button btnSalir;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
