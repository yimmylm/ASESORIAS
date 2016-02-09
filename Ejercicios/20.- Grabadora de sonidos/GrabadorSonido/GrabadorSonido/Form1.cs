using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrabadorSonido
{
    public partial class Form1 : Form
    {
        SoundPlayer ReproductoWav;
        public Form1()
        {
            InitializeComponent();
            ReproductoWav= new SoundPlayer();
        }

         [DllImport("winmm.dll", EntryPoint = "mciSendStringA", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]
         private static extern int Grabar(string Comando, string StringRetono, int Longitud, int hwndCallback);
        private void btnGrabar_Click(object sender, EventArgs e)
        {
            Grabar("open new Type waveaudio Alias recsound", "", 0, 0);
            Grabar("record recsound", "", 0, 0);

            btnGrabar.Image = Properties.Resources.Recordoff;
            Micro.Image = Properties.Resources.Micro;
            btnParar.Image = Properties.Resources.Stop;
            btnReproducir.Image = Properties.Resources.playoff;
            UrlReproductor.Text = "";
            ReproductoWav.Stop();
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            Micro.Image = Properties.Resources.MicroOff;

            SaveFileDialog CajaDeDiaologoGuardar = new SaveFileDialog();
            CajaDeDiaologoGuardar.AddExtension = true;
            CajaDeDiaologoGuardar.FileName = "Audio.wav";
            CajaDeDiaologoGuardar.Filter = "Sonido (*.wav)|*.wav";
            CajaDeDiaologoGuardar.ShowDialog();
            if (!string.IsNullOrEmpty(CajaDeDiaologoGuardar.FileName))
            {
                UrlReproductor.Text = CajaDeDiaologoGuardar.FileName;

                btnParar.Image = Properties.Resources.Stopoff;
                btnGrabar.Image = Properties.Resources.Record;
                btnReproducir.Image = Properties.Resources.play;

                Grabar("save recsound " + CajaDeDiaologoGuardar.FileName, "", 0, 0);
                Grabar("close recsound", "", 0, 0);
                MessageBox.Show("Archivo Guardado en:"+CajaDeDiaologoGuardar.FileName);

            }
        }

        private void btnReproducir_Click(object sender, EventArgs e)
        {
            ReproductoWav.SoundLocation = UrlReproductor.Text;
            ReproductoWav.Play();

        }
    }
}
