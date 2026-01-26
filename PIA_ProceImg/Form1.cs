namespace PIA_ProceImg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void modoImagenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var pantalla = new IMG();
            pantalla.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void modoVideoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var pantalla = new VIDEO();
            pantalla.Show();
        }

        private void modoDetectorDeRostroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var pantalla = new ROSTRO();
            pantalla.Show();
        }

        private void BTN_SALIR_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
