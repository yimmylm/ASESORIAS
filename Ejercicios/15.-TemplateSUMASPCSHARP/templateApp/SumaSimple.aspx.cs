using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace templateApp
{
    public partial class SumaSimple : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            txtresultado.Text =Convert.ToString( Convert.ToInt32(txtvalor1.Text) + Convert.ToInt32(txtvalor2.Text));

        }
    }
}