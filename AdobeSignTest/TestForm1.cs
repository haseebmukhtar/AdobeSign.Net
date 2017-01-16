using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdobeSignNet.AdobeSign;
using System.IO;

namespace AdobeSignTest
{
    public partial class TestForm1 : Form
    {
        public TestForm1()
        {
            InitializeComponent();
        }

        private async void btnLoadAgreements_Click(object sender, EventArgs e)
        {
            lblLoadingMessage.Text = "Loading agreements...";
            pnlLoading.Visible = true;
            await ShowAgreements();
            pnlLoading.Visible = false;
        }

        private async Task ShowAgreements()
        {
            try
            {
                AdobeSignNet.RestAPI api = new AdobeSignNet.RestAPI(txtApiURL.Text, txtAccessToken.Text);
                AdobeSignNet.AdobeObject obj = new AdobeSignNet.AdobeObject(api);

                var agreements = await obj.GetAgreements();
                listBox1.Items.Clear();
                this.listBox1.DisplayMember = "name";
                this.listBox1.ValueMember = "agreementId";

                foreach (var agreement in agreements.userAgreementList)
                {
                    listBox1.Items.Add(agreement);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void btnGetAccessToken_Click(object sender, EventArgs e)
        {
            try
            {
                await GetAccessToken();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async Task GetAccessToken()
        {
            try
            {

                string url = "https://secure.eu1.echosign.com/";
                string endpoint = "public/oauth?";
                var redirectURL = "https://www.dpssoftware.co.uk/adobesign";

                string parameters = "";

                parameters += "redirect_uri=" + redirectURL + "&";
                parameters += "response_type=code&";
                parameters += "client_id=CBJCHBCAABAAK7dSUTraPUCoAR5GruU_K9_lamBHWbLO&";
                //parameters += "scope=user_login:self + agreement_send:account";
                parameters += "scope=agreement_send+agreement_read+agreement_write";


                string fullurl = url + endpoint + parameters;

                frmAuthorize authForm = new AdobeSignTest.frmAuthorize(fullurl, redirectURL);
                var dr = authForm.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    string authCode = authForm.code;
                    string tokenURL = authForm.apiurl.Replace("%3A", ":").Replace("%2F", "/");
                    string apiURL = tokenURL.TrimEnd('/') + "/api/rest/v5/";

                    //string apiurl = "https://api.eu1.echosign.com/";

                    string clientid = Properties.Settings.Default.ClientID;
                    string clientsecret = Properties.Settings.Default.ClientSecret;

                    var accessTokenObj = await AdobeSignNet.AdobeObject.GetAccessToken(tokenURL, authCode, clientid, clientsecret, redirectURL);
                    txtAccessToken.Text = accessTokenObj.access_token;
                    txtApiURL.Text = apiURL;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            using (Settings frmSettings = new AdobeSignTest.Settings())
            {
                frmSettings.ShowDialog();
            }
        }

        private async void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                var selectedAgreement = (AdobeSignNet.AdobeSign.UserAgreement)listBox1.SelectedItem;
                await ShowSelectedAgreement(selectedAgreement);
                int hm = 0;
            }
        }

        async Task ShowSelectedAgreement(AdobeSignNet.AdobeSign.UserAgreement selectedAgreement)
        {
            try
            {
                AdobeSignNet.RestAPI api = new AdobeSignNet.RestAPI(txtApiURL.Text, txtAccessToken.Text);
                AdobeSignNet.AdobeObject obj = new AdobeSignNet.AdobeObject(api);
                var agreement = await obj.GetAgreement(selectedAgreement.agreementId);
                dataGridView1.DataSource = agreement.events;
                int hm = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void btnOpenDocument_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                var selectedAgreement = (AdobeSignNet.AdobeSign.UserAgreement)listBox1.SelectedItem;
                await OpenSelectedDocument(selectedAgreement);
                int hm = 0;
            }
        }

        private async Task OpenSelectedDocument(UserAgreement selectedAgreement)
        {

            try
            {
                AdobeSignNet.RestAPI api = new AdobeSignNet.RestAPI(txtApiURL.Text, txtAccessToken.Text);
                AdobeSignNet.AdobeObject obj = new AdobeSignNet.AdobeObject(api);
                var docBytes = await obj.GetAgreementCombinedDocument(selectedAgreement.agreementId);

                string filename = "C:\\Temp\\abodetest1" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".pdf";
                System.IO.File.WriteAllBytes(filename, docBytes);

                System.Diagnostics.Process excel = new System.Diagnostics.Process();
                excel.StartInfo.Arguments = "\"" + filename + "\" /e";
                excel.StartInfo.FileName = filename;// pathToExcel;
                excel.Start();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                AdobeSignNet.RestAPI api = new AdobeSignNet.RestAPI(txtApiURL.Text, txtAccessToken.Text);
                AdobeSignNet.AdobeObject obj = new AdobeSignNet.AdobeObject(api);

                //var fileData = File.ReadAllBytes(@"C:\Temp\123456.pdf");
                var fileData = File.ReadAllBytes(@"C:\Temp\sam.docx");

                var upload123 = await obj.AddDocument("1234", fileData);


                //AdobeSignNet.AdobeSign.AgreementCreationInfo creationInfo = CreateDoc();



                //var creationResponse = await obj.CreateAgreement(creationInfo);

                int hm = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }






        AdobeSignNet.AdobeSign.AgreementCreationInfo CreateDoc()
        {
            string documentID = "3AAABLblqZhAcpNUiA54C4Uy0ueY3dThrjGKOeNHQb5UcHyU2KjmBoCMpDBlx3vl3etTU_HPfJkef39JORxf-7aTDUK4EerzUs7fxdrMjcic6mXjiREh2vjUBRv1pHHIcYQmnXXsSIMetKrvgFH14lFrQReftgrHpsAjBrnWK11U-ZQpHgo6C6FgrzOUQQ3ROoN0-hsPwbBLUp2n92oBYljzIwt0x7JvI5YEb2BIJyTjAbFPKLuQZdG0evFId4QgqrtNpZgozOZDhb-0M0fkrgEDAeJ2HVjaeQ-soY4Afw1HDmGsTjlximoKOG_epJk0XlQRFr2DRy-k*";
            string agreementName = "My Agreement 1";

            AdobeSignNet.AdobeSign.AgreementCreationInfo creationInfo = new AgreementCreationInfo();

            creationInfo.documentCreationInfo = new DocumentCreationInfo();
            var documentCreationInfo = creationInfo.documentCreationInfo;
            
            documentCreationInfo.name = agreementName;
            documentCreationInfo.signatureType = SignatureTypeEnum.ESIGN;
            documentCreationInfo.signatureFlow = "";

            documentCreationInfo.fileInfos = new List<AdobeSignNet.AdobeSign.FileInfo>();
            var fileInfos = documentCreationInfo.fileInfos;            
            AdobeSignNet.AdobeSign.FileInfo fileInfo = new AdobeSignNet.AdobeSign.FileInfo(documentID);
            fileInfos.Add(fileInfo);

            documentCreationInfo.recipientSetInfos = new List<RecipientSetInfo>();
            var recipientSetInfos = documentCreationInfo.recipientSetInfos;            

            RecipientSetInfo recipientSetInfo = new RecipientSetInfo();
            recipientSetInfo.recipientSetRole = RecipientRoleEnum.SIGNER;
            recipientSetInfo.signingOrder = 1;

            RecipientSetMemberInfo setMemberInfo = new RecipientSetMemberInfo();
            setMemberInfo.email = "haseebmukhtar@hotmail.com";            

            recipientSetInfo.recipientSetMemberInfos.Add(setMemberInfo);

            recipientSetInfos.Add(recipientSetInfo);

          



            return creationInfo;
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            try
            {
                AdobeSignNet.RestAPI api = new AdobeSignNet.RestAPI(txtApiURL.Text, txtAccessToken.Text);
                AdobeSignNet.AdobeObject obj = new AdobeSignNet.AdobeObject(api);

                var agreement = CreateDoc();

                var upload123 = await obj.CreateAgreement(agreement);

                int hm = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            string apiURL = txtApiURL.Text;
            string accessToken = txtAccessToken.Text;


            Agreement agreement = new AdobeSignTest.Agreement();
            var ag = await agreement.SendDocument(apiURL, accessToken, @"C:\Temp\1.docx", "testagreement1", "haseebmukhtar@hotmail.com");

            MessageBox.Show("sent.");
        }
    }



    public enum SignatureFlow
    {

        /// <remarks/>
        SENDER_SIGNS_LAST,

        /// <remarks/>
        SENDER_SIGNS_FIRST,

        /// <remarks/>
        SENDER_SIGNATURE_NOT_REQUIRED,

        /// <remarks/>
        SENDER_SIGNS_ONLY,

        /// <remarks/>
        SEQUENTIAL,

        /// <remarks/>
        PARALLEL,
    }

  



}

