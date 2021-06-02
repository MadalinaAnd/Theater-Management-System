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
	public partial class Menu : Form
	{
		private IService service;
		private int currentUser;
		private int currentIndex;
		private string currentDate;
		private List<Button> seats = new List<Button>();

		public Menu(IService service, int currentUser)
		{
			InitializeComponent();
			this.service = service;
			this.currentUser = currentUser;
			DisplayPerformances();
			DisplayReservedTickets();
			DisplayTickets();
			currentIndex = 1;
			PopulateSeats();
		}


		private void PopulateLabels()
		{
			var row = PerformancesDataGridView.Rows[currentIndex];

			var d = row.Cells[2].Value.ToString();
			var dates = d.Split('-');
			var data = dates[0] + "-" + dates[1] + "-" + dates[2];
			var hour = dates[3] + ":" + dates[4];

			NamePerformanceLabel.Text = "Name: " + row.Cells[1].Value.ToString();
			DateLabel.Text = "Date: " + data.ToString();
			HourLabel.Text = "Hour: " + hour.ToString();
		}

		public void DisplayTickets()
		{
			var source = new BindingSource();
			var performances = service.GetAllTicketsByUser(currentUser);
			source.DataSource = performances;
			BoughtTicketsDataGridView.DataSource = source;
		}

		public void DisplayReservedTickets()
		{
			var source = new BindingSource();
			var performances = service.GetAllReservedTicketsByUser(currentUser);
			source.DataSource = performances;
			ReservedTicketsDataGridView.DataSource = source;
		}

		public void DisplayPerformances()
		{
			var source = new BindingSource();
			var performances = service.GetAllPerformancesByDate(currentDate);
			source.DataSource = performances;
			PerformancesDataGridView.DataSource = source;

			var tickets = service.GetAllTicketsByUserFromDate(currentUser, currentDate);
			var reserved = service.GetAllReservedTicketsByUserFromDate(currentUser, currentDate);

			foreach (var button in seats)
			{
				button.BackColor = Color.Green;
				foreach (var t in tickets)
				{
					if (button.Text == t.Seat.ToString())
					{
						button.BackColor = Color.Red;
					}
				}
				foreach (var r in reserved)
				{
					if (button.Text == r.Seat.ToString())
					{
						button.BackColor = Color.Yellow;
					}
				}
			}
		}

		private void SceneButton_Click(object sender, EventArgs e)
		{

		}

		private void LogOutButton_Click(object sender, EventArgs e)
		{
			Hide();
			var loginForm = new LogInForm(service);
			loginForm.Show();
		}

		private void PerformancesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			currentIndex = e.RowIndex;
			PopulateLabels();
		}

		private void DateTimePicker_ValueChanged(object sender, EventArgs e)
		{
			var date = DateTimePicker.Value.Year.ToString() + "-" + DateTimePicker.Value.Month.ToString() + "-" + DateTimePicker.Value.Day.ToString();
			currentDate = date;
			DisplayPerformances();
		}

		private void PopulateSeats()
		{
			seats.Add(SeatsButton1);
			seats.Add(SeatsButton2);
			seats.Add(SeatsButton3);
			seats.Add(SeatsButton4);
			seats.Add(SeatsButton5);
			seats.Add(SeatsButton6);
			seats.Add(SeatsButton7);
			seats.Add(SeatsButton8);
			seats.Add(SeatsButton9);
			seats.Add(SeatsButton10);
			seats.Add(SeatsButton11);
			seats.Add(SeatsButton12);
			seats.Add(SeatsButton13);
			seats.Add(SeatsButton14);
			seats.Add(SeatsButton15);
			seats.Add(SeatsButton16);
			seats.Add(SeatsButton17);
			seats.Add(SeatsButton18);
			seats.Add(SeatsButton19);
			seats.Add(SeatsButton20);
			seats.Add(SeatsButton21);
			seats.Add(SeatsButton22);
			seats.Add(SeatsButton23);
			seats.Add(SeatsButton24);
			seats.Add(SeatsButton25);
			seats.Add(SeatsButton26);
			seats.Add(SeatsButton27);
			seats.Add(SeatsButton28);
			seats.Add(SeatsButton29);
			seats.Add(SeatsButton30);
			seats.Add(SeatsButton31);
			seats.Add(SeatsButton32);
			seats.Add(SeatsButton33);
			seats.Add(SeatsButton34);
			seats.Add(SeatsButton35);
			seats.Add(SeatsButton36);
		}

		private void v(object sender, EventArgs e)
		{

		}

		private void BuyButton_Click(object sender, EventArgs e)
		{
			var row = PerformancesDataGridView.Rows[currentIndex];

			var seat = int.Parse(SeatNumberTextBox.Text);

			if (AvalibleSeat(SeatNumberTextBox.Text))
			{
				var idPer = int.Parse(row.Cells[0].Value.ToString());
				var name = row.Cells[1].Value.ToString();
				var date = row.Cells[2].Value.ToString();
				var price = float.Parse(row.Cells[3].Value.ToString());

				var buyform = new BuyTickets(service, idPer, name, seat, price, date, currentUser, this);
				buyform.Show();
			}
			else
			{
				MessageBox.Show("Choose an avalible seat!");
			}
		}

		private bool AvalibleSeat(string number)
		{
			foreach (var s in seats)
			{
				if (s.Text == number && s.BackColor == Color.Green)
				{
					return true;
				}
			}
			return false;
		}

		private void ReserveButton_Click(object sender, EventArgs e)
		{
			var row = PerformancesDataGridView.Rows[currentIndex];

			var seat = int.Parse(SeatNumberTextBox.Text);

			if (AvalibleSeat(SeatNumberTextBox.Text))
			{
				var idPer = int.Parse(row.Cells[0].Value.ToString());
				var name = row.Cells[1].Value.ToString();
				var date = row.Cells[2].Value.ToString();
				var price = float.Parse(row.Cells[3].Value.ToString());

				var reservedform = new ReserveTickets(service, idPer, name, seat, price, date, currentUser, this);
				reservedform.Show();
			}
			else
			{
				MessageBox.Show("Choose an avalible seat!");
			}
		}

		private void HourLabel_Click(object sender, EventArgs e)
		{

		}

		private void Menu_FormClosing(object sender, FormClosingEventArgs e)
		{
			var log = new LogInForm(service);
			log.Show();
		}
	}
}
