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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ClientID = txtClientID.Text;
            Properties.Settings.Default.ClientSecret = txtClientSecret.Text;
            Properties.Settings.Default.SignURL = txtURL.Text;
            Properties.Settings.Default.Save();
            this.Close();
        }


        private void Settings_Load(object sender, EventArgs e)
        {
            txtClientID.Text = Properties.Settings.Default.ClientID;
            txtClientSecret.Text = Properties.Settings.Default.ClientSecret;
            txtURL.Text =  Properties.Settings.Default.SignURL;
        }
    }
}
