namespace EncryptingMailSender
{
    partial class Form1
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
            if (disposing && components != null)
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
			this.lblRecipient = new System.Windows.Forms.Label();
			this.txtRecipient = new System.Windows.Forms.TextBox();
			this.lblSubject = new System.Windows.Forms.Label();
			this.txtSubject = new System.Windows.Forms.TextBox();
			this.lblAttachments = new System.Windows.Forms.Label();
			this.txtAttachments = new System.Windows.Forms.TextBox();
			this.btnAddAttachments = new System.Windows.Forms.Button();
			this.btnClearAttachments = new System.Windows.Forms.Button();
			this.lblBody = new System.Windows.Forms.Label();
			this.txtBody = new System.Windows.Forms.TextBox();
			this.btnSend = new System.Windows.Forms.Button();
			this.lblResult = new System.Windows.Forms.Label();
			this.lblCertificate = new System.Windows.Forms.Label();
			this.txtCertificate = new System.Windows.Forms.TextBox();
			this.btnAddCertificate = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblRecipient
			// 
			this.lblRecipient.AutoSize = true;
			this.lblRecipient.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRecipient.Location = new System.Drawing.Point(35, 39);
			this.lblRecipient.Name = "lblRecipient";
			this.lblRecipient.Size = new System.Drawing.Size(89, 19);
			this.lblRecipient.TabIndex = 0;
			this.lblRecipient.Text = "Recipient :";
			// 
			// txtRecipient
			// 
			this.txtRecipient.Location = new System.Drawing.Point(130, 40);
			this.txtRecipient.Name = "txtRecipient";
			this.txtRecipient.Size = new System.Drawing.Size(390, 20);
			this.txtRecipient.TabIndex = 1;
			// 
			// lblSubject
			// 
			this.lblSubject.AutoSize = true;
			this.lblSubject.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSubject.Location = new System.Drawing.Point(49, 67);
			this.lblSubject.Name = "lblSubject";
			this.lblSubject.Size = new System.Drawing.Size(75, 19);
			this.lblSubject.TabIndex = 2;
			this.lblSubject.Text = "Subject :";
			// 
			// txtSubject
			// 
			this.txtSubject.Location = new System.Drawing.Point(130, 66);
			this.txtSubject.Name = "txtSubject";
			this.txtSubject.Size = new System.Drawing.Size(390, 20);
			this.txtSubject.TabIndex = 3;
			// 
			// lblAttachments
			// 
			this.lblAttachments.AutoSize = true;
			this.lblAttachments.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAttachments.Location = new System.Drawing.Point(12, 93);
			this.lblAttachments.Name = "lblAttachments";
			this.lblAttachments.Size = new System.Drawing.Size(112, 19);
			this.lblAttachments.TabIndex = 4;
			this.lblAttachments.Text = "Attachments :";
			// 
			// txtAttachments
			// 
			this.txtAttachments.Location = new System.Drawing.Point(130, 92);
			this.txtAttachments.Name = "txtAttachments";
			this.txtAttachments.ReadOnly = true;
			this.txtAttachments.Size = new System.Drawing.Size(291, 20);
			this.txtAttachments.TabIndex = 5;
			// 
			// btnAddAttachments
			// 
			this.btnAddAttachments.Location = new System.Drawing.Point(427, 92);
			this.btnAddAttachments.Name = "btnAddAttachments";
			this.btnAddAttachments.Size = new System.Drawing.Size(37, 20);
			this.btnAddAttachments.TabIndex = 6;
			this.btnAddAttachments.Text = "...";
			this.btnAddAttachments.UseVisualStyleBackColor = true;
			this.btnAddAttachments.Click += new System.EventHandler(this.BtnAddAttachments_Click);
			// 
			// btnClearAttachments
			// 
			this.btnClearAttachments.Location = new System.Drawing.Point(470, 92);
			this.btnClearAttachments.Name = "btnClearAttachments";
			this.btnClearAttachments.Size = new System.Drawing.Size(50, 20);
			this.btnClearAttachments.TabIndex = 7;
			this.btnClearAttachments.Text = "Clear";
			this.btnClearAttachments.UseVisualStyleBackColor = true;
			this.btnClearAttachments.Click += new System.EventHandler(this.BtnClearAttachments_Click);
			// 
			// lblBody
			// 
			this.lblBody.AutoSize = true;
			this.lblBody.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblBody.Location = new System.Drawing.Point(65, 119);
			this.lblBody.Name = "lblBody";
			this.lblBody.Size = new System.Drawing.Size(59, 19);
			this.lblBody.TabIndex = 8;
			this.lblBody.Text = "Body :";
			// 
			// txtBody
			// 
			this.txtBody.Location = new System.Drawing.Point(130, 118);
			this.txtBody.Multiline = true;
			this.txtBody.Name = "txtBody";
			this.txtBody.Size = new System.Drawing.Size(390, 147);
			this.txtBody.TabIndex = 9;
			// 
			// btnSend
			// 
			this.btnSend.Location = new System.Drawing.Point(394, 271);
			this.btnSend.Name = "btnSend";
			this.btnSend.Size = new System.Drawing.Size(126, 35);
			this.btnSend.TabIndex = 10;
			this.btnSend.Text = "Send";
			this.btnSend.UseVisualStyleBackColor = true;
			this.btnSend.Click += new System.EventHandler(this.BtnSend_Click);
			// 
			// lblResult
			// 
			this.lblResult.AutoSize = true;
			this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lblResult.ForeColor = System.Drawing.Color.ForestGreen;
			this.lblResult.Location = new System.Drawing.Point(126, 277);
			this.lblResult.Name = "lblResult";
			this.lblResult.Size = new System.Drawing.Size(153, 20);
			this.lblResult.TabIndex = 11;
			this.lblResult.Text = "Email has been sent";
			this.lblResult.Visible = false;
			// 
			// lblCertificate
			// 
			this.lblCertificate.AutoSize = true;
			this.lblCertificate.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCertificate.Location = new System.Drawing.Point(25, 13);
			this.lblCertificate.Name = "lblCertificate";
			this.lblCertificate.Size = new System.Drawing.Size(99, 19);
			this.lblCertificate.TabIndex = 13;
			this.lblCertificate.Text = "Certificate :";
			// 
			// txtCertificate
			// 
			this.txtCertificate.Location = new System.Drawing.Point(130, 14);
			this.txtCertificate.Name = "txtCertificate";
			this.txtCertificate.ReadOnly = true;
			this.txtCertificate.Size = new System.Drawing.Size(347, 20);
			this.txtCertificate.TabIndex = 14;
			// 
			// btnAddCertificate
			// 
			this.btnAddCertificate.Location = new System.Drawing.Point(483, 14);
			this.btnAddCertificate.Name = "btnAddCertificate";
			this.btnAddCertificate.Size = new System.Drawing.Size(37, 20);
			this.btnAddCertificate.TabIndex = 16;
			this.btnAddCertificate.Text = "...";
			this.btnAddCertificate.UseVisualStyleBackColor = true;
			this.btnAddCertificate.Click += new System.EventHandler(this.BtnAddCertificate_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(532, 320);
			this.Controls.Add(this.btnAddCertificate);
			this.Controls.Add(this.txtCertificate);
			this.Controls.Add(this.lblCertificate);
			this.Controls.Add(this.lblResult);
			this.Controls.Add(this.btnSend);
			this.Controls.Add(this.txtBody);
			this.Controls.Add(this.lblBody);
			this.Controls.Add(this.btnClearAttachments);
			this.Controls.Add(this.btnAddAttachments);
			this.Controls.Add(this.txtAttachments);
			this.Controls.Add(this.lblAttachments);
			this.Controls.Add(this.txtSubject);
			this.Controls.Add(this.lblSubject);
			this.Controls.Add(this.txtRecipient);
			this.Controls.Add(this.lblRecipient);
			this.Name = "Form1";
			this.Text = "Encrypting Mail Sender";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRecipient;
        private System.Windows.Forms.TextBox txtRecipient;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label lblAttachments;
        private System.Windows.Forms.TextBox txtAttachments;
        private System.Windows.Forms.Button btnAddAttachments;
        private System.Windows.Forms.Button btnClearAttachments;
        private System.Windows.Forms.Label lblBody;
        private System.Windows.Forms.TextBox txtBody;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblResult;
		private System.Windows.Forms.Label lblCertificate;
		private System.Windows.Forms.TextBox txtCertificate;
		private System.Windows.Forms.Button btnAddCertificate;
	}
}