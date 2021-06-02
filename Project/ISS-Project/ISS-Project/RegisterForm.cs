using Model;
using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISS_Project
{
	public partial class RegisterForm : Form
	{
		private IService service;

		public RegisterForm(IService service)
		{
			InitializeComponent();
			this.service = service;
		}

		private void BackButton_Click(object sender, EventArgs e)
		{
			Hide();
		}

		private void RegisterButton_Click(object sender, EventArgs e)
		{
			var email = EmailTextBox.Text;
			var username = UsernameTextBox.Text;
			var password = PasswordTextBox.Text;

			if (email != "" && username != "" && password != "")
			{
				var spectator = new Spectator(username, password, email);
				service.AddSpectator(spectator);
				Hide();
			}
			else
			{
				MessageBox.Show("Email or username or password shouldn't be empty!");
			}
		}
	}
}
