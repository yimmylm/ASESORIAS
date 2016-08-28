using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaputarPantalla
{

    public partial class Form1 : Form
    {
        Point posicionVentana;
        bool mover = false;

        public Form1()
        {
            InitializeComponent();
            this.Opacity = 0.2;
            this.TransparencyKey = Color.Turquoise;
            this.ControlBox = false;
            this.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.C)) { CaputurarPantalla(); }
            if ((e.KeyCode == Keys.M)) { this.WindowState = FormWindowState.Minimized; }
            if ((e.KeyCode == Keys.L)) { this.WindowState = FormWindowState.Maximized; }
            if ((e.KeyCode == Keys.Escape)) { this.Close(); }

        }
        public void CaputurarPantalla() {
            try {
                Bitmap CapturaBitmap = new Bitmap(this.Width, this.Height, PixelFormat.Format32bppArgb);
                Rectangle capturaRectangulo = Screen.AllScreens[0].Bounds;
                Graphics CapturaGrafico = Graphics.FromImage(CapturaBitmap);
                CapturaGrafico.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, capturaRectangulo.Size);
                Clipboard.SetImage(CapturaBitmap);
                MessageBox.Show("Región capturada");
            
            }
            catch(Exception ex){
                MessageBox.Show(ex.Message);
            }
        
        
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            posicionVentana = new Point(Cursor.Position.X - Location.X, Cursor.Position.Y - Location.Y);
            mover = true;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mover = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if(mover){
                this.Location = new Point(Cursor.Position.X-posicionVentana.X,Cursor.Position.Y-posicionVentana.Y);
            }
        }

    }
}
