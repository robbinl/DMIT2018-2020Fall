using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.SamplePages
{
    public partial class PL01_DDL_Artists : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected void LB_FetchArtistInfo_Click(object sender, EventArgs e)
        {
            //if (DLL_Artists.SelectedIndex == 0)
            //    MessageLabel.Text = "Please Select an artist";
            //if (DLL_Artists.SelectedValue == 0)
            //    MessageLabel.Text = "Please Select an artist";
            //else
            {
                var selectedindex = DLL_Artists.SelectedIndex;
                var selectedvalue = DLL_Artists.SelectedValue;
                var selecteditem = DLL_Artists.SelectedItem;
                MessageLabel.Text = $"Selected Index: {selectedindex} " +
                                     $"Selected Value: {selectedvalue} " +
                                     $"Selected Item: {selecteditem}";
            }
        }
    }
}