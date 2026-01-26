namespace PIA_ProceImg
{
    partial class VIDEO
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VIDEO));
            pictureBoxVideo = new PictureBox();
            BTN_SALIR = new Button();
            trackBarContraste = new TrackBar();
            label6 = new Label();
            trackBar2 = new TrackBar();
            label5 = new Label();
            label4 = new Label();
            trackBarBrillo = new TrackBar();
            btnFlip = new Button();
            btnKirsch = new Button();
            btnMosaicoDuplicado = new Button();
            btnMosaico = new Button();
            btnRuido = new Button();
            btnColorizar = new Button();
            btnGamma = new Button();
            btnAberracion = new Button();
            btnMoradizar = new Button();
            btnNegativo = new Button();
            label2 = new Label();
            label1 = new Label();
            btnCargarVideo = new Button();
            timerVideo = new System.Windows.Forms.Timer(components);
            btnReproducir = new Button();
            btnPausar = new Button();
            btnReiniciar = new Button();
            btnResetBrillo = new Button();
            btnResetSaturacion = new Button();
            btnResetContraste = new Button();
            btnBrillo = new Button();
            btnSaturacion = new Button();
            btnContraste = new Button();
            pictureBoxHistograma = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxVideo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarContraste).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarBrillo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHistograma).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxVideo
            // 
            pictureBoxVideo.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxVideo.Location = new Point(226, 12);
            pictureBoxVideo.Name = "pictureBoxVideo";
            pictureBoxVideo.Size = new Size(731, 476);
            pictureBoxVideo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxVideo.TabIndex = 1;
            pictureBoxVideo.TabStop = false;
            pictureBoxVideo.Click += pictureBoxVideo_Click;
            // 
            // BTN_SALIR
            // 
            BTN_SALIR.BackColor = Color.Indigo;
            BTN_SALIR.BackgroundImage = (Image)resources.GetObject("BTN_SALIR.BackgroundImage");
            BTN_SALIR.BackgroundImageLayout = ImageLayout.Zoom;
            BTN_SALIR.FlatAppearance.BorderSize = 0;
            BTN_SALIR.FlatStyle = FlatStyle.Flat;
            BTN_SALIR.Font = new Font("Segoe UI", 15F);
            BTN_SALIR.Location = new Point(889, 765);
            BTN_SALIR.Name = "BTN_SALIR";
            BTN_SALIR.Size = new Size(49, 41);
            BTN_SALIR.TabIndex = 44;
            BTN_SALIR.UseVisualStyleBackColor = false;
            BTN_SALIR.Click += BTN_SALIR_Click;
            // 
            // trackBarContraste
            // 
            trackBarContraste.Location = new Point(274, 752);
            trackBarContraste.Maximum = 100;
            trackBarContraste.Minimum = -100;
            trackBarContraste.Name = "trackBarContraste";
            trackBarContraste.Size = new Size(149, 45);
            trackBarContraste.TabIndex = 43;
            trackBarContraste.TickFrequency = 10;
            trackBarContraste.Scroll += trackBarContraste_Scroll;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Indigo;
            label6.Font = new Font("Segoe UI", 12F);
            label6.ForeColor = Color.GhostWhite;
            label6.Location = new Point(274, 725);
            label6.Name = "label6";
            label6.Size = new Size(77, 21);
            label6.TabIndex = 42;
            label6.Text = "Contraste";
            // 
            // trackBar2
            // 
            trackBar2.Location = new Point(274, 640);
            trackBar2.Maximum = 100;
            trackBar2.Minimum = -100;
            trackBar2.Name = "trackBar2";
            trackBar2.Size = new Size(149, 45);
            trackBar2.TabIndex = 41;
            trackBar2.TickFrequency = 10;
            trackBar2.Scroll += trackBar2_Scroll;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Indigo;
            label5.Font = new Font("Segoe UI", 12F);
            label5.ForeColor = Color.GhostWhite;
            label5.Location = new Point(274, 613);
            label5.Name = "label5";
            label5.Size = new Size(84, 21);
            label5.TabIndex = 40;
            label5.Text = "Saturacion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Indigo;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = Color.GhostWhite;
            label4.Location = new Point(274, 502);
            label4.Name = "label4";
            label4.Size = new Size(46, 21);
            label4.TabIndex = 39;
            label4.Text = "Brillo";
            // 
            // trackBarBrillo
            // 
            trackBarBrillo.Location = new Point(274, 528);
            trackBarBrillo.Maximum = 100;
            trackBarBrillo.Minimum = -100;
            trackBarBrillo.Name = "trackBarBrillo";
            trackBarBrillo.Size = new Size(149, 45);
            trackBarBrillo.TabIndex = 38;
            trackBarBrillo.TickFrequency = 10;
            trackBarBrillo.Scroll += trackBarBrillo_Scroll;
            // 
            // btnFlip
            // 
            btnFlip.FlatAppearance.BorderSize = 0;
            btnFlip.FlatStyle = FlatStyle.Flat;
            btnFlip.Font = new Font("Segoe UI", 12F);
            btnFlip.ForeColor = Color.Violet;
            btnFlip.Location = new Point(16, 734);
            btnFlip.Name = "btnFlip";
            btnFlip.Size = new Size(199, 36);
            btnFlip.TabIndex = 37;
            btnFlip.Text = "Flip";
            btnFlip.UseVisualStyleBackColor = true;
            btnFlip.Click += btnFlip_Click;
            // 
            // btnKirsch
            // 
            btnKirsch.FlatAppearance.BorderSize = 0;
            btnKirsch.FlatStyle = FlatStyle.Flat;
            btnKirsch.Font = new Font("Segoe UI", 12F);
            btnKirsch.ForeColor = Color.Violet;
            btnKirsch.Location = new Point(16, 682);
            btnKirsch.Name = "btnKirsch";
            btnKirsch.Size = new Size(199, 36);
            btnKirsch.TabIndex = 36;
            btnKirsch.Text = "Filtro Kirsh";
            btnKirsch.UseVisualStyleBackColor = true;
            btnKirsch.Click += btnKirsch_Click;
            // 
            // btnMosaicoDuplicado
            // 
            btnMosaicoDuplicado.FlatAppearance.BorderSize = 0;
            btnMosaicoDuplicado.FlatStyle = FlatStyle.Flat;
            btnMosaicoDuplicado.Font = new Font("Segoe UI", 12F);
            btnMosaicoDuplicado.ForeColor = Color.Violet;
            btnMosaicoDuplicado.Location = new Point(16, 630);
            btnMosaicoDuplicado.Name = "btnMosaicoDuplicado";
            btnMosaicoDuplicado.Size = new Size(199, 36);
            btnMosaicoDuplicado.TabIndex = 35;
            btnMosaicoDuplicado.Text = "Mosaico Duplicado";
            btnMosaicoDuplicado.UseVisualStyleBackColor = true;
            btnMosaicoDuplicado.Click += btnMosaicoDuplicado_Click;
            // 
            // btnMosaico
            // 
            btnMosaico.FlatAppearance.BorderSize = 0;
            btnMosaico.FlatStyle = FlatStyle.Flat;
            btnMosaico.Font = new Font("Segoe UI", 12F);
            btnMosaico.ForeColor = Color.Violet;
            btnMosaico.Location = new Point(16, 579);
            btnMosaico.Name = "btnMosaico";
            btnMosaico.Size = new Size(199, 36);
            btnMosaico.TabIndex = 34;
            btnMosaico.Text = "Mozaico Pixelear";
            btnMosaico.UseVisualStyleBackColor = true;
            btnMosaico.Click += btnMosaico_Click;
            // 
            // btnRuido
            // 
            btnRuido.FlatAppearance.BorderSize = 0;
            btnRuido.FlatStyle = FlatStyle.Flat;
            btnRuido.Font = new Font("Segoe UI", 12F);
            btnRuido.ForeColor = Color.Violet;
            btnRuido.Location = new Point(16, 528);
            btnRuido.Name = "btnRuido";
            btnRuido.Size = new Size(199, 36);
            btnRuido.TabIndex = 33;
            btnRuido.Text = "Ruido";
            btnRuido.UseVisualStyleBackColor = true;
            btnRuido.Click += btnRuido_Click;
            // 
            // btnColorizar
            // 
            btnColorizar.FlatAppearance.BorderSize = 0;
            btnColorizar.FlatStyle = FlatStyle.Flat;
            btnColorizar.Font = new Font("Segoe UI", 12F);
            btnColorizar.ForeColor = Color.Violet;
            btnColorizar.Location = new Point(16, 475);
            btnColorizar.Name = "btnColorizar";
            btnColorizar.Size = new Size(199, 36);
            btnColorizar.TabIndex = 32;
            btnColorizar.Text = "Colorizar";
            btnColorizar.UseVisualStyleBackColor = true;
            btnColorizar.Click += btnColorizar_Click;
            // 
            // btnGamma
            // 
            btnGamma.FlatAppearance.BorderSize = 0;
            btnGamma.FlatStyle = FlatStyle.Flat;
            btnGamma.Font = new Font("Segoe UI", 12F);
            btnGamma.ForeColor = Color.Violet;
            btnGamma.Location = new Point(16, 422);
            btnGamma.Name = "btnGamma";
            btnGamma.Size = new Size(199, 36);
            btnGamma.TabIndex = 31;
            btnGamma.Text = "Gamma";
            btnGamma.UseVisualStyleBackColor = true;
            btnGamma.Click += btnGamma_Click;
            // 
            // btnAberracion
            // 
            btnAberracion.FlatAppearance.BorderSize = 0;
            btnAberracion.FlatStyle = FlatStyle.Flat;
            btnAberracion.Font = new Font("Segoe UI", 12F);
            btnAberracion.ForeColor = Color.Violet;
            btnAberracion.Location = new Point(16, 371);
            btnAberracion.Name = "btnAberracion";
            btnAberracion.Size = new Size(199, 36);
            btnAberracion.TabIndex = 30;
            btnAberracion.Text = "Aberracion Cromatica";
            btnAberracion.UseVisualStyleBackColor = true;
            btnAberracion.Click += btnAberracion_Click;
            // 
            // btnMoradizar
            // 
            btnMoradizar.FlatAppearance.BorderSize = 0;
            btnMoradizar.FlatStyle = FlatStyle.Flat;
            btnMoradizar.Font = new Font("Segoe UI", 12F);
            btnMoradizar.ForeColor = Color.Violet;
            btnMoradizar.Location = new Point(16, 320);
            btnMoradizar.Name = "btnMoradizar";
            btnMoradizar.Size = new Size(199, 36);
            btnMoradizar.TabIndex = 29;
            btnMoradizar.Text = "Moradizar";
            btnMoradizar.UseVisualStyleBackColor = true;
            btnMoradizar.Click += btnMoradizar_Click;
            // 
            // btnNegativo
            // 
            btnNegativo.FlatAppearance.BorderSize = 0;
            btnNegativo.FlatStyle = FlatStyle.Flat;
            btnNegativo.Font = new Font("Segoe UI", 12F);
            btnNegativo.ForeColor = Color.Violet;
            btnNegativo.Location = new Point(16, 268);
            btnNegativo.Name = "btnNegativo";
            btnNegativo.Size = new Size(199, 36);
            btnNegativo.TabIndex = 28;
            btnNegativo.Text = "Negativo";
            btnNegativo.UseVisualStyleBackColor = true;
            btnNegativo.Click += btnNegativo_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Indigo;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.GhostWhite;
            label2.Location = new Point(16, 108);
            label2.Name = "label2";
            label2.Size = new Size(101, 21);
            label2.TabIndex = 25;
            label2.Text = "Cargar Video";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Indigo;
            label1.Font = new Font("Segoe UI", 14F);
            label1.ForeColor = Color.MediumPurple;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(166, 25);
            label1.TabIndex = 24;
            label1.Text = "FILTROS DE VIDEO";
            // 
            // btnCargarVideo
            // 
            btnCargarVideo.BackColor = Color.Indigo;
            btnCargarVideo.BackgroundImage = (Image)resources.GetObject("btnCargarVideo.BackgroundImage");
            btnCargarVideo.BackgroundImageLayout = ImageLayout.Zoom;
            btnCargarVideo.FlatAppearance.BorderSize = 0;
            btnCargarVideo.FlatStyle = FlatStyle.Flat;
            btnCargarVideo.Location = new Point(135, 108);
            btnCargarVideo.Name = "btnCargarVideo";
            btnCargarVideo.Size = new Size(54, 30);
            btnCargarVideo.TabIndex = 23;
            btnCargarVideo.UseVisualStyleBackColor = false;
            btnCargarVideo.Click += btnCargarVideo_Click;
            // 
            // timerVideo
            // 
            timerVideo.Interval = 40;
            timerVideo.Tick += timerVideo_Tick;
            // 
            // btnReproducir
            // 
            btnReproducir.BackColor = Color.Indigo;
            btnReproducir.BackgroundImage = (Image)resources.GetObject("btnReproducir.BackgroundImage");
            btnReproducir.BackgroundImageLayout = ImageLayout.Zoom;
            btnReproducir.FlatAppearance.BorderSize = 0;
            btnReproducir.FlatStyle = FlatStyle.Flat;
            btnReproducir.Font = new Font("Segoe UI", 15F);
            btnReproducir.Location = new Point(566, 492);
            btnReproducir.Name = "btnReproducir";
            btnReproducir.Size = new Size(38, 44);
            btnReproducir.TabIndex = 45;
            btnReproducir.UseVisualStyleBackColor = false;
            btnReproducir.Click += btnReproducir_Click;
            // 
            // btnPausar
            // 
            btnPausar.BackColor = Color.Indigo;
            btnPausar.BackgroundImage = (Image)resources.GetObject("btnPausar.BackgroundImage");
            btnPausar.BackgroundImageLayout = ImageLayout.Zoom;
            btnPausar.FlatAppearance.BorderSize = 0;
            btnPausar.FlatStyle = FlatStyle.Flat;
            btnPausar.Font = new Font("Segoe UI", 15F);
            btnPausar.Location = new Point(648, 492);
            btnPausar.Name = "btnPausar";
            btnPausar.Size = new Size(38, 44);
            btnPausar.TabIndex = 46;
            btnPausar.UseVisualStyleBackColor = false;
            btnPausar.Click += btnPausar_Click;
            // 
            // btnReiniciar
            // 
            btnReiniciar.BackColor = Color.Indigo;
            btnReiniciar.BackgroundImage = (Image)resources.GetObject("btnReiniciar.BackgroundImage");
            btnReiniciar.BackgroundImageLayout = ImageLayout.Zoom;
            btnReiniciar.FlatAppearance.BorderSize = 0;
            btnReiniciar.FlatStyle = FlatStyle.Flat;
            btnReiniciar.Font = new Font("Segoe UI", 15F);
            btnReiniciar.Location = new Point(723, 492);
            btnReiniciar.Name = "btnReiniciar";
            btnReiniciar.Size = new Size(38, 44);
            btnReiniciar.TabIndex = 47;
            btnReiniciar.UseVisualStyleBackColor = false;
            btnReiniciar.Click += btnReiniciar_Click;
            // 
            // btnResetBrillo
            // 
            btnResetBrillo.FlatAppearance.BorderSize = 0;
            btnResetBrillo.FlatStyle = FlatStyle.Flat;
            btnResetBrillo.Font = new Font("Segoe UI", 12F);
            btnResetBrillo.ForeColor = Color.Violet;
            btnResetBrillo.Location = new Point(429, 528);
            btnResetBrillo.Name = "btnResetBrillo";
            btnResetBrillo.Size = new Size(56, 31);
            btnResetBrillo.TabIndex = 48;
            btnResetBrillo.Text = "reset";
            btnResetBrillo.UseVisualStyleBackColor = true;
            btnResetBrillo.Click += btnResetBrillo_Click;
            // 
            // btnResetSaturacion
            // 
            btnResetSaturacion.FlatAppearance.BorderSize = 0;
            btnResetSaturacion.FlatStyle = FlatStyle.Flat;
            btnResetSaturacion.Font = new Font("Segoe UI", 12F);
            btnResetSaturacion.ForeColor = Color.Violet;
            btnResetSaturacion.Location = new Point(429, 640);
            btnResetSaturacion.Name = "btnResetSaturacion";
            btnResetSaturacion.Size = new Size(56, 31);
            btnResetSaturacion.TabIndex = 49;
            btnResetSaturacion.Text = "reset";
            btnResetSaturacion.UseVisualStyleBackColor = true;
            btnResetSaturacion.Click += btnResetSaturacion_Click;
            // 
            // btnResetContraste
            // 
            btnResetContraste.FlatAppearance.BorderSize = 0;
            btnResetContraste.FlatStyle = FlatStyle.Flat;
            btnResetContraste.Font = new Font("Segoe UI", 12F);
            btnResetContraste.ForeColor = Color.Violet;
            btnResetContraste.Location = new Point(429, 752);
            btnResetContraste.Name = "btnResetContraste";
            btnResetContraste.Size = new Size(56, 31);
            btnResetContraste.TabIndex = 50;
            btnResetContraste.Text = "reset";
            btnResetContraste.UseVisualStyleBackColor = true;
            btnResetContraste.Click += btnResetContraste_Click;
            // 
            // btnBrillo
            // 
            btnBrillo.FlatAppearance.BorderSize = 0;
            btnBrillo.FlatStyle = FlatStyle.Flat;
            btnBrillo.Font = new Font("Segoe UI", 12F);
            btnBrillo.ForeColor = Color.Violet;
            btnBrillo.Location = new Point(274, 579);
            btnBrillo.Name = "btnBrillo";
            btnBrillo.Size = new Size(149, 31);
            btnBrillo.TabIndex = 51;
            btnBrillo.Text = "Activar";
            btnBrillo.UseVisualStyleBackColor = true;
            btnBrillo.Click += btnBrillo_Click;
            // 
            // btnSaturacion
            // 
            btnSaturacion.FlatAppearance.BorderSize = 0;
            btnSaturacion.FlatStyle = FlatStyle.Flat;
            btnSaturacion.Font = new Font("Segoe UI", 12F);
            btnSaturacion.ForeColor = Color.Violet;
            btnSaturacion.Location = new Point(274, 691);
            btnSaturacion.Name = "btnSaturacion";
            btnSaturacion.Size = new Size(149, 31);
            btnSaturacion.TabIndex = 52;
            btnSaturacion.Text = "Activar";
            btnSaturacion.UseVisualStyleBackColor = true;
            btnSaturacion.Click += btnSaturacion_Click;
            // 
            // btnContraste
            // 
            btnContraste.FlatAppearance.BorderSize = 0;
            btnContraste.FlatStyle = FlatStyle.Flat;
            btnContraste.Font = new Font("Segoe UI", 12F);
            btnContraste.ForeColor = Color.Violet;
            btnContraste.Location = new Point(274, 803);
            btnContraste.Name = "btnContraste";
            btnContraste.Size = new Size(149, 31);
            btnContraste.TabIndex = 53;
            btnContraste.Text = "Activar";
            btnContraste.UseVisualStyleBackColor = true;
            btnContraste.Click += btnContraste_Click;
            // 
            // pictureBoxHistograma
            // 
            pictureBoxHistograma.BackColor = Color.White;
            pictureBoxHistograma.Location = new Point(524, 622);
            pictureBoxHistograma.Name = "pictureBoxHistograma";
            pictureBoxHistograma.Size = new Size(300, 150);
            pictureBoxHistograma.TabIndex = 54;
            pictureBoxHistograma.TabStop = false;
            // 
            // VIDEO
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(1010, 862);
            Controls.Add(pictureBoxHistograma);
            Controls.Add(btnContraste);
            Controls.Add(btnSaturacion);
            Controls.Add(btnBrillo);
            Controls.Add(btnResetContraste);
            Controls.Add(btnResetSaturacion);
            Controls.Add(btnResetBrillo);
            Controls.Add(btnReiniciar);
            Controls.Add(btnPausar);
            Controls.Add(btnReproducir);
            Controls.Add(BTN_SALIR);
            Controls.Add(trackBarContraste);
            Controls.Add(label6);
            Controls.Add(trackBar2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(trackBarBrillo);
            Controls.Add(btnFlip);
            Controls.Add(btnKirsch);
            Controls.Add(btnMosaicoDuplicado);
            Controls.Add(btnMosaico);
            Controls.Add(btnRuido);
            Controls.Add(btnColorizar);
            Controls.Add(btnGamma);
            Controls.Add(btnAberracion);
            Controls.Add(btnMoradizar);
            Controls.Add(btnNegativo);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCargarVideo);
            Controls.Add(pictureBoxVideo);
            Name = "VIDEO";
            Text = "VIDEO";
            Load += VIDEO_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxVideo).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarContraste).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarBrillo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHistograma).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxVideo;
        private Button BTN_SALIR;
        private TrackBar trackBarContraste;
        private Label label6;
        private TrackBar trackBar2;
        private Label label5;
        private Label label4;
        private TrackBar trackBarBrillo;
        private Button btnFlip;
        private Button btnKirsch;
        private Button btnMosaicoDuplicado;
        private Button btnMosaico;
        private Button btnRuido;
        private Button btnColorizar;
        private Button btnGamma;
        private Button btnAberracion;
        private Button btnMoradizar;
        private Button btnNegativo;
        private Label label2;
        private Label label1;
        private Button btnCargarVideo;
        private System.Windows.Forms.Timer timerVideo;
        private Button btnReproducir;
        private Button btnPausar;
        private Button btnReiniciar;
        private Button btnResetBrillo;
        private Button btnResetSaturacion;
        private Button btnResetContraste;
        private Button btnBrillo;
        private Button btnSaturacion;
        private Button btnContraste;
        private PictureBox pictureBoxHistograma;
    }
}