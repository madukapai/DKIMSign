using MimeKit.Cryptography;
using MimeKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit.Security;
using System.Net;
using Newtonsoft.Json;

namespace DKIMSign
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 寄送信件的動作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                MimeMessage objMail = new MimeMessage();
                objMail.From.Add(new MailboxAddress(txtFrom.Text, txtFrom.Text));

                objMail.To.Add(new MailboxAddress(txtTo.Text, txtTo.Text));

                var builder = new BodyBuilder();
                builder.TextBody = txtBody.Text;
                objMail.Body = builder.ToMessageBody();
                objMail.Subject = txtSubject.Text;

                // 下載PEM檔
                byte[] objByte = objByte = new WebClient().DownloadData(txtFileUrl.Text);
                Stream objDKIMPrivateKeyContent = new MemoryStream(objByte);

                // 在信中加入DKIM的簽章
                AddDkimSignature(ref objMail, txtDomain.Text, txtSelector.Text, objDKIMPrivateKeyContent);

                // 使用SMTP服務寄送電子郵件
                using (MailKit.Net.Smtp.SmtpClient objSmtp = new MailKit.Net.Smtp.SmtpClient())
                {
                    objSmtp.Connect(txtSmtpServer.Text, int.Parse(txtSmtpPort.Text), SecureSocketOptions.Auto);
                    
                    if (rbAuthenticate.Checked)
                        objSmtp.Authenticate(txtSmtpUid.Text, txtSmtpPwd.Text);

                    objSmtp.Send(objMail);
                    objSmtp.Disconnect(true);
                }
                MessageBox.Show("Success", "Send Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                string strMessage = ex.Message + JsonConvert.SerializeObject(ex.InnerException);
                MessageBox.Show(strMessage, "Send Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 在信中加入DKIM的簽章
        /// </summary>
        /// <param name="mail"></param>
        private void AddDkimSignature(ref MimeMessage mail, string strDomain, string strSelector, Stream objPrivateKeyContent)
        {
            var headers = new HeaderId[] { HeaderId.From, HeaderId.Subject, HeaderId.Date };
            var signer = new DkimSigner(objPrivateKeyContent, strDomain, strSelector, DkimSignatureAlgorithm.RsaSha256)
            {
                HeaderCanonicalizationAlgorithm = DkimCanonicalizationAlgorithm.Simple,
                BodyCanonicalizationAlgorithm = DkimCanonicalizationAlgorithm.Simple,
                AgentOrUserIdentifier = $"@{strDomain}",
                QueryMethod = "dns/txt",
            };
            
            var objEncodingConstraint = (EncodingConstraint)Enum.Parse(typeof(EncodingConstraint), cbxEncodingConstraint.Text);
            mail.Prepare(objEncodingConstraint);
            signer.Sign(mail, headers);
        }

        /// <summary>
        /// 點選是否要驗證
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbAuthenticate_CheckedChanged(object sender, EventArgs e)
        {
            txtSmtpUid.Enabled = rbAuthenticate.Checked;
            txtSmtpPwd.Enabled = rbAuthenticate.Checked;
        }

        /// <summary>
        /// 點選不進行驗證
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbNoAuthenticate_CheckedChanged(object sender, EventArgs e)
        {
            txtSmtpUid.Text = "";
            txtSmtpPwd.Text = "";
            txtSmtpUid.Enabled = !rbNoAuthenticate.Checked;
            txtSmtpPwd.Enabled = !rbNoAuthenticate.Checked;
        }

        /// <summary>
        /// 頁面載入時的動作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Load(object sender, EventArgs e)
        {
            // 取出這個執行檔的檔案版本
            System.Diagnostics.FileVersionInfo objFileVersionInfo = System.Diagnostics.FileVersionInfo.GetVersionInfo(Application.ExecutablePath);
            this.Text += $" ({objFileVersionInfo.FileVersion})";
        }
    }
}
