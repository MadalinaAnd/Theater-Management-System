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
	public partial class LogInForm : Form
	{
		private IService service;
		public LogInForm(IService service)
		{
			InitializeComponent();
			this.service = service;
		}

		private void SingInGroupBox_Enter(object sender, EventArgs e)
		{

		}

		private void LogInButton_Click(object sender, EventArgs e)
		{
			var username = UsernameTextBox.Text;
			var password = PasswordTextBox.Text;

			if (username == "" || password == "")
			{
				MessageBox.Show("Username or password are empty!");
			}
			else
			{
				var spectator = service.LogInSpectator(username, password);
				if (spectator != null)
				{
					Hide();
					var spectatorForm = new Menu(service,spectator.Id);
					spectatorForm.Show();
				}
				else
				{
					MessageBox.Show("Username or password are inccorect!");
				}
			}
		}

		private void RegisterButton_Click(object sender, EventArgs e)
		{
			var registerForm = new RegisterForm(service);
			registerForm.Show();
		}

		private void AdminButton_Click(object sender, EventArgs e)
		{
			var username = UsernameTextBox.Text;
			var password = PasswordTextBox.Text;

			if (username == "" || password == "")
			{
				MessageBox.Show("Username or password are empty!");
			}
			else
			{
				var librarian = service.LogInAdmin(username, password);
				if (librarian != null)
				{
					Hide();
					var adminForm = new AdminMenu(service);
					adminForm.Show();
				}
				else
				{
					MessageBox.Show("Username or password are inccorect!");
				}
			}
		}
	}
}
