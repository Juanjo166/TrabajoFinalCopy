namespace ProyectoFinalOut
{
    partial class MapaRuta9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MapaRuta9));
            MapaRuta6 = new Botones();
            btnAtras = new Botones();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // MapaRuta6
            // 
            MapaRuta6.BackColor = Color.SteelBlue;
            MapaRuta6.Cursor = Cursors.Hand;
            MapaRuta6.FlatAppearance.BorderSize = 0;
            MapaRuta6.FlatStyle = FlatStyle.Flat;
            MapaRuta6.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MapaRuta6.ForeColor = Color.Black;
            MapaRuta6.Image = (Image)resources.GetObject("MapaRuta6.Image");
            MapaRuta6.Location = new Point(795, 8);
            MapaRuta6.Margin = new Padding(3, 4, 3, 4);
            MapaRuta6.Name = "MapaRuta6";
            MapaRuta6.Size = new Size(79, 80);
            MapaRuta6.TabIndex = 93;
            MapaRuta6.TextAlign = ContentAlignment.BottomCenter;
            MapaRuta6.UseVisualStyleBackColor = false;
            MapaRuta6.Click += MapaRuta6_Click;
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
            btnAtras.Location = new Point(795, 96);
            btnAtras.Margin = new Padding(3, 4, 3, 4);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(79, 74);
            btnAtras.TabIndex = 92;
            btnAtras.TextAlign = ContentAlignment.BottomCenter;
            btnAtras.UseVisualStyleBackColor = false;
            btnAtras.Click += btnAtras_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(42, -10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(762, 1079);
            pictureBox1.TabIndex = 91;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // MapaRuta9
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 953);
            Controls.Add(MapaRuta6);
            Controls.Add(btnAtras);
            Controls.Add(pictureBox1);
            Name = "MapaRuta9";
            Text = "MapaRuta9";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Botones MapaRuta6;
        private Botones btnAtras;
        private PictureBox pictureBox1;
    }
}