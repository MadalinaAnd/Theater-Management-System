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
	public partial class AdminMenu : Form
	{
		private IService service;
		private int currentIndex;

		public AdminMenu(IService service)
		{
			InitializeComponent();
			this.service = service;
			DisplayPerformances();
			currentIndex = 1;
		}


		private void ClearTextBoxs()
		{

		}

		private void ClearLabels()
		{
			NameLabel.Text = "Name:";
			DateLabel.Text = "Date:";
			HourLabel.Text = "Hour:";
		}

		private void PopulateLabels()
		{
			var row = dataGridView1.Rows[currentIndex];
			NameLabel.Text = "Name: " + row.Cells[1].Value.ToString();
			var d = row.Cells[2].Value.ToString();
			var dates = d.Split('-');
			var data = dates[0] + "-" + dates[1] + "-" + dates[2];
			var hour = dates[3] + ":" + dates[4];
			DateLabel.Text = "Date: " + data;
			HourLabel.Text = "Hour: " + hour;
		}

		private void DisplayPerformances()
		{
			var source = new BindingSource();
			var performances = service.GetAllPerformances().ToList();
			source.DataSource = performances;
			dataGridView1.DataSource = source;
		}

		private void LogOutButton_Click(object sender, EventArgs e)
		{
			Hide();
			var logInForm = new LogInForm(service);
			logInForm.Show();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			currentIndex = e.RowIndex;
			RowLabel.Text = "Row: " + currentIndex.ToString();
			PopulateLabels();
		}

		private void AddPerformancesButton_Click(object sender, EventArgs e)
		{
			var name = textBox1.Text;
			var date = textBox2.Text;
			var hour = textBox3.Text;
			var price = textBox4.Text;

			if (name != "" && date != "" && hour != "" && price != null)
			{
				var finalDate = date + "-" + hour;
				int pr = int.Parse(price);
				var performance = new Performance(name, finalDate, pr);
				service.AddPerformance(performance);

				DisplayPerformances();
			}
			else
			{
				MessageBox.Show("Name or date or hour shouldn't be empty!");
			}
		}

		private void DeleteButton_Click(object sender, EventArgs e)
		{
			var row = dataGridView1.Rows[currentIndex];
			var id = int.Parse(row.Cells[0].Value.ToString());
			service.DeletePerformance(id);
			ClearLabels();
			DisplayPerformances();
		}

		private void UpdateButton_Click(object sender, EventArgs e)
		{
			var name = textBox1.Text;
			var date = textBox2.Text;
			var hour = textBox3.Text;
			var price = textBox4.Text;

			if (name != "" && date != "" && hour != "" && price != null)
			{
				var row = dataGridView1.Rows[currentIndex];
				var id = int.Parse(row.Cells[0].Value.ToString());
				var finalDate = date + "-" + hour;
				int pr = int.Parse(price);
				var performance = new Performance(id, name, finalDate, pr);
				service.UpdatePerformance(performance);

				DisplayPerformances();
			}
			else
			{
				MessageBox.Show("Name or date or hour shouldn't be empty!");
			}
			ClearLabels();
			DisplayPerformances();
		}

		private void AdminMenu_FormClosing(object sender, FormClosingEventArgs e)
		{
			Hide();
			var logInForm = new LogInForm(service);
			logInForm.Show();
		}
	}
}
