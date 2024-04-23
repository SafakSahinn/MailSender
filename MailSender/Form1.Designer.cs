namespace MailSender
{
	partial class Form1
	{
		/// <summary>
		///Gerekli tasarımcı değişkeni.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///Kullanılan tüm kaynakları temizleyin.
		/// </summary>
		///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer üretilen kod

		/// <summary>
		/// Tasarımcı desteği için gerekli metot - bu metodun 
		///içeriğini kod düzenleyici ile değiştirmeyin.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnSend = new System.Windows.Forms.Button();
			this.txtSenderMail = new System.Windows.Forms.TextBox();
			this.rchBody = new System.Windows.Forms.RichTextBox();
			this.txtSubject = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.lblSender = new System.Windows.Forms.Label();
			this.lblSubject = new System.Windows.Forms.Label();
			this.lblBody = new System.Windows.Forms.Label();
			this.lblPasswod = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnSend
			// 
			this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnSend.Location = new System.Drawing.Point(155, 380);
			this.btnSend.Margin = new System.Windows.Forms.Padding(6);
			this.btnSend.Name = "btnSend";
			this.btnSend.Size = new System.Drawing.Size(297, 92);
			this.btnSend.TabIndex = 5;
			this.btnSend.Text = "Send";
			this.btnSend.UseVisualStyleBackColor = true;
			this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
			// 
			// txtSenderMail
			// 
			this.txtSenderMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtSenderMail.Location = new System.Drawing.Point(158, 58);
			this.txtSenderMail.Margin = new System.Windows.Forms.Padding(6);
			this.txtSenderMail.Name = "txtSenderMail";
			this.txtSenderMail.Size = new System.Drawing.Size(294, 31);
			this.txtSenderMail.TabIndex = 1;
			// 
			// rchBody
			// 
			this.rchBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.rchBody.Location = new System.Drawing.Point(155, 187);
			this.rchBody.Margin = new System.Windows.Forms.Padding(6);
			this.rchBody.Name = "rchBody";
			this.rchBody.Size = new System.Drawing.Size(297, 181);
			this.rchBody.TabIndex = 4;
			this.rchBody.Text = "";
			// 
			// txtSubject
			// 
			this.txtSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtSubject.Location = new System.Drawing.Point(155, 144);
			this.txtSubject.Margin = new System.Windows.Forms.Padding(6);
			this.txtSubject.Name = "txtSubject";
			this.txtSubject.Size = new System.Drawing.Size(297, 31);
			this.txtSubject.TabIndex = 3;
			// 
			// txtPassword
			// 
			this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtPassword.Location = new System.Drawing.Point(158, 101);
			this.txtPassword.Margin = new System.Windows.Forms.Padding(6);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(294, 31);
			this.txtPassword.TabIndex = 2;
			// 
			// lblSender
			// 
			this.lblSender.AutoSize = true;
			this.lblSender.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblSender.Location = new System.Drawing.Point(65, 61);
			this.lblSender.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.lblSender.Name = "lblSender";
			this.lblSender.Size = new System.Drawing.Size(81, 25);
			this.lblSender.TabIndex = 6;
			this.lblSender.Text = "Sender";
			// 
			// lblSubject
			// 
			this.lblSubject.AutoSize = true;
			this.lblSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblSubject.Location = new System.Drawing.Point(62, 147);
			this.lblSubject.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.lblSubject.Name = "lblSubject";
			this.lblSubject.Size = new System.Drawing.Size(84, 25);
			this.lblSubject.TabIndex = 8;
			this.lblSubject.Text = "Subject";
			// 
			// lblBody
			// 
			this.lblBody.AutoSize = true;
			this.lblBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblBody.Location = new System.Drawing.Point(85, 190);
			this.lblBody.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.lblBody.Name = "lblBody";
			this.lblBody.Size = new System.Drawing.Size(61, 25);
			this.lblBody.TabIndex = 9;
			this.lblBody.Text = "Body";
			// 
			// lblPasswod
			// 
			this.lblPasswod.AutoSize = true;
			this.lblPasswod.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblPasswod.Location = new System.Drawing.Point(40, 107);
			this.lblPasswod.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.lblPasswod.Name = "lblPasswod";
			this.lblPasswod.Size = new System.Drawing.Size(106, 25);
			this.lblPasswod.TabIndex = 10;
			this.lblPasswod.Text = "Password";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(515, 534);
			this.Controls.Add(this.lblPasswod);
			this.Controls.Add(this.lblBody);
			this.Controls.Add(this.lblSubject);
			this.Controls.Add(this.lblSender);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtSubject);
			this.Controls.Add(this.rchBody);
			this.Controls.Add(this.txtSenderMail);
			this.Controls.Add(this.btnSend);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Margin = new System.Windows.Forms.Padding(6);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnSend;
		private System.Windows.Forms.TextBox txtSenderMail;
		private System.Windows.Forms.RichTextBox rchBody;
		private System.Windows.Forms.TextBox txtSubject;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Label lblSender;
		private System.Windows.Forms.Label lblSubject;
		private System.Windows.Forms.Label lblBody;
		private System.Windows.Forms.Label lblPasswod;
	}
}

