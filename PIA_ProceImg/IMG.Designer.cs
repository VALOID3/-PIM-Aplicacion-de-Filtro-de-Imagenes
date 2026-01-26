namespace PIA_ProceImg
{
    partial class IMG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IMG));
            pictureBoxIMG = new PictureBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            BTN_SAVE = new Button();
            label3 = new Label();
            BTN_NEGATIVO = new Button();
            BTN_MORADIZAR = new Button();
            BTN_AVECROMATIC = new Button();
            BTN_GAMMA = new Button();
            BTN_COLORIZAR = new Button();
            BTN_RUIDO = new Button();
            BTN_MOSAICO = new Button();
            BTN_DUPLICADOMOSAICO = new Button();
            BTN_FiltroKirsch = new Button();
            BTN_FLIP = new Button();
            trackBrillo = new TrackBar();
            label4 = new Label();
            label5 = new Label();
            trackSaturacion = new TrackBar();
            trackContraste = new TrackBar();
            label6 = new Label();
            BTN_SALIR = new Button();
            pictureBoxFiltro = new PictureBox();
            label7 = new Label();
            label8 = new Label();
            btnResetBrillo = new Button();
            btnResetSaturacio = new Button();
            btnResetContraste = new Button();
            pictureBoxHistograma = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIMG).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBrillo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackSaturacion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackContraste).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFiltro).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHistograma).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxIMG
            // 
            pictureBoxIMG.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxIMG.Location = new Point(226, 12);
            pictureBoxIMG.Name = "pictureBoxIMG";
            pictureBoxIMG.Size = new Size(440, 395);
            pictureBoxIMG.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxIMG.TabIndex = 0;
            pictureBoxIMG.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Indigo;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(135, 108);
            button1.Name = "button1";
            button1.Size = new Size(54, 30);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Indigo;
            label1.Font = new Font("Segoe UI", 14F);
            label1.ForeColor = Color.MediumPurple;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(203, 25);
            label1.TabIndex = 2;
            label1.Text = "FILTROS DE IMAGENES";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Indigo;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.GhostWhite;
            label2.Location = new Point(16, 108);
            label2.Name = "label2";
            label2.Size = new Size(113, 21);
            label2.TabIndex = 3;
            label2.Text = "Cargar Imagen";
            // 
            // BTN_SAVE
            // 
            BTN_SAVE.BackColor = Color.Indigo;
            BTN_SAVE.BackgroundImage = (Image)resources.GetObject("BTN_SAVE.BackgroundImage");
            BTN_SAVE.BackgroundImageLayout = ImageLayout.Zoom;
            BTN_SAVE.FlatAppearance.BorderSize = 0;
            BTN_SAVE.FlatStyle = FlatStyle.Flat;
            BTN_SAVE.Location = new Point(145, 181);
            BTN_SAVE.Name = "BTN_SAVE";
            BTN_SAVE.Size = new Size(54, 30);
            BTN_SAVE.TabIndex = 4;
            BTN_SAVE.UseVisualStyleBackColor = false;
            BTN_SAVE.Click += BTN_SAVE_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Indigo;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = Color.GhostWhite;
            label3.Location = new Point(16, 184);
            label3.Name = "label3";
            label3.Size = new Size(123, 21);
            label3.TabIndex = 5;
            label3.Text = "Guardar Imagen";
            // 
            // BTN_NEGATIVO
            // 
            BTN_NEGATIVO.FlatAppearance.BorderSize = 0;
            BTN_NEGATIVO.FlatStyle = FlatStyle.Flat;
            BTN_NEGATIVO.Font = new Font("Segoe UI", 12F);
            BTN_NEGATIVO.ForeColor = Color.Violet;
            BTN_NEGATIVO.Location = new Point(16, 268);
            BTN_NEGATIVO.Name = "BTN_NEGATIVO";
            BTN_NEGATIVO.Size = new Size(199, 36);
            BTN_NEGATIVO.TabIndex = 6;
            BTN_NEGATIVO.Text = "Negativo";
            BTN_NEGATIVO.UseVisualStyleBackColor = true;
            BTN_NEGATIVO.Click += BTN_NEGATIVO_Click;
            // 
            // BTN_MORADIZAR
            // 
            BTN_MORADIZAR.FlatAppearance.BorderSize = 0;
            BTN_MORADIZAR.FlatStyle = FlatStyle.Flat;
            BTN_MORADIZAR.Font = new Font("Segoe UI", 12F);
            BTN_MORADIZAR.ForeColor = Color.Violet;
            BTN_MORADIZAR.Location = new Point(16, 320);
            BTN_MORADIZAR.Name = "BTN_MORADIZAR";
            BTN_MORADIZAR.Size = new Size(199, 36);
            BTN_MORADIZAR.TabIndex = 7;
            BTN_MORADIZAR.Text = "Moradizar";
            BTN_MORADIZAR.UseVisualStyleBackColor = true;
            BTN_MORADIZAR.Click += BTN_MORADIZAR_Click;
            // 
            // BTN_AVECROMATIC
            // 
            BTN_AVECROMATIC.FlatAppearance.BorderSize = 0;
            BTN_AVECROMATIC.FlatStyle = FlatStyle.Flat;
            BTN_AVECROMATIC.Font = new Font("Segoe UI", 12F);
            BTN_AVECROMATIC.ForeColor = Color.Violet;
            BTN_AVECROMATIC.Location = new Point(16, 371);
            BTN_AVECROMATIC.Name = "BTN_AVECROMATIC";
            BTN_AVECROMATIC.Size = new Size(199, 36);
            BTN_AVECROMATIC.TabIndex = 8;
            BTN_AVECROMATIC.Text = "Aberracion Cromatica";
            BTN_AVECROMATIC.UseVisualStyleBackColor = true;
            BTN_AVECROMATIC.Click += BTN_AVECROMATIC_Click;
            // 
            // BTN_GAMMA
            // 
            BTN_GAMMA.FlatAppearance.BorderSize = 0;
            BTN_GAMMA.FlatStyle = FlatStyle.Flat;
            BTN_GAMMA.Font = new Font("Segoe UI", 12F);
            BTN_GAMMA.ForeColor = Color.Violet;
            BTN_GAMMA.Location = new Point(16, 422);
            BTN_GAMMA.Name = "BTN_GAMMA";
            BTN_GAMMA.Size = new Size(199, 36);
            BTN_GAMMA.TabIndex = 9;
            BTN_GAMMA.Text = "Gamma";
            BTN_GAMMA.UseVisualStyleBackColor = true;
            BTN_GAMMA.Click += BTN_GAMMA_Click;
            // 
            // BTN_COLORIZAR
            // 
            BTN_COLORIZAR.FlatAppearance.BorderSize = 0;
            BTN_COLORIZAR.FlatStyle = FlatStyle.Flat;
            BTN_COLORIZAR.Font = new Font("Segoe UI", 12F);
            BTN_COLORIZAR.ForeColor = Color.Violet;
            BTN_COLORIZAR.Location = new Point(16, 475);
            BTN_COLORIZAR.Name = "BTN_COLORIZAR";
            BTN_COLORIZAR.Size = new Size(199, 36);
            BTN_COLORIZAR.TabIndex = 10;
            BTN_COLORIZAR.Text = "Colorizar";
            BTN_COLORIZAR.UseVisualStyleBackColor = true;
            BTN_COLORIZAR.Click += BTN_COLORIZAR_Click;
            // 
            // BTN_RUIDO
            // 
            BTN_RUIDO.FlatAppearance.BorderSize = 0;
            BTN_RUIDO.FlatStyle = FlatStyle.Flat;
            BTN_RUIDO.Font = new Font("Segoe UI", 12F);
            BTN_RUIDO.ForeColor = Color.Violet;
            BTN_RUIDO.Location = new Point(16, 528);
            BTN_RUIDO.Name = "BTN_RUIDO";
            BTN_RUIDO.Size = new Size(199, 36);
            BTN_RUIDO.TabIndex = 11;
            BTN_RUIDO.Text = "Ruido";
            BTN_RUIDO.UseVisualStyleBackColor = true;
            BTN_RUIDO.Click += BTN_RUIDO_Click;
            // 
            // BTN_MOSAICO
            // 
            BTN_MOSAICO.FlatAppearance.BorderSize = 0;
            BTN_MOSAICO.FlatStyle = FlatStyle.Flat;
            BTN_MOSAICO.Font = new Font("Segoe UI", 12F);
            BTN_MOSAICO.ForeColor = Color.Violet;
            BTN_MOSAICO.Location = new Point(16, 579);
            BTN_MOSAICO.Name = "BTN_MOSAICO";
            BTN_MOSAICO.Size = new Size(199, 36);
            BTN_MOSAICO.TabIndex = 12;
            BTN_MOSAICO.Text = "Mozaico Pixelear";
            BTN_MOSAICO.UseVisualStyleBackColor = true;
            BTN_MOSAICO.Click += BTN_MOSAICO_Click;
            // 
            // BTN_DUPLICADOMOSAICO
            // 
            BTN_DUPLICADOMOSAICO.FlatAppearance.BorderSize = 0;
            BTN_DUPLICADOMOSAICO.FlatStyle = FlatStyle.Flat;
            BTN_DUPLICADOMOSAICO.Font = new Font("Segoe UI", 12F);
            BTN_DUPLICADOMOSAICO.ForeColor = Color.Violet;
            BTN_DUPLICADOMOSAICO.Location = new Point(16, 630);
            BTN_DUPLICADOMOSAICO.Name = "BTN_DUPLICADOMOSAICO";
            BTN_DUPLICADOMOSAICO.Size = new Size(199, 36);
            BTN_DUPLICADOMOSAICO.TabIndex = 13;
            BTN_DUPLICADOMOSAICO.Text = "Duplicado mozaico";
            BTN_DUPLICADOMOSAICO.UseVisualStyleBackColor = true;
            BTN_DUPLICADOMOSAICO.Click += BTN_DUPLICADOMOSAICO_Click;
            // 
            // BTN_FiltroKirsch
            // 
            BTN_FiltroKirsch.FlatAppearance.BorderSize = 0;
            BTN_FiltroKirsch.FlatStyle = FlatStyle.Flat;
            BTN_FiltroKirsch.Font = new Font("Segoe UI", 12F);
            BTN_FiltroKirsch.ForeColor = Color.Violet;
            BTN_FiltroKirsch.Location = new Point(16, 682);
            BTN_FiltroKirsch.Name = "BTN_FiltroKirsch";
            BTN_FiltroKirsch.Size = new Size(199, 36);
            BTN_FiltroKirsch.TabIndex = 14;
            BTN_FiltroKirsch.Text = "Filtro de Color";
            BTN_FiltroKirsch.UseVisualStyleBackColor = true;
            BTN_FiltroKirsch.Click += BTN_FiltroKirsch_Click;
            // 
            // BTN_FLIP
            // 
            BTN_FLIP.FlatAppearance.BorderSize = 0;
            BTN_FLIP.FlatStyle = FlatStyle.Flat;
            BTN_FLIP.Font = new Font("Segoe UI", 12F);
            BTN_FLIP.ForeColor = Color.Violet;
            BTN_FLIP.Location = new Point(16, 734);
            BTN_FLIP.Name = "BTN_FLIP";
            BTN_FLIP.Size = new Size(199, 36);
            BTN_FLIP.TabIndex = 15;
            BTN_FLIP.Text = "Flip";
            BTN_FLIP.UseVisualStyleBackColor = true;
            BTN_FLIP.Click += BTN_FLIP_Click;
            // 
            // trackBrillo
            // 
            trackBrillo.LargeChange = 10;
            trackBrillo.Location = new Point(294, 613);
            trackBrillo.Maximum = 100;
            trackBrillo.Minimum = -100;
            trackBrillo.Name = "trackBrillo";
            trackBrillo.Size = new Size(149, 45);
            trackBrillo.TabIndex = 16;
            trackBrillo.TickFrequency = 10;
            trackBrillo.Scroll += trackBrillo_Scroll;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Indigo;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = Color.GhostWhite;
            label4.Location = new Point(294, 587);
            label4.Name = "label4";
            label4.Size = new Size(46, 21);
            label4.TabIndex = 17;
            label4.Text = "Brillo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Indigo;
            label5.Font = new Font("Segoe UI", 12F);
            label5.ForeColor = Color.GhostWhite;
            label5.Location = new Point(554, 587);
            label5.Name = "label5";
            label5.Size = new Size(84, 21);
            label5.TabIndex = 18;
            label5.Text = "Saturacion";
            // 
            // trackSaturacion
            // 
            trackSaturacion.LargeChange = 10;
            trackSaturacion.Location = new Point(554, 614);
            trackSaturacion.Maximum = 100;
            trackSaturacion.Minimum = -100;
            trackSaturacion.Name = "trackSaturacion";
            trackSaturacion.Size = new Size(149, 45);
            trackSaturacion.TabIndex = 19;
            trackSaturacion.TickFrequency = 10;
            trackSaturacion.Scroll += trackSaturacion_Scroll;
            // 
            // trackContraste
            // 
            trackContraste.LargeChange = 10;
            trackContraste.Location = new Point(821, 614);
            trackContraste.Maximum = 100;
            trackContraste.Minimum = -100;
            trackContraste.Name = "trackContraste";
            trackContraste.Size = new Size(149, 45);
            trackContraste.TabIndex = 21;
            trackContraste.TickFrequency = 10;
            trackContraste.Scroll += trackContraste_Scroll;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Indigo;
            label6.Font = new Font("Segoe UI", 12F);
            label6.ForeColor = Color.GhostWhite;
            label6.Location = new Point(821, 587);
            label6.Name = "label6";
            label6.Size = new Size(77, 21);
            label6.TabIndex = 20;
            label6.Text = "Contraste";
            // 
            // BTN_SALIR
            // 
            BTN_SALIR.BackColor = Color.Indigo;
            BTN_SALIR.BackgroundImage = (Image)resources.GetObject("BTN_SALIR.BackgroundImage");
            BTN_SALIR.BackgroundImageLayout = ImageLayout.Zoom;
            BTN_SALIR.FlatAppearance.BorderSize = 0;
            BTN_SALIR.FlatStyle = FlatStyle.Flat;
            BTN_SALIR.Font = new Font("Segoe UI", 15F);
            BTN_SALIR.Location = new Point(1419, 746);
            BTN_SALIR.Name = "BTN_SALIR";
            BTN_SALIR.Size = new Size(49, 41);
            BTN_SALIR.TabIndex = 22;
            BTN_SALIR.UseVisualStyleBackColor = false;
            BTN_SALIR.Click += BTN_SALIR_Click;
            // 
            // pictureBoxFiltro
            // 
            pictureBoxFiltro.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxFiltro.Location = new Point(702, 12);
            pictureBoxFiltro.Name = "pictureBoxFiltro";
            pictureBoxFiltro.Size = new Size(674, 469);
            pictureBoxFiltro.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxFiltro.TabIndex = 23;
            pictureBoxFiltro.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Indigo;
            label7.Font = new Font("Segoe UI", 12F);
            label7.ForeColor = Color.GhostWhite;
            label7.Location = new Point(387, 430);
            label7.Name = "label7";
            label7.Size = new Size(122, 21);
            label7.TabIndex = 24;
            label7.Text = "Imagen Original";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Indigo;
            label8.Font = new Font("Segoe UI", 12F);
            label8.ForeColor = Color.GhostWhite;
            label8.Location = new Point(973, 501);
            label8.Name = "label8";
            label8.Size = new Size(128, 21);
            label8.TabIndex = 25;
            label8.Text = "Imagen con filtro";
            // 
            // btnResetBrillo
            // 
            btnResetBrillo.FlatAppearance.BorderSize = 0;
            btnResetBrillo.FlatStyle = FlatStyle.Flat;
            btnResetBrillo.Font = new Font("Segoe UI", 12F);
            btnResetBrillo.ForeColor = Color.Violet;
            btnResetBrillo.Location = new Point(338, 650);
            btnResetBrillo.Name = "btnResetBrillo";
            btnResetBrillo.Size = new Size(56, 31);
            btnResetBrillo.TabIndex = 27;
            btnResetBrillo.Text = "reset";
            btnResetBrillo.UseVisualStyleBackColor = true;
            btnResetBrillo.Click += btnResetBrillo_Click;
            // 
            // btnResetSaturacio
            // 
            btnResetSaturacio.FlatAppearance.BorderSize = 0;
            btnResetSaturacio.FlatStyle = FlatStyle.Flat;
            btnResetSaturacio.Font = new Font("Segoe UI", 12F);
            btnResetSaturacio.ForeColor = Color.Violet;
            btnResetSaturacio.Location = new Point(601, 650);
            btnResetSaturacio.Name = "btnResetSaturacio";
            btnResetSaturacio.Size = new Size(56, 31);
            btnResetSaturacio.TabIndex = 28;
            btnResetSaturacio.Text = "reset";
            btnResetSaturacio.UseVisualStyleBackColor = true;
            btnResetSaturacio.Click += btnResetSaturacio_Click;
            // 
            // btnResetContraste
            // 
            btnResetContraste.FlatAppearance.BorderSize = 0;
            btnResetContraste.FlatStyle = FlatStyle.Flat;
            btnResetContraste.Font = new Font("Segoe UI", 12F);
            btnResetContraste.ForeColor = Color.Violet;
            btnResetContraste.Location = new Point(872, 650);
            btnResetContraste.Name = "btnResetContraste";
            btnResetContraste.Size = new Size(56, 31);
            btnResetContraste.TabIndex = 29;
            btnResetContraste.Text = "reset";
            btnResetContraste.UseVisualStyleBackColor = true;
            btnResetContraste.Click += btnResetContraste_Click;
            // 
            // pictureBoxHistograma
            // 
            pictureBoxHistograma.BackColor = Color.White;
            pictureBoxHistograma.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxHistograma.Location = new Point(1035, 587);
            pictureBoxHistograma.Name = "pictureBoxHistograma";
            pictureBoxHistograma.Size = new Size(256, 140);
            pictureBoxHistograma.TabIndex = 30;
            pictureBoxHistograma.TabStop = false;
            pictureBoxHistograma.Click += pictureBoxHistograma_Click;
            // 
            // IMG
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(1502, 818);
            Controls.Add(pictureBoxHistograma);
            Controls.Add(btnResetContraste);
            Controls.Add(btnResetSaturacio);
            Controls.Add(btnResetBrillo);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(pictureBoxFiltro);
            Controls.Add(BTN_SALIR);
            Controls.Add(trackContraste);
            Controls.Add(label6);
            Controls.Add(trackSaturacion);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(trackBrillo);
            Controls.Add(BTN_FLIP);
            Controls.Add(BTN_FiltroKirsch);
            Controls.Add(BTN_DUPLICADOMOSAICO);
            Controls.Add(BTN_MOSAICO);
            Controls.Add(BTN_RUIDO);
            Controls.Add(BTN_COLORIZAR);
            Controls.Add(BTN_GAMMA);
            Controls.Add(BTN_AVECROMATIC);
            Controls.Add(BTN_MORADIZAR);
            Controls.Add(BTN_NEGATIVO);
            Controls.Add(label3);
            Controls.Add(BTN_SAVE);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(pictureBoxIMG);
            Font = new Font("Segoe UI", 9F);
            Name = "IMG";
            Text = "IMG";
            Load += IMG_Load;
            Paint += IMG_Paint;
            ((System.ComponentModel.ISupportInitialize)pictureBoxIMG).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBrillo).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackSaturacion).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackContraste).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFiltro).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHistograma).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxIMG;
        private Button button1;
        private Label label1;
        private Label label2;
        private Button BTN_SAVE;
        private Label label3;
        private Button BTN_NEGATIVO;
        private Button BTN_MORADIZAR;
        private Button BTN_AVECROMATIC;
        private Button BTN_GAMMA;
        private Button BTN_COLORIZAR;
        private Button BTN_RUIDO;
        private Button BTN_MOSAICO;
        private Button BTN_DUPLICADOMOSAICO;
        private Button BTN_FiltroKirsch;
        private Button BTN_FLIP;
        private TrackBar trackBrillo;
        private Label label4;
        private Label label5;
        private TrackBar trackSaturacion;
        private TrackBar trackContraste;
        private Label label6;
        private Button BTN_SALIR;
        private PictureBox pictureBoxFiltro;
        private Label label7;
        private Label label8;
        private Button btnResetBrillo;
        private Button btnResetSaturacio;
        private Button btnResetContraste;
        private PictureBox pictureBoxHistograma;
    }
}