namespace DKIMSign
{
    partial class frmMain
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDKIMFileUrl = new System.Windows.Forms.Label();
            this.lblDomain = new System.Windows.Forms.Label();
            this.lblSelector = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblBody = new System.Windows.Forms.Label();
            this.lblToMail = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.txtFileUrl = new System.Windows.Forms.TextBox();
            this.txtDomain = new System.Windows.Forms.TextBox();
            this.txtSelector = new System.Windows.Forms.TextBox();
            this.gbxMail = new System.Windows.Forms.GroupBox();
            this.txtBody = new System.Windows.Forms.TextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.gbxSmtp = new System.Windows.Forms.GroupBox();
            this.rbNoAuthenticate = new System.Windows.Forms.RadioButton();
            this.rbAuthenticate = new System.Windows.Forms.RadioButton();
            this.cbxEnableSSL = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAuthenticate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSmtpPort = new System.Windows.Forms.TextBox();
            this.txtSmtpPwd = new System.Windows.Forms.TextBox();
            this.txtSmtpUid = new System.Windows.Forms.TextBox();
            this.txtSmtpServer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEncoding = new System.Windows.Forms.Label();
            this.cbxEncodingConstraint = new System.Windows.Forms.ComboBox();
            this.gbxMail.SuspendLayout();
            this.gbxSmtp.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDKIMFileUrl
            // 
            this.lblDKIMFileUrl.AutoSize = true;
            this.lblDKIMFileUrl.Location = new System.Drawing.Point(12, 15);
            this.lblDKIMFileUrl.Name = "lblDKIMFileUrl";
            this.lblDKIMFileUrl.Size = new System.Drawing.Size(66, 12);
            this.lblDKIMFileUrl.TabIndex = 0;
            this.lblDKIMFileUrl.Text = "PEM File Url";
            // 
            // lblDomain
            // 
            this.lblDomain.AutoSize = true;
            this.lblDomain.Location = new System.Drawing.Point(36, 43);
            this.lblDomain.Name = "lblDomain";
            this.lblDomain.Size = new System.Drawing.Size(42, 12);
            this.lblDomain.TabIndex = 1;
            this.lblDomain.Text = "Domain";
            // 
            // lblSelector
            // 
            this.lblSelector.AutoSize = true;
            this.lblSelector.Location = new System.Drawing.Point(36, 71);
            this.lblSelector.Name = "lblSelector";
            this.lblSelector.Size = new System.Drawing.Size(42, 12);
            this.lblSelector.TabIndex = 2;
            this.lblSelector.Text = "Selector";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(27, 80);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(39, 12);
            this.lblSubject.TabIndex = 3;
            this.lblSubject.Text = "Subject";
            // 
            // lblBody
            // 
            this.lblBody.AutoSize = true;
            this.lblBody.Location = new System.Drawing.Point(35, 108);
            this.lblBody.Name = "lblBody";
            this.lblBody.Size = new System.Drawing.Size(31, 12);
            this.lblBody.TabIndex = 4;
            this.lblBody.Text = "Body";
            // 
            // lblToMail
            // 
            this.lblToMail.AutoSize = true;
            this.lblToMail.Location = new System.Drawing.Point(48, 52);
            this.lblToMail.Name = "lblToMail";
            this.lblToMail.Size = new System.Drawing.Size(18, 12);
            this.lblToMail.TabIndex = 5;
            this.lblToMail.Text = "To";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(36, 24);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(30, 12);
            this.lblFrom.TabIndex = 6;
            this.lblFrom.Text = "From";
            // 
            // txtFileUrl
            // 
            this.txtFileUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFileUrl.Location = new System.Drawing.Point(84, 12);
            this.txtFileUrl.Name = "txtFileUrl";
            this.txtFileUrl.Size = new System.Drawing.Size(458, 22);
            this.txtFileUrl.TabIndex = 7;
            // 
            // txtDomain
            // 
            this.txtDomain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDomain.Location = new System.Drawing.Point(84, 40);
            this.txtDomain.Name = "txtDomain";
            this.txtDomain.Size = new System.Drawing.Size(458, 22);
            this.txtDomain.TabIndex = 7;
            // 
            // txtSelector
            // 
            this.txtSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSelector.Location = new System.Drawing.Point(84, 68);
            this.txtSelector.Name = "txtSelector";
            this.txtSelector.Size = new System.Drawing.Size(458, 22);
            this.txtSelector.TabIndex = 7;
            // 
            // gbxMail
            // 
            this.gbxMail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxMail.Controls.Add(this.txtBody);
            this.gbxMail.Controls.Add(this.txtSubject);
            this.gbxMail.Controls.Add(this.txtTo);
            this.gbxMail.Controls.Add(this.txtFrom);
            this.gbxMail.Controls.Add(this.lblFrom);
            this.gbxMail.Controls.Add(this.lblSubject);
            this.gbxMail.Controls.Add(this.lblBody);
            this.gbxMail.Controls.Add(this.lblToMail);
            this.gbxMail.Location = new System.Drawing.Point(12, 229);
            this.gbxMail.Name = "gbxMail";
            this.gbxMail.Size = new System.Drawing.Size(530, 301);
            this.gbxMail.TabIndex = 8;
            this.gbxMail.TabStop = false;
            this.gbxMail.Text = "Mail";
            // 
            // txtBody
            // 
            this.txtBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBody.Location = new System.Drawing.Point(72, 105);
            this.txtBody.Multiline = true;
            this.txtBody.Name = "txtBody";
            this.txtBody.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBody.Size = new System.Drawing.Size(452, 190);
            this.txtBody.TabIndex = 7;
            // 
            // txtSubject
            // 
            this.txtSubject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSubject.Location = new System.Drawing.Point(72, 77);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(452, 22);
            this.txtSubject.TabIndex = 7;
            // 
            // txtTo
            // 
            this.txtTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTo.Location = new System.Drawing.Point(72, 49);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(452, 22);
            this.txtTo.TabIndex = 7;
            // 
            // txtFrom
            // 
            this.txtFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFrom.Location = new System.Drawing.Point(72, 21);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(452, 22);
            this.txtFrom.TabIndex = 7;
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Location = new System.Drawing.Point(461, 536);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 9;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // gbxSmtp
            // 
            this.gbxSmtp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxSmtp.Controls.Add(this.rbNoAuthenticate);
            this.gbxSmtp.Controls.Add(this.rbAuthenticate);
            this.gbxSmtp.Controls.Add(this.cbxEnableSSL);
            this.gbxSmtp.Controls.Add(this.label3);
            this.gbxSmtp.Controls.Add(this.lblAuthenticate);
            this.gbxSmtp.Controls.Add(this.label2);
            this.gbxSmtp.Controls.Add(this.label5);
            this.gbxSmtp.Controls.Add(this.txtSmtpPort);
            this.gbxSmtp.Controls.Add(this.txtSmtpPwd);
            this.gbxSmtp.Controls.Add(this.txtSmtpUid);
            this.gbxSmtp.Controls.Add(this.txtSmtpServer);
            this.gbxSmtp.Controls.Add(this.label4);
            this.gbxSmtp.Controls.Add(this.label1);
            this.gbxSmtp.Location = new System.Drawing.Point(12, 121);
            this.gbxSmtp.Name = "gbxSmtp";
            this.gbxSmtp.Size = new System.Drawing.Size(530, 102);
            this.gbxSmtp.TabIndex = 10;
            this.gbxSmtp.TabStop = false;
            this.gbxSmtp.Text = "Smtp";
            // 
            // rbNoAuthenticate
            // 
            this.rbNoAuthenticate.AutoSize = true;
            this.rbNoAuthenticate.Location = new System.Drawing.Point(159, 49);
            this.rbNoAuthenticate.Name = "rbNoAuthenticate";
            this.rbNoAuthenticate.Size = new System.Drawing.Size(98, 16);
            this.rbNoAuthenticate.TabIndex = 9;
            this.rbNoAuthenticate.Text = "No Authenticate";
            this.rbNoAuthenticate.UseVisualStyleBackColor = true;
            this.rbNoAuthenticate.CheckedChanged += new System.EventHandler(this.rbNoAuthenticate_CheckedChanged);
            // 
            // rbAuthenticate
            // 
            this.rbAuthenticate.AutoSize = true;
            this.rbAuthenticate.Checked = true;
            this.rbAuthenticate.Location = new System.Drawing.Point(72, 49);
            this.rbAuthenticate.Name = "rbAuthenticate";
            this.rbAuthenticate.Size = new System.Drawing.Size(81, 16);
            this.rbAuthenticate.TabIndex = 9;
            this.rbAuthenticate.TabStop = true;
            this.rbAuthenticate.Text = "Authenticate";
            this.rbAuthenticate.UseVisualStyleBackColor = true;
            this.rbAuthenticate.CheckedChanged += new System.EventHandler(this.rbAuthenticate_CheckedChanged);
            // 
            // cbxEnableSSL
            // 
            this.cbxEnableSSL.FormattingEnabled = true;
            this.cbxEnableSSL.Items.AddRange(new object[] {
            "true",
            "false"});
            this.cbxEnableSSL.Location = new System.Drawing.Point(351, 21);
            this.cbxEnableSSL.Name = "cbxEnableSSL";
            this.cbxEnableSSL.Size = new System.Drawing.Size(60, 20);
            this.cbxEnableSSL.TabIndex = 8;
            this.cbxEnableSSL.Text = "true";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(286, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "Smtp Pwd";
            // 
            // lblAuthenticate
            // 
            this.lblAuthenticate.AutoSize = true;
            this.lblAuthenticate.Location = new System.Drawing.Point(6, 51);
            this.lblAuthenticate.Name = "lblAuthenticate";
            this.lblAuthenticate.Size = new System.Drawing.Size(63, 12);
            this.lblAuthenticate.TabIndex = 6;
            this.lblAuthenticate.Text = "Authenticate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "Smtp Uid";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(286, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "Enable SSL";
            // 
            // txtSmtpPort
            // 
            this.txtSmtpPort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSmtpPort.Location = new System.Drawing.Point(474, 21);
            this.txtSmtpPort.Name = "txtSmtpPort";
            this.txtSmtpPort.Size = new System.Drawing.Size(50, 22);
            this.txtSmtpPort.TabIndex = 7;
            this.txtSmtpPort.Text = "587";
            // 
            // txtSmtpPwd
            // 
            this.txtSmtpPwd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSmtpPwd.Location = new System.Drawing.Point(344, 71);
            this.txtSmtpPwd.Name = "txtSmtpPwd";
            this.txtSmtpPwd.Size = new System.Drawing.Size(180, 22);
            this.txtSmtpPwd.TabIndex = 7;
            // 
            // txtSmtpUid
            // 
            this.txtSmtpUid.Location = new System.Drawing.Point(72, 71);
            this.txtSmtpUid.Name = "txtSmtpUid";
            this.txtSmtpUid.Size = new System.Drawing.Size(208, 22);
            this.txtSmtpUid.TabIndex = 7;
            // 
            // txtSmtpServer
            // 
            this.txtSmtpServer.Location = new System.Drawing.Point(72, 21);
            this.txtSmtpServer.Name = "txtSmtpServer";
            this.txtSmtpServer.Size = new System.Drawing.Size(208, 22);
            this.txtSmtpServer.TabIndex = 7;
            this.txtSmtpServer.Text = "smtp.office365.com";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(417, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "Smtp Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "Smtp Server";
            // 
            // lblEncoding
            // 
            this.lblEncoding.AutoSize = true;
            this.lblEncoding.Location = new System.Drawing.Point(28, 98);
            this.lblEncoding.Name = "lblEncoding";
            this.lblEncoding.Size = new System.Drawing.Size(50, 12);
            this.lblEncoding.TabIndex = 11;
            this.lblEncoding.Text = "Encoding";
            // 
            // cbxEncodingConstraint
            // 
            this.cbxEncodingConstraint.FormattingEnabled = true;
            this.cbxEncodingConstraint.Items.AddRange(new object[] {
            "None",
            "SevenBit",
            "EightBit"});
            this.cbxEncodingConstraint.Location = new System.Drawing.Point(84, 95);
            this.cbxEncodingConstraint.Name = "cbxEncodingConstraint";
            this.cbxEncodingConstraint.Size = new System.Drawing.Size(121, 20);
            this.cbxEncodingConstraint.TabIndex = 12;
            this.cbxEncodingConstraint.Text = "EightBit";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 571);
            this.Controls.Add(this.cbxEncodingConstraint);
            this.Controls.Add(this.lblEncoding);
            this.Controls.Add(this.gbxSmtp);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.gbxMail);
            this.Controls.Add(this.txtSelector);
            this.Controls.Add(this.txtDomain);
            this.Controls.Add(this.txtFileUrl);
            this.Controls.Add(this.lblSelector);
            this.Controls.Add(this.lblDomain);
            this.Controls.Add(this.lblDKIMFileUrl);
            this.Name = "frmMain";
            this.Text = "DKIMSign";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.gbxMail.ResumeLayout(false);
            this.gbxMail.PerformLayout();
            this.gbxSmtp.ResumeLayout(false);
            this.gbxSmtp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDKIMFileUrl;
        private System.Windows.Forms.Label lblDomain;
        private System.Windows.Forms.Label lblSelector;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblBody;
        private System.Windows.Forms.Label lblToMail;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.TextBox txtFileUrl;
        private System.Windows.Forms.TextBox txtDomain;
        private System.Windows.Forms.TextBox txtSelector;
        private System.Windows.Forms.GroupBox gbxMail;
        private System.Windows.Forms.TextBox txtBody;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.GroupBox gbxSmtp;
        private System.Windows.Forms.ComboBox cbxEnableSSL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSmtpPort;
        private System.Windows.Forms.TextBox txtSmtpPwd;
        private System.Windows.Forms.TextBox txtSmtpUid;
        private System.Windows.Forms.TextBox txtSmtpServer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbAuthenticate;
        private System.Windows.Forms.Label lblAuthenticate;
        private System.Windows.Forms.RadioButton rbNoAuthenticate;
        private System.Windows.Forms.Label lblEncoding;
        private System.Windows.Forms.ComboBox cbxEncodingConstraint;
    }
}

