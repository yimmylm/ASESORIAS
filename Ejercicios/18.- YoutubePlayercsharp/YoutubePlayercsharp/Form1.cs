using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YoutubePlayercsharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var json = new WebClient().DownloadString("https://www.googleapis.com/youtube/v3/search?order=date&part=snippet&channelId=UCne4X8czEkhh8GPRjXBIQJw&maxResults=25&key=AIzaSyADavf_BB9pkn2rrEv7kQZRLXDU5D5QK8A");
            
            ApiYoutube obj = JsonConvert.DeserializeObject<ApiYoutube>(json);

            int total = ((ICollection)obj.items).Count;
            
            PlayerYoutube.Url = new System.Uri("https://www.youtube.com/embed/" + obj.items[0].id.videoId, System.UriKind.Absolute);


            for (int i = 0; i < total; i++)
            {

                dtgListaVideos.Rows.Add(obj.items[i].id.videoId,GetImageFromUrl(obj.items[i].snippet.thumbnails.medium.url), obj.items[i].snippet.title);

            }


        }
        public static Image GetImageFromUrl(string url)
        {
            HttpWebRequest httpWebRequest = (HttpWebRequest)HttpWebRequest.Create(url);
            using (HttpWebResponse httpWebReponse = (HttpWebResponse)httpWebRequest.GetResponse())
            {
                using (Stream stream = httpWebReponse.GetResponseStream())
                {
                    return Image.FromStream(stream);
                }
            }
        }

        private void dtgListaVideos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int indexVideo = e.RowIndex;
            PlayerYoutube.Url = new System.Uri("https://www.youtube.com/embed/" + dtgListaVideos.Rows[e.RowIndex].Cells[0].Value.ToString() + "?autoplay=1", System.UriKind.Absolute);
        }

    }
}
