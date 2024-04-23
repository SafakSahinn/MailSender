using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Data.SqlClient;

namespace MailSender
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		SqlConnection connectionString = new SqlConnection("Data Source=DESKTOP-AHMDCSU;Initial Catalog=MailDB;Integrated Security=True");

		private void btnSend_Click(object sender, EventArgs e)
		{
			connectionString.Open();
			SqlCommand command = new SqlCommand("SELECT * FROM TblMail", connectionString);
			SqlDataReader reader = command.ExecuteReader();

			int successful = 0, unsuccessful = 0;

			while (reader.Read())
			{
				string reciverMail = reader["Mail"].ToString();

				try
				{
					MailMessage mail = new MailMessage();
					SmtpClient smtp = new SmtpClient("smtp.gmail.com");

					mail.From = new MailAddress(txtSenderMail.Text);
					mail.To.Add(reciverMail);
					mail.Subject = txtSubject.Text;
					mail.Body = rchBody.Text;

					smtp.Port = 587;
					smtp.Credentials = new System.Net.NetworkCredential(txtSenderMail.Text, txtPassword.Text);
					smtp.EnableSsl = true;

					smtp.Send(mail);

					//MessageBox.Show("The mail sended!");
					successful++;
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
					unsuccessful++;
				}
			}
			MessageBox.Show("An e-mail was sent to all accounts. Successful: " + successful + ", Unsuccessful: " + unsuccessful);
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}
