namespace PIA_ProceImg
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            modoImagenToolStripMenuItem = new ToolStripMenuItem();
            modoVideoToolStripMenuItem = new ToolStripMenuItem();
            modoDetectorDeRostroToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            BTN_SALIR = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.MediumPurple;
            menuStrip1.Items.AddRange(new ToolStripItem[] { modoImagenToolStripMenuItem, modoVideoToolStripMenuItem, modoDetectorDeRostroToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(950, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // modoImagenToolStripMenuItem
            // 
            modoImagenToolStripMenuItem.ForeColor = SystemColors.Window;
            modoImagenToolStripMenuItem.Name = "modoImagenToolStripMenuItem";
            modoImagenToolStripMenuItem.Size = new Size(94, 20);
            modoImagenToolStripMenuItem.Text = "Modo Imagen";
            modoImagenToolStripMenuItem.Click += modoImagenToolStripMenuItem_Click;
            // 
            // modoVideoToolStripMenuItem
            // 
            modoVideoToolStripMenuItem.ForeColor = SystemColors.Window;
            modoVideoToolStripMenuItem.Name = "modoVideoToolStripMenuItem";
            modoVideoToolStripMenuItem.Size = new Size(84, 20);
            modoVideoToolStripMenuItem.Text = "Modo Video";
            modoVideoToolStripMenuItem.Click += modoVideoToolStripMenuItem_Click;
            // 
            // modoDetectorDeRostroToolStripMenuItem
            // 
            modoDetectorDeRostroToolStripMenuItem.ForeColor = SystemColors.Window;
            modoDetectorDeRostroToolStripMenuItem.Name = "modoDetectorDeRostroToolStripMenuItem";
            modoDetectorDeRostroToolStripMenuItem.Size = new Size(152, 20);
            modoDetectorDeRostroToolStripMenuItem.Text = "Modo Detector de Rostro";
            modoDetectorDeRostroToolStripMenuItem.Click += modoDetectorDeRostroToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(950, 794);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // BTN_SALIR
            // 
            BTN_SALIR.BackColor = Color.Indigo;
            BTN_SALIR.BackgroundImage = (Image)resources.GetObject("BTN_SALIR.BackgroundImage");
            BTN_SALIR.BackgroundImageLayout = ImageLayout.Zoom;
            BTN_SALIR.FlatAppearance.BorderSize = 0;
            BTN_SALIR.FlatStyle = FlatStyle.Flat;
            BTN_SALIR.Font = new Font("Segoe UI", 15F);
            BTN_SALIR.Location = new Point(857, 745);
            BTN_SALIR.Name = "BTN_SALIR";
            BTN_SALIR.Size = new Size(49, 41);
            BTN_SALIR.TabIndex = 2;
            BTN_SALIR.UseVisualStyleBackColor = false;
            BTN_SALIR.Click += BTN_SALIR_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(950, 818);
            Controls.Add(BTN_SALIR);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "INICIO";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem modoImagenToolStripMenuItem;
        private ToolStripMenuItem modoVideoToolStripMenuItem;
        private ToolStripMenuItem modoDetectorDeRostroToolStripMenuItem;
        private PictureBox pictureBox1;
        private Button BTN_SALIR;
    }
}
