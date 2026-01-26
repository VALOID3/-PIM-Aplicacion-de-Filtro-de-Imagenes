using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using Emgu.CV.Util;
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
    public partial class VIDEO : Form
    {


        private VideoCapture _capture;
        private Mat _frame;

        //variables de estado para los filtros boton
        private bool aplicarNegativo = false;
        private bool aplicarMoradizar = false;
        private bool aplicarAberracion = false;
        private bool aplicarGamma = false;
        private bool aplicarColorizar = false;
        private bool aplicarRuido = false;
        private bool aplicarMosaico = false;
        private bool aplicarMosaicoDuplicado = false;
        private bool aplicarKirsch = false;
        private bool aplicarFlip = false;

        //variables para los filtros con trackbar

        private bool aplicarBrillo = false;
        private int valorBrillo = 0; // Rango sugerido: -100 a +100
        private bool aplicarSaturacion = false;
        private int valorSaturacion = 0; // Rango sugerido: -100 a +100
        private bool aplicarContraste = false;
        private int valorContraste = 0; // Rango sugerido: -100 a +100






        public VIDEO()
        {
            InitializeComponent();

            _frame = new Mat();
            timerVideo.Interval = 30; // Aproximadamente 33ms para ~30fps
            timerVideo.Tick += timerVideo_Tick;

        }

        private void BTN_SALIR_Click(object sender, EventArgs e)
        {
            this.Hide();
            var pantalla = new Form1();
            pantalla.Show();
        }

        private void VIDEO_Load(object sender, EventArgs e)
        {

        }

        private void btnCargarVideo_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Archivos de video|*.mp4;*.avi;*.mov;*.wmv";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                _capture = new VideoCapture(ofd.FileName);
                timerVideo.Start();
            }

        }

        private void pictureBoxVideo_Click(object sender, EventArgs e)
        {

        }

        //aqui va la logica de los filtros
        private void timerVideo_Tick(object sender, EventArgs e)
        {

            if (_capture != null && _capture.Ptr != IntPtr.Zero)
            {
                _capture.Read(_frame);
                if (!_frame.IsEmpty)
                {
                    using (var image = _frame.ToImage<Bgr, byte>())
                    {
                        Image<Bgr, byte> resultado;

                        if (aplicarNegativo)
                        {
                            resultado = new Image<Bgr, byte>(image.Width, image.Height);
                            CvInvoke.BitwiseNot(image, resultado);
                        }
                        else if (aplicarMoradizar)
                        {

                            resultado = image.Clone();
                            // Aumentar rojo y azul, reducir verde
                            resultado._Mul(1.0); // Clonamos primero sin modificar

                            // Multiplicar canales manualmente
                            for (int y = 0; y < resultado.Rows; y++)
                            {
                                for (int x = 0; x < resultado.Cols; x++)
                                {
                                    var color = resultado[y, x];
                                    color.Blue = (byte)Math.Min(color.Blue * 1.2, 255);
                                    color.Green = (byte)Math.Min(color.Green * 0.5, 255);
                                    color.Red = (byte)Math.Min(color.Red * 1.2, 255);
                                    resultado[y, x] = color;
                                }
                            }


                        }
                        else if (aplicarAberracion)
                        {

                            resultado = image.Clone();

                            // Calcular desplazamientos proporcionales
                            int desplazamientoAzul = Math.Max(resultado.Width / 20, 1);  // ~5% del ancho
                            int desplazamientoRojo = Math.Max(resultado.Width / 40, 1);  // ~2.5% del ancho

                            if (resultado.Width > desplazamientoAzul + desplazamientoRojo)
                            {
                                var canales = resultado.Split(); // canales[0]=B, [1]=G, [2]=R
                                var azul = canales[0];
                                var verde = canales[1];
                                var rojo = canales[2];

                                var azulShift = azul.CopyBlank();
                                var rojoShift = rojo.CopyBlank();

                                // Desplazar azul a la derecha
                                azul.ROI = new Rectangle(0, 0, azul.Width - desplazamientoAzul, azul.Height);
                                azulShift.ROI = new Rectangle(desplazamientoAzul, 0, azul.Width - desplazamientoAzul, azul.Height);
                                azul.CopyTo(azulShift);
                                azul.ROI = Rectangle.Empty;
                                azulShift.ROI = Rectangle.Empty;

                                // Desplazar rojo a la izquierda
                                rojo.ROI = new Rectangle(desplazamientoRojo, 0, rojo.Width - desplazamientoRojo, rojo.Height);
                                rojoShift.ROI = new Rectangle(0, 0, rojo.Width - desplazamientoRojo, rojo.Height);
                                rojo.CopyTo(rojoShift);
                                rojo.ROI = Rectangle.Empty;
                                rojoShift.ROI = Rectangle.Empty;

                                VectorOfMat canalesFinales = new VectorOfMat();
                                canalesFinales.Push(azulShift.Mat);
                                canalesFinales.Push(verde.Mat);
                                canalesFinales.Push(rojoShift.Mat);

                                CvInvoke.Merge(canalesFinales, resultado);
                            }

                        }
                        else if (aplicarGamma)
                        {

                            resultado = image.Clone();
                            double gamma = 2.2; // Puedes ajustar este valor
                            byte[] gammaLUT = new byte[256];
                            for (int i = 0; i < 256; i++)
                            {

                                gammaLUT[i] = (byte)Math.Min(255, Math.Round(255.0 * Math.Pow(i / 255.0, 1.0 / gamma)));

                            }

                            for (int y = 0; y < resultado.Rows; y++)
                            {
                                for (int x = 0; x < resultado.Cols; x++)
                                {
                                    var color = resultado[y, x];

                                    color.Blue = (byte)gammaLUT[(int)color.Blue];
                                    color.Green = (byte)gammaLUT[(int)color.Green];
                                    color.Red = (byte)gammaLUT[(int)color.Red];

                                    resultado[y, x] = color;
                                }
                            }

                        }
                        else if (aplicarColorizar)
                        {
                            resultado = image.Clone();
                            // Tinte azul-verdoso
                            var colorTinte = new Bgr(100, 180, 255); // B, G, R
                            double alpha = 0.5; // intensidad del tinte

                            for (int y = 0; y < resultado.Rows; y++)
                            {
                                for (int x = 0; x < resultado.Cols; x++)
                                {
                                    var pixel = resultado[y, x];
                                    pixel.Blue = (byte)Math.Min(255, (1 - alpha) * pixel.Blue + alpha * colorTinte.Blue);
                                    pixel.Green = (byte)Math.Min(255, (1 - alpha) * pixel.Green + alpha * colorTinte.Green);
                                    pixel.Red = (byte)Math.Min(255, (1 - alpha) * pixel.Red + alpha * colorTinte.Red);
                                    resultado[y, x] = pixel;
                                }
                            }
                        }
                        else if (aplicarRuido)
                        {
                            resultado = image.Clone();
                            Random rand = new Random();
                            double probabilidadRuido = 0.02; // 2% de los píxeles tendrán ruido

                            for (int y = 0; y < resultado.Rows; y++)
                            {
                                for (int x = 0; x < resultado.Cols; x++)
                                {
                                    if (rand.NextDouble() < probabilidadRuido)
                                    {
                                        // Sal o pimienta aleatoriamente
                                        byte valor = (byte)(rand.Next(2) == 0 ? 0 : 255);
                                        resultado[y, x] = new Bgr(valor, valor, valor);
                                    }
                                }
                            }
                        }
                        else if (aplicarMosaico)
                        {
                            resultado = image.Clone();
                            int factor = 10; // Tamaño del bloque de píxeles (ajustable)

                            // Reducir resolución
                            var reducido = resultado.Resize(1.0 / factor, Emgu.CV.CvEnum.Inter.Linear);

                            // Volver a escalar al tamaño original
                            resultado = reducido.Resize(resultado.Width, resultado.Height, Emgu.CV.CvEnum.Inter.Nearest);
                        }
                        else if (aplicarMosaicoDuplicado)
                        {
                            int filas = 4; // Número de filas del mosaico
                            int columnas = 4; // Número de columnas del mosaico

                            int anchoCelda = image.Width / columnas;
                            int altoCelda = image.Height / filas;

                            resultado = new Image<Bgr, byte>(image.Width, image.Height);

                            var miniatura = image.Resize(1.0 / columnas, Emgu.CV.CvEnum.Inter.Area);

                            for (int i = 0; i < filas; i++)
                            {
                                for (int j = 0; j < columnas; j++)
                                {
                                    Rectangle roi = new Rectangle(j * anchoCelda, i * altoCelda, anchoCelda, altoCelda);
                                    resultado.ROI = roi;
                                    var miniRedimensionada = miniatura.Resize(anchoCelda, altoCelda, Emgu.CV.CvEnum.Inter.Area);
                                    miniRedimensionada.CopyTo(resultado);
                                    resultado.ROI = Rectangle.Empty;
                                }
                            }
                        }
                        else if (aplicarKirsch)
                        {
                            var gray = image.Convert<Gray, byte>();
                            Image<Gray, float> maxResponse = new Image<Gray, float>(gray.Size);
                            float[][] kernels = new float[][]
                            {
                                new float[] { 5,  5,  5, -3,  0, -3, -3, -3, -3 }, // Norte
                                new float[] { 5,  5, -3,  5,  0, -3, -3, -3, -3 }, // Noreste
                                new float[] { 5, -3, -3,  5,  0, -3,  5, -3, -3 }, // Este
                                new float[] { -3, -3, -3,  5,  0, -3,  5,  5, -3 }, // Sureste
                                new float[] { -3, -3, -3, -3,  0, -3,  5,  5,  5 }, // Sur
                                new float[] { -3, -3, -3, -3,  0,  5, -3,  5,  5 }, // Suroeste
                                new float[] { -3, -3,  5, -3,  0,  5, -3, -3,  5 }, // Oeste
                                new float[] { -3,  5,  5, -3,  0,  5, -3, -3, -3 }  // Noroeste
                            };

                            foreach (var kernel in kernels)
                            {

                                float[,] kernel2D = new float[3, 3]
                                 {
                                       { kernel[0], kernel[1], kernel[2] },
                                       { kernel[3], kernel[4], kernel[5] },
                                       { kernel[6], kernel[7], kernel[8] }
                                 };

                                var kernelMatrix = new ConvolutionKernelF(kernel2D);
                                var response = gray.Convolution(kernelMatrix);
                                CvInvoke.Max(response, maxResponse, maxResponse);

                            }

                            var kirschColor = maxResponse.Convert<Bgr, byte>();
                            resultado = kirschColor;
                        }
                        else if (aplicarFlip)
                        {
                            resultado = image.Flip(Emgu.CV.CvEnum.FlipType.Horizontal); // Puedes cambiar a Vertical o Both
                        }
                        //filtros con track bar
                        else if (aplicarBrillo)
                        {
                            resultado = image.Clone();

                            for (int y = 0; y < resultado.Rows; y++)
                            {
                                for (int x = 0; x < resultado.Cols; x++)
                                {
                                    var color = resultado[y, x];
                                    color.Blue = (byte)Math.Min(255, Math.Max(0, color.Blue + valorBrillo));
                                    color.Green = (byte)Math.Min(255, Math.Max(0, color.Green + valorBrillo));
                                    color.Red = (byte)Math.Min(255, Math.Max(0, color.Red + valorBrillo));
                                    resultado[y, x] = color;
                                }
                            }
                        }
                        else if (aplicarSaturacion)
                        {
                            resultado = image.Clone();

                            for (int y = 0; y < resultado.Rows; y++)
                            {
                                for (int x = 0; x < resultado.Cols; x++)
                                {
                                    var pixel = resultado[y, x];

                                    // Convertir a HLS (Hue, Lightness, Saturation)
                                    double r = pixel.Red / 255.0;
                                    double g = pixel.Green / 255.0;
                                    double b = pixel.Blue / 255.0;

                                    double max = Math.Max(r, Math.Max(g, b));
                                    double min = Math.Min(r, Math.Min(g, b));
                                    double l = (max + min) / 2.0;
                                    double s = 0;

                                    if (max != min)
                                    {
                                        s = l < 0.5 ? (max - min) / (max + min) : (max - min) / (2.0 - max - min);
                                    }

                                    // Ajustar saturación
                                    double factor = 1.0 + (valorSaturacion / 100.0);
                                    s = Math.Min(1.0, Math.Max(0.0, s * factor));

                                    // Convertir de nuevo a RGB (simplificado: solo escala los canales)
                                    double scale = s / (Math.Max(r, Math.Max(g, b)) + 0.0001);
                                    r = Math.Min(1.0, r * scale);
                                    g = Math.Min(1.0, g * scale);
                                    b = Math.Min(1.0, b * scale);

                                    pixel.Red = (byte)(r * 255);
                                    pixel.Green = (byte)(g * 255);
                                    pixel.Blue = (byte)(b * 255);

                                    resultado[y, x] = pixel;
                                }
                            }
                        }
                        else if (aplicarContraste)
                        {
                            resultado = image.Clone();

                            double factor = (259 * (valorContraste + 255)) / (255 * (259 - valorContraste)); // fórmula de contraste

                            for (int y = 0; y < resultado.Rows; y++)
                            {
                                for (int x = 0; x < resultado.Cols; x++)
                                {
                                    var color = resultado[y, x];
                                    color.Blue = (byte)Math.Min(255, Math.Max(0, factor * (color.Blue - 128) + 128));
                                    color.Green = (byte)Math.Min(255, Math.Max(0, factor * (color.Green - 128) + 128));
                                    color.Red = (byte)Math.Min(255, Math.Max(0, factor * (color.Red - 128) + 128));
                                    resultado[y, x] = color;
                                }
                            }
                        }
                        else
                        {
                            resultado = image.Clone(); // sin filtro
                        }


                        MostrarHistograma(resultado);

                        pictureBoxVideo.Image?.Dispose();
                        Bitmap bmp = new Bitmap(resultado.Width, resultado.Height, resultado.MIplImage.WidthStep,
                        System.Drawing.Imaging.PixelFormat.Format24bppRgb,
                        resultado.MIplImage.ImageData);
                        pictureBoxVideo.Image = bmp;
                    }
                }
                else
                {
                    timerVideo.Stop(); // Fin del video
                }
            }


        }

        private void MostrarHistograma(Image<Bgr, byte> imagen)
        {
            DenseHistogram histR = new DenseHistogram(256, new RangeF(0, 256));
            DenseHistogram histG = new DenseHistogram(256, new RangeF(0, 256));
            DenseHistogram histB = new DenseHistogram(256, new RangeF(0, 256));

            var canales = imagen.Split();
            histB.Calculate(new Image<Gray, byte>[] { canales[0] }, false, null);
            histG.Calculate(new Image<Gray, byte>[] { canales[1] }, false, null);
            histR.Calculate(new Image<Gray, byte>[] { canales[2] }, false, null);

            int width = 256;
            int height = 100;
            Bitmap bmp = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.Black);

                float[] dataR = histR.GetBinValues();
                float[] dataG = histG.GetBinValues();
                float[] dataB = histB.GetBinValues();

                float max = Math.Max(dataR.Max(), Math.Max(dataG.Max(), dataB.Max()));

                for (int i = 0; i < 256; i++)
                {
                    int r = (int)(dataR[i] / max * height);
                    int gVal = (int)(dataG[i] / max * height);
                    int b = (int)(dataB[i] / max * height);

                    g.DrawLine(Pens.Red, i, height, i, height - r);
                    g.DrawLine(Pens.Green, i, height, i, height - gVal);
                    g.DrawLine(Pens.Blue, i, height, i, height - b);
                }
            }

            pictureBoxHistograma.Image?.Dispose();
            pictureBoxHistograma.Image = bmp;
        }


        private void btnReproducir_Click(object sender, EventArgs e)
        {

            if (_capture != null)
            {
                timerVideo.Start();
            }

        }

        private void btnPausar_Click(object sender, EventArgs e)
        {
            timerVideo.Stop();
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {

            if (_capture != null)
            {
                _capture.Set(Emgu.CV.CvEnum.CapProp.PosFrames, 0); // Volver al primer fotograma
                timerVideo.Start();
            }

        }

        private void btnNegativo_Click(object sender, EventArgs e)
        {

            aplicarNegativo = !aplicarNegativo;
            btnNegativo.Text = aplicarNegativo ? "Quitar Negativo" : "Aplicar Negativo";

        }

        private void btnMoradizar_Click(object sender, EventArgs e)
        {

            aplicarMoradizar = !aplicarMoradizar;
            btnMoradizar.Text = aplicarMoradizar ? "Quitar Moradizar" : "Aplicar Moradizar";

        }

        private void btnAberracion_Click(object sender, EventArgs e)
        {

            aplicarAberracion = !aplicarAberracion;
            btnAberracion.Text = aplicarAberracion ? "Quitar Aberración" : "Aplicar Aberración Cromática";

        }

        private void btnGamma_Click(object sender, EventArgs e)
        {

            aplicarGamma = !aplicarGamma;
            btnGamma.Text = aplicarGamma ? "Quitar Gamma" : "Aplicar Gamma";

        }

        private void btnColorizar_Click(object sender, EventArgs e)
        {

            aplicarColorizar = !aplicarColorizar;
            btnColorizar.Text = aplicarColorizar ? "Quitar Colorizar" : "Aplicar Colorizar";

        }

        private void btnRuido_Click(object sender, EventArgs e)
        {

            aplicarRuido = !aplicarRuido;
            btnRuido.Text = aplicarRuido ? "Quitar Ruido" : "Aplicar Ruido";

        }

        private void btnMosaico_Click(object sender, EventArgs e)
        {

            aplicarMosaico = !aplicarMosaico;
            btnMosaico.Text = aplicarMosaico ? "Quitar Mosaico" : "Aplicar Mosaico";

        }

        private void btnMosaicoDuplicado_Click(object sender, EventArgs e)
        {

            aplicarMosaicoDuplicado = !aplicarMosaicoDuplicado;
            btnMosaicoDuplicado.Text = aplicarMosaicoDuplicado ? "Quitar Mosaico Duplicado" : "Aplicar Mosaico Duplicado";

        }

        private void btnKirsch_Click(object sender, EventArgs e)
        {

            aplicarKirsch = !aplicarKirsch;
            btnKirsch.Text = aplicarKirsch ? "Quitar Kirsch" : "Aplicar Kirsch";

        }

        private void btnFlip_Click(object sender, EventArgs e)
        {

            aplicarFlip = !aplicarFlip;
            btnFlip.Text = aplicarFlip ? "Quitar Flip" : "Aplicar Flip";

        }

        private void trackBarBrillo_Scroll(object sender, EventArgs e)
        {
            valorBrillo = trackBarBrillo.Value;
        }

        private void btnResetBrillo_Click(object sender, EventArgs e)
        {

            trackBarBrillo.Value = 0;
            valorBrillo = 0;

        }

        private void btnBrillo_Click(object sender, EventArgs e)
        {

            aplicarBrillo = !aplicarBrillo;
            btnBrillo.Text = aplicarBrillo ? "Quitar Brillo" : "Aplicar Brillo";

        }

        private void btnSaturacion_Click(object sender, EventArgs e)
        {

            aplicarSaturacion = !aplicarSaturacion;
            btnSaturacion.Text = aplicarSaturacion ? "Quitar Saturación" : "Aplicar Saturación";

        }

        private void btnResetSaturacion_Click(object sender, EventArgs e)
        {


            trackBar2.Value = 0;
            valorSaturacion = 0;

        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            valorSaturacion = trackBar2.Value;
        }

        private void btnContraste_Click(object sender, EventArgs e)
        {

            aplicarContraste = !aplicarContraste;
            btnContraste.Text = aplicarContraste ? "Quitar Contraste" : "Aplicar Contraste";

        }

        private void btnResetContraste_Click(object sender, EventArgs e)
        {

            trackBarContraste.Value = 0;
            valorContraste = 0;

        }

        private void trackBarContraste_Scroll(object sender, EventArgs e)
        {
            valorContraste = trackBarContraste.Value;
        }
    }
}

