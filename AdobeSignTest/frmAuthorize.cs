using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdobeSignTest
{
    public partial class frmAuthorize : Form
    {
        public string code = "";
        public string apiurl = "";
        public string weburl = "";

        string FullURL = "";
        string RedirectURL = "";


        public frmAuthorize(string fullurl, string redirectURL)
        {
            InitializeComponent();
            FullURL = fullurl;
            RedirectURL = redirectURL;
        }

      

        private void frmAuthorize_Load(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri(FullURL);
            lblLoadingMessage.Text = "";
            pnlLoading.Visible = true;
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            pnlLoading.Visible = false;

            if (webBrowser1.Url.AbsoluteUri.StartsWith(RedirectURL))
            {
                string query = webBrowser1.Url.Query.Trim(new char[] { '?' });
                string[] para = query.Split(new string[] { "&" }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var parameter in para)
                {
                    if (parameter.StartsWith("code="))
                    {
                        code = parameter.Substring(5);
                    }
                    else if (parameter.StartsWith("api_access_point="))
                    {
                        apiurl = parameter.Substring(17);
                    }
                    else if (parameter.StartsWith("web_access_point="))
                    {
                        weburl = parameter.Substring(17);
                    }
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

    }
}
