using AForge.Video;
using AForge.Video.DirectShow;
using Emgu.CV.Structure;
using Emgu.CV;
using Emgu.CV.CvEnum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIA_ProceImg
{
    public partial class ROSTRO : Form
    {

        //para las camaras
        private bool haydispositivos;
        private FilterInfoCollection misDispospositivos;
        private VideoCaptureDevice micamara;

        //para detectar color
        private Color colorSeleccionado = Color.Red; // Color por defecto

        private Bitmap frameOriginal;



        public ROSTRO()
        {
            InitializeComponent();
        }

        private void BTN_SALIR_Click(object sender, EventArgs e)
        {
            this.Hide();
            var pantalla = new Form1();
            pantalla.Show();
        }

        private void ROSTRO_Load(object sender, EventArgs e)
        {
            CargaDispositivos();
        }

        public void CargaDispositivos()
        {
            misDispospositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            if (misDispospositivos.Count > 0)
            {
                haydispositivos = true;
                for (int i = 0; i < misDispospositivos.Count; i++)
                    comboBox1.Items.Add(misDispospositivos[i].Name.ToString());
                comboBox1.Text = misDispospositivos[0].ToString();
            }
            else
            {
                haydispositivos = false;
            }
        }

        public void cerrarcamara()
        {
            if (micamara != null && micamara.IsRunning)
            {
                micamara.SignalToStop();
                micamara = null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cerrarcamara();
            int i = comboBox1.SelectedIndex;
            string NombreVide = misDispospositivos[i].MonikerString;
            micamara = new VideoCaptureDevice(NombreVide);
            micamara.NewFrame += new NewFrameEventHandler(Capturando);
            micamara.Start();
        }

        private void Capturando(object sender, NewFrameEventArgs eventArgs)
        {


            Bitmap frame = (Bitmap)eventArgs.Frame.Clone();

            frameOriginal?.Dispose();
            frameOriginal = (Bitmap)frame.Clone();

            var img = Emgu.CV.BitmapExtension.ToImage<Bgr, byte>(frame);

            // Convertir a HSV
            var hsv = img.Convert<Hsv, byte>();

            // Convertir color seleccionado a HSV
            var colorBgr = new Bgr(colorSeleccionado);
            var colorHsvImg = new Image<Bgr, byte>(1, 1);
            colorHsvImg[0, 0] = colorBgr;
            var hsvColor = colorHsvImg.Convert<Hsv, byte>()[0, 0];

            // Rango de tolerancia
            int tolerancia = 20;
            var min = new Hsv(
            Math.Max(hsvColor.Hue - tolerancia, 0),
            Math.Max(hsvColor.Satuation - 50, 0),
            Math.Max(hsvColor.Value - 50, 0));
            var max = new Hsv(
            Math.Min(hsvColor.Hue + tolerancia, 179),
            Math.Min(hsvColor.Satuation + 50, 255),
            Math.Min(hsvColor.Value + 50, 255));

            // Crear máscara
            var mask = hsv.InRange(min, max);

            // Invertir máscara
            var maskInv = mask.Not();

            // Convertir imagen original a escala de grises y luego a BGR
            var gray = img.Convert<Gray, byte>().Convert<Bgr, byte>();

            // Aplicar máscaras
            var colorPart = img.Copy(mask);
            var grayPart = gray.Copy(maskInv);

            // Combinar ambas partes
            var final = colorPart + grayPart;

            // Mostrar en PictureBox
            pictureBox1.Image?.Dispose();
            pictureBox1.Image = final.ToBitmap();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            cerrarcamara();
        }

        private void ROSTRO_FormClosed(object sender, FormClosedEventArgs e)
        {
            cerrarcamara();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnSeleccionarColor_Click(object sender, EventArgs e)
        {

            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    colorSeleccionado = colorDialog.Color;
                }
            }

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {


            if (frameOriginal == null) return;

            if (e.X >= frameOriginal.Width || e.Y >= frameOriginal.Height) return;

            Color color = frameOriginal.GetPixel(e.X, e.Y);
            colorSeleccionado = color;
            panelColorSeleccionado.BackColor = color;


            // Mostrar valores RGB y Hex
            string hex = $"#{color.R:X2}{color.G:X2}{color.B:X2}";
            labelColorInfo.Text = $"Color: RGB({color.R}, {color.G}, {color.B}) | HEX: {hex}";


        }
    }
}
