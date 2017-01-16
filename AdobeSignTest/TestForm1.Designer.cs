namespace AdobeSignTest
{
    partial class TestForm1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAccessToken = new System.Windows.Forms.Label();
            this.txtAccessToken = new System.Windows.Forms.TextBox();
            this.btnGetAccessToken = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnLoadAgreements = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblurl = new System.Windows.Forms.Label();
            this.txtApiURL = new System.Windows.Forms.TextBox();
            this.btnSettings = new System.Windows.Forms.Button();
            this.pnlLoading = new System.Windows.Forms.Panel();
            this.lblLoadingMessage = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnOpenDocument = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.pnlLoading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAccessToken
            // 
            this.lblAccessToken.AutoSize = true;
            this.lblAccessToken.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccessToken.Location = new System.Drawing.Point(17, 40);
            this.lblAccessToken.Name = "lblAccessToken";
            this.lblAccessToken.Size = new System.Drawing.Size(95, 16);
            this.lblAccessToken.TabIndex = 1;
            this.lblAccessToken.Text = "Access Token";
            // 
            // txtAccessToken
            // 
            this.txtAccessToken.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAccessToken.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccessToken.Location = new System.Drawing.Point(118, 40);
            this.txtAccessToken.Name = "txtAccessToken";
            this.txtAccessToken.Size = new System.Drawing.Size(756, 22);
            this.txtAccessToken.TabIndex = 2;
            // 
            // btnGetAccessToken
            // 
            this.btnGetAccessToken.Location = new System.Drawing.Point(799, 12);
            this.btnGetAccessToken.Name = "btnGetAccessToken";
            this.btnGetAccessToken.Size = new System.Drawing.Size(75, 23);
            this.btnGetAccessToken.TabIndex = 3;
            this.btnGetAccessToken.Text = "Get Token";
            this.btnGetAccessToken.UseVisualStyleBackColor = true;
            this.btnGetAccessToken.Click += new System.EventHandler(this.btnGetAccessToken_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(18, 183);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(381, 277);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedValueChanged += new System.EventHandler(this.listBox1_SelectedValueChanged);
            // 
            // btnLoadAgreements
            // 
            this.btnLoadAgreements.Location = new System.Drawing.Point(18, 154);
            this.btnLoadAgreements.Name = "btnLoadAgreements";
            this.btnLoadAgreements.Size = new System.Drawing.Size(106, 23);
            this.btnLoadAgreements.TabIndex = 5;
            this.btnLoadAgreements.Text = "Get Agreements";
            this.btnLoadAgreements.UseVisualStyleBackColor = true;
            this.btnLoadAgreements.Click += new System.EventHandler(this.btnLoadAgreements_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lblurl);
            this.groupBox1.Controls.Add(this.txtApiURL);
            this.groupBox1.Controls.Add(this.lblAccessToken);
            this.groupBox1.Controls.Add(this.txtAccessToken);
            this.groupBox1.Controls.Add(this.btnGetAccessToken);
            this.groupBox1.Location = new System.Drawing.Point(12, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(887, 107);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Access-Token";
            // 
            // lblurl
            // 
            this.lblurl.AutoSize = true;
            this.lblurl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblurl.Location = new System.Drawing.Point(17, 71);
            this.lblurl.Name = "lblurl";
            this.lblurl.Size = new System.Drawing.Size(49, 16);
            this.lblurl.TabIndex = 4;
            this.lblurl.Text = "API Url";
            // 
            // txtApiURL
            // 
            this.txtApiURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtApiURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApiURL.Location = new System.Drawing.Point(118, 68);
            this.txtApiURL.Name = "txtApiURL";
            this.txtApiURL.Size = new System.Drawing.Size(756, 22);
            this.txtApiURL.TabIndex = 5;
            this.txtApiURL.Text = "https://api.eu1.echosign.com/api/rest/v5/";
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(12, 4);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(75, 23);
            this.btnSettings.TabIndex = 7;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // pnlLoading
            // 
            this.pnlLoading.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLoading.Controls.Add(this.lblLoadingMessage);
            this.pnlLoading.Controls.Add(this.pictureBox1);
            this.pnlLoading.Location = new System.Drawing.Point(700, 0);
            this.pnlLoading.Name = "pnlLoading";
            this.pnlLoading.Size = new System.Drawing.Size(200, 41);
            this.pnlLoading.TabIndex = 8;
            this.pnlLoading.Visible = false;
            // 
            // lblLoadingMessage
            // 
            this.lblLoadingMessage.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblLoadingMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoadingMessage.ForeColor = System.Drawing.Color.Blue;
            this.lblLoadingMessage.Location = new System.Drawing.Point(9, 0);
            this.lblLoadingMessage.Name = "lblLoadingMessage";
            this.lblLoadingMessage.Size = new System.Drawing.Size(144, 41);
            this.lblLoadingMessage.TabIndex = 3;
            this.lblLoadingMessage.Text = "Loading...";
            this.lblLoadingMessage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::AdobeSignTest.Properties.Resources.loading_small;
            this.pictureBox1.Location = new System.Drawing.Point(153, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(438, 183);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(461, 171);
            this.dataGridView1.TabIndex = 9;
            // 
            // btnOpenDocument
            // 
            this.btnOpenDocument.Location = new System.Drawing.Point(794, 372);
            this.btnOpenDocument.Name = "btnOpenDocument";
            this.btnOpenDocument.Size = new System.Drawing.Size(106, 23);
            this.btnOpenDocument.TabIndex = 10;
            this.btnOpenDocument.Text = "Get Document";
            this.btnOpenDocument.UseVisualStyleBackColor = true;
            this.btnOpenDocument.Click += new System.EventHandler(this.btnOpenDocument_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(427, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Add Document";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(427, 421);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "send Document";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(550, 421);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "send Document";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // TestForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 472);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnOpenDocument);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pnlLoading);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLoadAgreements);
            this.Controls.Add(this.listBox1);
            this.Name = "TestForm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdobeSign Test Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlLoading.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAccessToken;
        private System.Windows.Forms.TextBox txtAccessToken;
        private System.Windows.Forms.Button btnGetAccessToken;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnLoadAgreements;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblurl;
        private System.Windows.Forms.TextBox txtApiURL;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Panel pnlLoading;
        private System.Windows.Forms.Label lblLoadingMessage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnOpenDocument;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

