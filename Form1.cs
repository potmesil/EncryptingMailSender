using System;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography.Pkcs;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptingMailSender
{
	public partial class Form1 : Form
    {
        private static readonly MailSettingsSection MailSettings = (MailSettingsSection)ConfigurationManager.GetSection("mailSettings");

        #region Constructors

        public Form1()
        {
            InitializeComponent();
        }

		#endregion Constructors

		#region Event Handlers

		private void BtnAddCertificate_Click(object sender, EventArgs e)
		{
			var openFileDialog = new OpenFileDialog
			{
				Filter = "Certificate (*.cer)|*.cer"
			};

			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				txtCertificate.Text = openFileDialog.FileName;
			}
		}

		private void BtnAddAttachments_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                Multiselect = true
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtAttachments.Text = $@"{txtAttachments.Text};{string.Join(";", openFileDialog.FileNames)}".Trim(';');
            }
        }

        private void BtnClearAttachments_Click(object sender, EventArgs e)
        {
            txtAttachments.Text = string.Empty;
        }

        private async void BtnSend_Click(object sender, EventArgs e)
        {
            if (!btnSend.Enabled)
            {
                return;
            }

            btnSend.Enabled = false;
            lblResult.Visible = false;

            try
            {
	            using (var smtpClient = GetSmtpClient())
	            using (var mailMessage = new MailMessage())
	            {
		            mailMessage.From = new MailAddress(MailSettings.From.Address, MailSettings.From.Name);
		            mailMessage.Subject = txtSubject.Text;

		            foreach (var recipient in txtRecipient.Text.Split(';'))
		            {
			            mailMessage.To.Add(recipient);
		            }

		            var attachments = txtAttachments.Text.Split(';')
			            .Where(fileName => !string.IsNullOrWhiteSpace(fileName))
			            .Select(fileName => new Attachment(fileName))
			            .ToArray();

		            if (!string.IsNullOrWhiteSpace(txtCertificate.Text))
		            {
			            using (var encryptingCertificate = new X509Certificate2(txtCertificate.Text))
			            {
				            var encryptedBodyBytes = await GetEncryptedBodyBytesAsync(txtBody.Text, attachments, encryptingCertificate);

				            using (var memoryStream = new MemoryStream(encryptedBodyBytes))
				            {
					            mailMessage.AlternateViews.Add(new AlternateView(memoryStream, "application/pkcs7-mime; smime-type=enveloped-data; name=smime.p7m"));
					            await smtpClient.SendMailAsync(mailMessage);
				            }
			            }
		            }
		            else
		            {
			            mailMessage.Body = txtBody.Text;

			            foreach (var attachment in attachments)
			            {
				            mailMessage.Attachments.Add(attachment);
			            }

			            await smtpClient.SendMailAsync(mailMessage);
		            }
	            }

                lblResult.Text = @"Email has been sent";
                lblResult.ForeColor = Color.ForestGreen;
            }
            catch
            {
                lblResult.Text = @"Something went wrong";
                lblResult.ForeColor = Color.Red;
            }

            Application.DoEvents();

            lblResult.Visible = true;
            btnSend.Enabled = true;
        }

        #endregion Event Handlers

        #region Private Methods

        private SmtpClient GetSmtpClient()
        {
			return new SmtpClient
			{
				Host = MailSettings.Smtp.Host,
				Port = MailSettings.Smtp.Port,
				EnableSsl = MailSettings.Smtp.EnableSsl,
				Credentials = new NetworkCredential(MailSettings.Smtp.UserName, MailSettings.Smtp.Password)
			};
		}

        private async Task<byte[]> GetEncryptedBodyBytesAsync(string body, Attachment[] attachments, X509Certificate2 encryptingCertificate)
        {
            var bodyBase64Encoded = Convert.ToBase64String(Encoding.UTF8.GetBytes(body), Base64FormattingOptions.InsertLineBreaks);
            var bodyBuilder = new StringBuilder();

            if (attachments.Length == 0)
            {
                bodyBuilder.AppendLine("Content-Type: text/plain; charset=utf-8");
                bodyBuilder.AppendLine("Content-Transfer-Encoding: base64");
                bodyBuilder.AppendLine();
                bodyBuilder.Append(bodyBase64Encoded);
            }
            else
            {
                var boundary = Guid.NewGuid().ToString("N");

                bodyBuilder.AppendLine($"Content-Type: multipart/mixed; boundary={boundary}");
                bodyBuilder.AppendLine("Content-Transfer-Encoding: 7bit");
                bodyBuilder.AppendLine();
                bodyBuilder.AppendLine("This is a message with multiple parts in MIME format.");
                bodyBuilder.AppendLine($"--{boundary}");
                bodyBuilder.AppendLine("Content-Type: text/plain; charset=utf-8");
                bodyBuilder.AppendLine("Content-Transfer-Encoding: base64");
                bodyBuilder.AppendLine();
                bodyBuilder.AppendLine(bodyBase64Encoded);

                foreach (var attachment in attachments)
                {
                    using (var memoryStream = new MemoryStream())
                    {
                        await attachment.ContentStream.CopyToAsync(memoryStream);

                        bodyBuilder.AppendLine($"--{boundary}");
                        bodyBuilder.AppendLine($"Content-Type: {attachment.ContentType}");
                        bodyBuilder.AppendLine("Content-Transfer-Encoding: base64");
                        bodyBuilder.AppendLine();
                        bodyBuilder.AppendLine(Convert.ToBase64String(memoryStream.ToArray(), Base64FormattingOptions.InsertLineBreaks));
                    }
                }

                bodyBuilder.Append($"--{boundary}--");
            }

            var bodyBytes = Encoding.UTF8.GetBytes(bodyBuilder.ToString());
            var envelope = new EnvelopedCms(new ContentInfo(bodyBytes));
            var recipient = new CmsRecipient(SubjectIdentifierType.IssuerAndSerialNumber, encryptingCertificate);

            envelope.Encrypt(recipient);

            return envelope.Encode();
        }

		#endregion Private Methods
    }
}