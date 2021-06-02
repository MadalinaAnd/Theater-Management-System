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
	public partial class BuyTickets : Form
	{
		private IService service;
		private int idPer;
		private string name;
		private int seat;
		private float price;
		private string date;
		private int idUser;
		private Menu menu;

		public BuyTickets(IService service, int idPer, string name, int seat, float price, string date, int idUser, Menu menu)
		{
			this.service = service;
			InitializeComponent();
			this.service = service;
			this.idPer = idPer;
			this.name = name;
			this.seat = seat;
			this.price = price;
			this.date = date;
			this.idUser = idUser;
			this.menu = menu;
		}


		private void BuyButton_Click(object sender, EventArgs e)
		{
			if (FirstNameTextBox.Text != "" && SecondNameTextBox.Text != "" && CardNumberTextBox.Text != "" && ExpirationDateTextBox.Text != "" && CVCCodeTextBox.Text != "")
			{
				var ticket = new Ticket(idPer, name, seat, price, date, idUser);
				service.AddTicket(ticket);
				menu.DisplayPerformances();
				menu.DisplayReservedTickets();
				menu.DisplayTickets();
				Hide();
			}
			else
			{
				MessageBox.Show("All textboxes should be completed!");
			}

		}

		private void BackButton_Click(object sender, EventArgs e)
		{
			Hide();
		}
	}
}
