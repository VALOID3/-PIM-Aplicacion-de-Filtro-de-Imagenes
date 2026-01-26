namespace PIA_ProceImg
{
    partial class ROSTRO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ROSTRO));
            listBox1 = new ListBox();
            comboBox1 = new ComboBox();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            BTN_SALIR = new Button();
            btnSeleccionarColor = new Button();
            colorDialog1 = new ColorDialog();
            panelColorSeleccionado = new Panel();
            label2 = new Label();
            labelColorInfo = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(326, 86);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(0, 4);
            listBox1.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(146, 57);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(225, 23);
            comboBox1.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Indigo;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = Color.GhostWhite;
            label4.Location = new Point(38, 55);
            label4.Name = "label4";
            label4.Size = new Size(90, 21);
            label4.TabIndex = 40;
            label4.Text = "Dispositivo:";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(97, 99);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(751, 474);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 41;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            pictureBox1.MouseClick += pictureBox1_MouseClick;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F);
            button1.ForeColor = Color.Violet;
            button1.Location = new Point(426, 52);
            button1.Name = "button1";
            button1.Size = new Size(85, 38);
            button1.TabIndex = 42;
            button1.Text = "Activar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F);
            button2.ForeColor = Color.Violet;
            button2.Location = new Point(531, 55);
            button2.Name = "button2";
            button2.Size = new Size(96, 38);
            button2.TabIndex = 43;
            button2.Text = "Desactivar Camara";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
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
            BTN_SALIR.TabIndex = 45;
            BTN_SALIR.UseVisualStyleBackColor = false;
            BTN_SALIR.Click += BTN_SALIR_Click;
            // 
            // btnSeleccionarColor
            // 
            btnSeleccionarColor.FlatAppearance.BorderSize = 0;
            btnSeleccionarColor.FlatStyle = FlatStyle.Flat;
            btnSeleccionarColor.Font = new Font("Segoe UI", 12F);
            btnSeleccionarColor.ForeColor = Color.Violet;
            btnSeleccionarColor.Location = new Point(426, 604);
            btnSeleccionarColor.Name = "btnSeleccionarColor";
            btnSeleccionarColor.Size = new Size(136, 38);
            btnSeleccionarColor.TabIndex = 46;
            btnSeleccionarColor.Text = "Seleccionar color";
            btnSeleccionarColor.UseVisualStyleBackColor = true;
            btnSeleccionarColor.Click += btnSeleccionarColor_Click;
            // 
            // panelColorSeleccionado
            // 
            panelColorSeleccionado.Location = new Point(898, 116);
            panelColorSeleccionado.Name = "panelColorSeleccionado";
            panelColorSeleccionado.Size = new Size(200, 200);
            panelColorSeleccionado.TabIndex = 47;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Indigo;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.GhostWhite;
            label2.Location = new Point(898, 86);
            label2.Name = "label2";
            label2.Size = new Size(143, 21);
            label2.TabIndex = 48;
            label2.Text = "Color Seleccionado";
            // 
            // labelColorInfo
            // 
            labelColorInfo.AutoSize = true;
            labelColorInfo.BackColor = Color.Indigo;
            labelColorInfo.Font = new Font("Segoe UI", 12F);
            labelColorInfo.ForeColor = Color.GhostWhite;
            labelColorInfo.Location = new Point(889, 384);
            labelColorInfo.Name = "labelColorInfo";
            labelColorInfo.Size = new Size(61, 21);
            labelColorInfo.TabIndex = 49;
            labelColorInfo.Text = "Color: -";
            // 
            // ROSTRO
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(1162, 818);
            Controls.Add(labelColorInfo);
            Controls.Add(label2);
            Controls.Add(panelColorSeleccionado);
            Controls.Add(btnSeleccionarColor);
            Controls.Add(BTN_SALIR);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(listBox1);
            Name = "ROSTRO";
            Text = "ROSTRO";
            FormClosed += ROSTRO_FormClosed;
            Load += ROSTRO_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private ComboBox comboBox1;
        private Label label4;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Button BTN_SALIR;
        private Button btnSeleccionarColor;
        private ColorDialog colorDialog1;
        private Panel panelColorSeleccionado;
        private Label label2;
        private Label labelColorInfo;
    }
}