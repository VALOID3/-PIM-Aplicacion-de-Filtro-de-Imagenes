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
    public partial class IMG : Form
    {
        private Bitmap IMG_Original;

        public IMG()
        {
            InitializeComponent();
        }

        private void BTN_GAMMA_Click(object sender, EventArgs e)
        {
            if (IMG_Original != null)
            {
                double gamma = 1.5; // puedes cambiar este valor a gusto
                Bitmap gammaImg = new Bitmap(IMG_Original.Width, IMG_Original.Height);

                byte[] gammaLUT = new byte[256];
                for (int i = 0; i < 256; i++)
                {
                    gammaLUT[i] = (byte)Math.Min(255,
                        (int)((255.0 * Math.Pow(i / 255.0, gamma)) + 0.5));
                }

                for (int y = 0; y < IMG_Original.Height; y++)
                {
                    for (int x = 0; x < IMG_Original.Width; x++)
                    {
                        Color c = IMG_Original.GetPixel(x, y);
                        Color cg = Color.FromArgb(
                            gammaLUT[c.R],
                            gammaLUT[c.G],
                            gammaLUT[c.B]);
                        gammaImg.SetPixel(x, y, cg);
                    }
                }

                pictureBoxFiltro.Image = gammaImg;
                DibujarHistograma((Bitmap)pictureBoxFiltro.Image);
            }
        }

        private void IMG_Load(object sender, EventArgs e)
        {

        }

        private void BTN_SALIR_Click(object sender, EventArgs e)
        {
            this.Hide();
            var pantalla = new Form1();
            pantalla.Show();
        }

        private void IMG_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Imágenes|*.jpg;*.jpeg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                IMG_Original = new Bitmap(ofd.FileName);
                pictureBoxIMG.Image = IMG_Original;
                pictureBoxFiltro.Image = null;
            }

            // Aquí debes llamar al método que genera el histograma
            DibujarHistograma(IMG_Original);
        }

        private void BTN_NEGATIVO_Click(object sender, EventArgs e)
        {
            if (IMG_Original != null)
            {
                Bitmap negativo = new Bitmap(IMG_Original.Width, IMG_Original.Height);
                for (int y = 0; y < IMG_Original.Height; y++)
                {
                    for (int x = 0; x < IMG_Original.Width; x++)
                    {
                        Color c = IMG_Original.GetPixel(x, y);
                        negativo.SetPixel(x, y, Color.FromArgb(255 - c.R, 255 - c.G, 255 - c.B));
                    }
                }
                pictureBoxFiltro.Image = negativo;
                DibujarHistograma((Bitmap)pictureBoxFiltro.Image);
            }
        }



        private void BTN_MORADIZAR_Click(object sender, EventArgs e)
        {
            if (IMG_Original != null)
            {
                Bitmap morado = new Bitmap(IMG_Original.Width, IMG_Original.Height);
                for (int y = 0; y < IMG_Original.Height; y++)
                {
                    for (int x = 0; x < IMG_Original.Width; x++)
                    {
                        Color c = IMG_Original.GetPixel(x, y);

                        // Aumentar rojo y azul, reducir verde para dar efecto púrpura
                        int r = Math.Min(255, c.R + 40);
                        int g = Math.Max(0, c.G - 40);
                        int b = Math.Min(255, c.B + 40);

                        morado.SetPixel(x, y, Color.FromArgb(r, g, b));
                    }
                }
                pictureBoxFiltro.Image = morado;
                DibujarHistograma((Bitmap)pictureBoxFiltro.Image);
            }
        }

        private void BTN_SAVE_Click(object sender, EventArgs e)
        {
            if (pictureBoxFiltro.Image != null)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PNG Image|*.png|JPEG Image|*.jpg|Bitmap Image|*.bmp";
                sfd.Title = "Guardar imagen con filtro";
                sfd.FileName = "imagen_filtrada";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    var formato = System.Drawing.Imaging.ImageFormat.Png;

                    if (sfd.FilterIndex == 2)
                        formato = System.Drawing.Imaging.ImageFormat.Jpeg;
                    else if (sfd.FilterIndex == 3)
                        formato = System.Drawing.Imaging.ImageFormat.Bmp;

                    pictureBoxFiltro.Image.Save(sfd.FileName, formato);
                    MessageBox.Show("Imagen guardada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("No hay imagen filtrada para guardar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BTN_AVECROMATIC_Click(object sender, EventArgs e)
        {
            if (IMG_Original != null)
            {
                int offset = 15; // desplazamiento de los canales

                int width = IMG_Original.Width;
                int height = IMG_Original.Height;
                Bitmap aberracion = new Bitmap(width, height);

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        // Canales desplazados (R más a la derecha, B más a la izquierda)
                        int xr = Math.Min(width - 8, x + offset);
                        int xg = x;
                        int xb = Math.Max(8, x - offset);

                        Color cr = IMG_Original.GetPixel(xr, y);
                        Color cg = IMG_Original.GetPixel(xg, y);
                        Color cb = IMG_Original.GetPixel(xb, y);

                        Color final = Color.FromArgb(cr.R, cg.G, cb.B);
                        aberracion.SetPixel(x, y, final);
                    }
                }

                pictureBoxFiltro.Image = aberracion;
                DibujarHistograma((Bitmap)pictureBoxFiltro.Image);
            }
        }

        private void BTN_COLORIZAR_Click(object sender, EventArgs e)
        {
            if (IMG_Original != null)
            {
                // Color que quieres aplicar como tinte
                Color tinte = Color.FromArgb(13, 77, 0); // morado rojizo, puedes cambiarlo

                Bitmap colorizada = new Bitmap(IMG_Original.Width, IMG_Original.Height);

                for (int y = 0; y < IMG_Original.Height; y++)
                {
                    for (int x = 0; x < IMG_Original.Width; x++)
                    {
                        Color original = IMG_Original.GetPixel(x, y);

                        // Mezclamos el color original con el tinte (promedio)
                        int r = (original.R + tinte.R) / 2;
                        int g = (original.G + tinte.G) / 2;
                        int b = (original.B + tinte.B) / 2;

                        colorizada.SetPixel(x, y, Color.FromArgb(r, g, b));
                    }
                }

                pictureBoxFiltro.Image = colorizada;
                DibujarHistograma((Bitmap)pictureBoxFiltro.Image);
            }
        }

        private void BTN_MOSAICO_Click(object sender, EventArgs e)
        {
            if (IMG_Original != null)
            {
                int tamBloque = 10; // Tamaño del mosaico en píxeles
                Bitmap mosaic = new Bitmap(IMG_Original.Width, IMG_Original.Height);

                for (int y = 0; y < IMG_Original.Height; y += tamBloque)
                {
                    for (int x = 0; x < IMG_Original.Width; x += tamBloque)
                    {
                        int r = 0, g = 0, b = 0;
                        int contador = 0;

                        // Promediar colores del bloque
                        for (int dy = 0; dy < tamBloque && (y + dy) < IMG_Original.Height; dy++)
                        {
                            for (int dx = 0; dx < tamBloque && (x + dx) < IMG_Original.Width; dx++)
                            {
                                Color pixel = IMG_Original.GetPixel(x + dx, y + dy);
                                r += pixel.R;
                                g += pixel.G;
                                b += pixel.B;
                                contador++;
                            }
                        }

                        r /= contador;
                        g /= contador;
                        b /= contador;

                        Color promedio = Color.FromArgb(r, g, b);

                        // Pintar el bloque con el color promedio
                        for (int dy = 0; dy < tamBloque && (y + dy) < IMG_Original.Height; dy++)
                        {
                            for (int dx = 0; dx < tamBloque && (x + dx) < IMG_Original.Width; dx++)
                            {
                                mosaic.SetPixel(x + dx, y + dy, promedio);
                            }
                        }
                    }
                }

                pictureBoxFiltro.Image = mosaic;
                DibujarHistograma((Bitmap)pictureBoxFiltro.Image);
            }
        }

        private void BTN_RUIDO_Click(object sender, EventArgs e)
        {
            if (IMG_Original != null)
            {
                Bitmap conRuido = new Bitmap(IMG_Original.Width, IMG_Original.Height);
                Random rnd = new Random();
                int intensidad = 80; // entre 0 y 255. Más alto = más distorsión.

                for (int y = 0; y < IMG_Original.Height; y++)
                {
                    for (int x = 0; x < IMG_Original.Width; x++)
                    {
                        Color c = IMG_Original.GetPixel(x, y);

                        int ruidoR = c.R + rnd.Next(-intensidad, intensidad + 1);
                        int ruidoG = c.G + rnd.Next(-intensidad, intensidad + 1);
                        int ruidoB = c.B + rnd.Next(-intensidad, intensidad + 1);

                        // Aseguramos que no se pase de 0-255
                        ruidoR = Math.Max(0, Math.Min(255, ruidoR));
                        ruidoG = Math.Max(0, Math.Min(255, ruidoG));
                        ruidoB = Math.Max(0, Math.Min(255, ruidoB));

                        conRuido.SetPixel(x, y, Color.FromArgb(ruidoR, ruidoG, ruidoB));
                    }
                }

                pictureBoxFiltro.Image = conRuido;
                DibujarHistograma((Bitmap)pictureBoxFiltro.Image);
            }
        }

        private void BTN_DUPLICADOMOSAICO_Click(object sender, EventArgs e)
        {
            if (IMG_Original != null)
            {
                // Define cuántas veces quieres repetir la imagen (horizontal y verticalmente)
                int columnas = 4; // Repeticiones horizontales
                int filas = 4;    // Repeticiones verticales

                int anchoSubimagen = IMG_Original.Width / columnas;
                int altoSubimagen = IMG_Original.Height / filas;

                Bitmap mosaico = new Bitmap(IMG_Original.Width, IMG_Original.Height);
                using (Graphics g = Graphics.FromImage(mosaico))
                {
                    for (int y = 0; y < filas; y++)
                    {
                        for (int x = 0; x < columnas; x++)
                        {
                            g.DrawImage(IMG_Original,
                                new Rectangle(x * anchoSubimagen, y * altoSubimagen, anchoSubimagen, altoSubimagen),
                                new Rectangle(0, 0, IMG_Original.Width, IMG_Original.Height),
                                GraphicsUnit.Pixel);
                        }
                    }
                }

                pictureBoxFiltro.Image = mosaico;
                DibujarHistograma((Bitmap)pictureBoxFiltro.Image);
            }
        }

        private void BTN_FLIP_Click(object sender, EventArgs e)
        {
            if (IMG_Original != null)
            {
                Bitmap flip = new Bitmap(IMG_Original);
                flip.RotateFlip(RotateFlipType.RotateNoneFlipX); // Flip horizontal
                pictureBoxFiltro.Image = flip;
                DibujarHistograma((Bitmap)pictureBoxFiltro.Image);
            }
        }

        private void trackBrillo_Scroll(object sender, EventArgs e)
        {
            if (IMG_Original != null)
            {
                int brillo = trackBrillo.Value; // de -100 a 100
                Bitmap ajustada = new Bitmap(IMG_Original.Width, IMG_Original.Height);

                for (int y = 0; y < IMG_Original.Height; y++)
                {
                    for (int x = 0; x < IMG_Original.Width; x++)
                    {
                        Color pixel = IMG_Original.GetPixel(x, y);

                        int r = pixel.R + brillo;
                        int g = pixel.G + brillo;
                        int b = pixel.B + brillo;

                        r = Math.Max(0, Math.Min(255, r));
                        g = Math.Max(0, Math.Min(255, g));
                        b = Math.Max(0, Math.Min(255, b));

                        ajustada.SetPixel(x, y, Color.FromArgb(r, g, b));
                    }
                }

                pictureBoxFiltro.Image = ajustada;
                DibujarHistograma((Bitmap)pictureBoxFiltro.Image);
            }
        }

        private void trackSaturacion_Scroll(object sender, EventArgs e)
        {
            if (IMG_Original != null)
            {
                float factor = trackSaturacion.Value / 100f; // -1.0 a 1.0
                Bitmap ajustada = new Bitmap(IMG_Original.Width, IMG_Original.Height);

                for (int y = 0; y < IMG_Original.Height; y++)
                {
                    for (int x = 0; x < IMG_Original.Width; x++)
                    {
                        Color c = IMG_Original.GetPixel(x, y);

                        // Convertir a escala de grises
                        float gris = (c.R * 0.3f + c.G * 0.59f + c.B * 0.11f);

                        // Interpolar entre gris y color original
                        int r = (int)(gris + (c.R - gris) * (1 + factor));
                        int g = (int)(gris + (c.G - gris) * (1 + factor));
                        int b = (int)(gris + (c.B - gris) * (1 + factor));

                        r = Math.Max(0, Math.Min(255, r));
                        g = Math.Max(0, Math.Min(255, g));
                        b = Math.Max(0, Math.Min(255, b));

                        ajustada.SetPixel(x, y, Color.FromArgb(r, g, b));
                    }
                }

                pictureBoxFiltro.Image = ajustada;
                DibujarHistograma((Bitmap)pictureBoxFiltro.Image);
            }
        }

        private void btnResetBrillo_Click(object sender, EventArgs e)
        {
            trackBrillo.Value = 0;
            pictureBoxFiltro.Image = new Bitmap(IMG_Original); // Vuelve a la imagen original
            DibujarHistograma((Bitmap)pictureBoxFiltro.Image);
        }

        private void btnResetSaturacio_Click(object sender, EventArgs e)
        {
            trackSaturacion.Value = 0;
            pictureBoxFiltro.Image = new Bitmap(IMG_Original); // Restaurar original
            DibujarHistograma((Bitmap)pictureBoxFiltro.Image);
        }

        private void trackContraste_Scroll(object sender, EventArgs e)
        {
            if (IMG_Original != null)
            {
                float contraste = (100f + trackContraste.Value) / 100f; // de 0 a 2
                contraste *= contraste; // mejora el ajuste perceptual

                Bitmap ajustada = new Bitmap(IMG_Original.Width, IMG_Original.Height);

                for (int y = 0; y < IMG_Original.Height; y++)
                {
                    for (int x = 0; x < IMG_Original.Width; x++)
                    {
                        Color c = IMG_Original.GetPixel(x, y);

                        float r = c.R / 255f;
                        float g = c.G / 255f;
                        float b = c.B / 255f;

                        r -= 0.5f;
                        g -= 0.5f;
                        b -= 0.5f;

                        r *= contraste;
                        g *= contraste;
                        b *= contraste;

                        r += 0.5f;
                        g += 0.5f;
                        b += 0.5f;

                        int R = Math.Max(0, Math.Min(255, (int)(r * 255)));
                        int G = Math.Max(0, Math.Min(255, (int)(g * 255)));
                        int B = Math.Max(0, Math.Min(255, (int)(b * 255)));

                        ajustada.SetPixel(x, y, Color.FromArgb(R, G, B));
                    }
                }

                pictureBoxFiltro.Image = ajustada;
                DibujarHistograma((Bitmap)pictureBoxFiltro.Image);
            }
        }

        private void btnResetContraste_Click(object sender, EventArgs e)
        {
            trackContraste.Value = 0;
            pictureBoxFiltro.Image = new Bitmap(IMG_Original);
            DibujarHistograma((Bitmap)pictureBoxFiltro.Image);
        }

        private void pictureBoxHistograma_Click(object sender, EventArgs e)
        {

        }

        private void DibujarHistograma(Bitmap imagen)
        {
            int[] histR = new int[256];
            int[] histG = new int[256];
            int[] histB = new int[256];

            // Contar niveles de color
            for (int y = 0; y < imagen.Height; y++)
            {
                for (int x = 0; x < imagen.Width; x++)
                {
                    Color c = imagen.GetPixel(x, y);
                    histR[c.R]++;
                    histG[c.G]++;
                    histB[c.B]++;
                }
            }

            // Obtener valor máximo para escalar
            int max = Math.Max(histR.Max(), Math.Max(histG.Max(), histB.Max()));

            Bitmap bmpHist = new Bitmap(256, pictureBoxHistograma.Height);
            using (Graphics g = Graphics.FromImage(bmpHist))
            {
                g.Clear(Color.Black);

                for (int i = 0; i < 256; i++)
                {
                    int r = (int)((histR[i] / (float)max) * bmpHist.Height);
                    int gVal = (int)((histG[i] / (float)max) * bmpHist.Height);
                    int b = (int)((histB[i] / (float)max) * bmpHist.Height);

                    if (r > 0)
                        g.DrawLine(Pens.Red, i, bmpHist.Height, i, bmpHist.Height - r);
                    if (gVal > 0)
                        g.DrawLine(Pens.Green, i, bmpHist.Height, i, bmpHist.Height - gVal);
                    if (b > 0)
                        g.DrawLine(Pens.Blue, i, bmpHist.Height, i, bmpHist.Height - b);
                }
            }

            pictureBoxHistograma.Image?.Dispose();
            pictureBoxHistograma.Image = bmpHist;
        }

        private void BTN_FiltroKirsch_Click(object sender, EventArgs e)
        {
            if (IMG_Original != null)
            {
                Bitmap original = new Bitmap(IMG_Original);
                Bitmap resultado = new Bitmap(original.Width, original.Height);

                // Kernels de Kirsch para las 8 direcciones
                int[][] kernels = new int[][]
                {
            new int[] {  5,  5,  5, -3,  0, -3, -3, -3, -3 }, // N
            new int[] {  5,  5, -3,  5,  0, -3, -3, -3, -3 }, // NE
            new int[] {  5, -3, -3,  5,  0, -3,  5, -3, -3 }, // E
            new int[] { -3, -3, -3,  5,  0, -3,  5,  5, -3 }, // SE
            new int[] { -3, -3, -3, -3,  0, -3,  5,  5,  5 }, // S
            new int[] { -3, -3, -3, -3,  0,  5, -3,  5,  5 }, // SO
            new int[] { -3, -3,  5, -3,  0,  5, -3, -3,  5 }, // O
            new int[] { -3,  5,  5, -3,  0,  5, -3, -3, -3 }, // NO
                };

                for (int y = 1; y < original.Height - 1; y++)
                {
                    for (int x = 1; x < original.Width - 1; x++)
                    {
                        int maxVal = 0;

                        foreach (var kernel in kernels)
                        {
                            int val = 0;
                            int k = 0;

                            for (int j = -1; j <= 1; j++)
                            {
                                for (int i = -1; i <= 1; i++)
                                {
                                    Color pixel = original.GetPixel(x + i, y + j);
                                    int gray = (pixel.R + pixel.G + pixel.B) / 3;
                                    val += gray * kernel[k++];
                                }
                            }

                            maxVal = Math.Max(maxVal, Math.Min(255, Math.Abs(val)));
                        }

                        resultado.SetPixel(x, y, Color.FromArgb(maxVal, maxVal, maxVal));
                    }
                }

                pictureBoxFiltro.Image = resultado;
                DibujarHistograma((Bitmap)pictureBoxFiltro.Image);
            }
        }
    }
}
