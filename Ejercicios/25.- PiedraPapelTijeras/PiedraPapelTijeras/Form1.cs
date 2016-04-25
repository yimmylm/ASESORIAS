using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiedraPapelTijeras
{
    public partial class Form1 : Form
    {
        int PosicionOriginalPlayer1, PosicionOriginalPlayer2;
        int movimientosManos, TiempoSeleccion, TiempoTotalJuego = 0;
        bool MovimientoArriba; String GaneActual = "empate";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PosicionOriginalPlayer1 = pictureBox1.Location.Y;
            PosicionOriginalPlayer2 = pictureBox2.Location.Y;
            timer3.Enabled = true;
            timer3.Start();
            IniciarJuego();
            Sonido("readygo");

        }
        public void IniciarJuego() {
            MovimientoArriba = false;
            movimientosManos = 0;
            TiempoSeleccion = 150;
            GaneActual = "empate";

            timer1.Enabled = true;
            timer2.Enabled = true;
            timer1.Start();
            timer2.Start();
        }

        public void Sonido(String NombreSonido) {
            var sonido = (Stream)Properties.Resources.ResourceManager.GetObject(NombreSonido);
            SoundPlayer SonidoCargado = new SoundPlayer(sonido);
            SonidoCargado.Play();

        
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int posicion = pictureBox1.Location.Y;
            int velocidadMovimiento = 30;

            if ((posicion < 281) && (MovimientoArriba == false))
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + velocidadMovimiento);
                pictureBox2.Location = new Point(pictureBox2.Location.X, pictureBox2.Location.Y - velocidadMovimiento);
                if (posicion == 263) { MovimientoArriba = true; }

            }
            if ((posicion > 59) && (MovimientoArriba == true))
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y-velocidadMovimiento);
                pictureBox2.Location = new Point(pictureBox2.Location.X, pictureBox2.Location.Y+velocidadMovimiento);
                if (posicion == 83) { MovimientoArriba = false; movimientosManos++;}

            }
            if(movimientosManos==2){
                timer1.Stop();
                pictureBox1.Location = new Point(pictureBox1.Location.X, PosicionOriginalPlayer1);
                pictureBox2.Location = new Point(pictureBox2.Location.X, PosicionOriginalPlayer2);

                Random rnd = new Random();
                int player1 = rnd.Next(1, 4);
                int player2 = rnd.Next(1, 4);

                pictureBox1.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(player1.ToString());
                pictureBox2.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(player2 + "_d");
                timer2.Start();
                rojo.Enabled = true; azul.Enabled = true; empate.Enabled = true;

                //1.- Tijera
                //2.- Piedra
                //3.- Papel

                if (((player1 == 1) && (player2 == 2)) || ((player1 == 2) && (player2 == 3)) || ((player1 == 3) && (player2 == 1)))
                {
                    GaneActual = "azul";
                }
                if (((player1 == 1) && (player2 == 3)) || ((player1 == 2) && (player2 == 1)) || ((player1 == 3) && (player2 == 2)))
                {
                    GaneActual = "rojo";
                }


            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            TiempoSeleccion--;
            lblTiempo.Text = TiempoSeleccion.ToString() + " ms";
            if(TiempoSeleccion<=0){
                timer2.Stop();
                IniciarJuego();
                Sonido("timeover");
            }

        }

        private void Verificar(object sender, EventArgs e)
        {
            String Presionado = ((PictureBox)sender).Name;
            if ((Presionado == GaneActual) && (TiempoSeleccion > 0)) {
                lblPuntos.Text = (Convert.ToInt32(lblPuntos.Text) + 1).ToString();
                timer2.Stop();
                IniciarJuego();
                Sonido("Punto");
            }
            else {

                timer2.Stop();
                IniciarJuego();
                Sonido("error");
            }
            rojo.Enabled = false; azul.Enabled = false; empate.Enabled = false;

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (TiempoTotalJuego == (1000 * 1)) {

                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
                Sonido("gameover");
                DialogResult result = MessageBox.Show("Tiempo agotado - Puntaje Final:" + lblPuntos.Text, "Tiempo agotado", MessageBoxButtons.OK);
                if (result == DialogResult.OK) {

                    lblPuntos.Text = "0";
                    timer3.Enabled = true;
                    timer3.Start();
                    IniciarJuego();
                    Sonido("readygo");
                
                }
            }
            TiempoTotalJuego++;
        }
    }
}
