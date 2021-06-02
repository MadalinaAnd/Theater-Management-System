
namespace ISS_Project
{
	partial class AdminMenu
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
			if (disposing && (components != null))
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.LogOutButton = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.HourLabel = new System.Windows.Forms.Label();
			this.DateLabel = new System.Windows.Forms.Label();
			this.NameLabel = new System.Windows.Forms.Label();
			this.PerformanceDetailsLabel = new System.Windows.Forms.Label();
			this.DateLabelWrite = new System.Windows.Forms.Label();
			this.HourLabelWrite = new System.Windows.Forms.Label();
			this.NameLabelWrite = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.AddPerformancesButton = new System.Windows.Forms.Button();
			this.DeleteButton = new System.Windows.Forms.Button();
			this.UpdateButton = new System.Windows.Forms.Button();
			this.RowLabel = new System.Windows.Forms.Label();
			this.PriceLabel = new System.Windows.Forms.Label();
			this.PriceLabelTextBox = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(14, 14);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(628, 387);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// LogOutButton
			// 
			this.LogOutButton.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
			this.LogOutButton.Location = new System.Drawing.Point(791, 14);
			this.LogOutButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.LogOutButton.Name = "LogOutButton";
			this.LogOutButton.Size = new System.Drawing.Size(187, 66);
			this.LogOutButton.TabIndex = 1;
			this.LogOutButton.Text = "Log Out";
			this.LogOutButton.UseVisualStyleBackColor = true;
			this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.PriceLabel);
			this.groupBox1.Controls.Add(this.HourLabel);
			this.groupBox1.Controls.Add(this.DateLabel);
			this.groupBox1.Controls.Add(this.NameLabel);
			this.groupBox1.Controls.Add(this.PerformanceDetailsLabel);
			this.groupBox1.Location = new System.Drawing.Point(649, 87);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.groupBox1.Size = new System.Drawing.Size(468, 295);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			// 
			// HourLabel
			// 
			this.HourLabel.AutoSize = true;
			this.HourLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
			this.HourLabel.Location = new System.Drawing.Point(8, 190);
			this.HourLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.HourLabel.Name = "HourLabel";
			this.HourLabel.Size = new System.Drawing.Size(44, 17);
			this.HourLabel.TabIndex = 3;
			this.HourLabel.Text = "Hour:";
			// 
			// DateLabel
			// 
			this.DateLabel.AutoSize = true;
			this.DateLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
			this.DateLabel.Location = new System.Drawing.Point(8, 152);
			this.DateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.DateLabel.Name = "DateLabel";
			this.DateLabel.Size = new System.Drawing.Size(43, 17);
			this.DateLabel.TabIndex = 2;
			this.DateLabel.Text = "Date:";
			// 
			// NameLabel
			// 
			this.NameLabel.AutoSize = true;
			this.NameLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
			this.NameLabel.Location = new System.Drawing.Point(8, 99);
			this.NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.NameLabel.Name = "NameLabel";
			this.NameLabel.Size = new System.Drawing.Size(52, 17);
			this.NameLabel.TabIndex = 1;
			this.NameLabel.Text = "Name:";
			// 
			// PerformanceDetailsLabel
			// 
			this.PerformanceDetailsLabel.AutoSize = true;
			this.PerformanceDetailsLabel.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
			this.PerformanceDetailsLabel.Location = new System.Drawing.Point(105, 18);
			this.PerformanceDetailsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.PerformanceDetailsLabel.Name = "PerformanceDetailsLabel";
			this.PerformanceDetailsLabel.Size = new System.Drawing.Size(201, 23);
			this.PerformanceDetailsLabel.TabIndex = 0;
			this.PerformanceDetailsLabel.Text = "Performance Details";
			// 
			// DateLabelWrite
			// 
			this.DateLabelWrite.AutoSize = true;
			this.DateLabelWrite.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
			this.DateLabelWrite.Location = new System.Drawing.Point(23, 507);
			this.DateLabelWrite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.DateLabelWrite.Name = "DateLabelWrite";
			this.DateLabelWrite.Size = new System.Drawing.Size(52, 23);
			this.DateLabelWrite.TabIndex = 3;
			this.DateLabelWrite.Text = "Date";
			// 
			// HourLabelWrite
			// 
			this.HourLabelWrite.AutoSize = true;
			this.HourLabelWrite.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
			this.HourLabelWrite.Location = new System.Drawing.Point(23, 542);
			this.HourLabelWrite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.HourLabelWrite.Name = "HourLabelWrite";
			this.HourLabelWrite.Size = new System.Drawing.Size(56, 23);
			this.HourLabelWrite.TabIndex = 4;
			this.HourLabelWrite.Text = "Hour";
			// 
			// NameLabelWrite
			// 
			this.NameLabelWrite.AutoSize = true;
			this.NameLabelWrite.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
			this.NameLabelWrite.Location = new System.Drawing.Point(23, 470);
			this.NameLabelWrite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.NameLabelWrite.Name = "NameLabelWrite";
			this.NameLabelWrite.Size = new System.Drawing.Size(64, 23);
			this.NameLabelWrite.TabIndex = 5;
			this.NameLabelWrite.Text = "Name";
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
			this.textBox1.Location = new System.Drawing.Point(155, 470);
			this.textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(487, 29);
			this.textBox1.TabIndex = 6;
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
			this.textBox2.Location = new System.Drawing.Point(155, 507);
			this.textBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(487, 29);
			this.textBox2.TabIndex = 7;
			// 
			// textBox3
			// 
			this.textBox3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.textBox3.Location = new System.Drawing.Point(155, 542);
			this.textBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(487, 29);
			this.textBox3.TabIndex = 8;
			// 
			// AddPerformancesButton
			// 
			this.AddPerformancesButton.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
			this.AddPerformancesButton.Location = new System.Drawing.Point(659, 389);
			this.AddPerformancesButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.AddPerformancesButton.Name = "AddPerformancesButton";
			this.AddPerformancesButton.Size = new System.Drawing.Size(187, 66);
			this.AddPerformancesButton.TabIndex = 9;
			this.AddPerformancesButton.Text = "Add";
			this.AddPerformancesButton.UseVisualStyleBackColor = true;
			this.AddPerformancesButton.Click += new System.EventHandler(this.AddPerformancesButton_Click);
			// 
			// DeleteButton
			// 
			this.DeleteButton.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
			this.DeleteButton.Location = new System.Drawing.Point(791, 470);
			this.DeleteButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.DeleteButton.Name = "DeleteButton";
			this.DeleteButton.Size = new System.Drawing.Size(187, 66);
			this.DeleteButton.TabIndex = 10;
			this.DeleteButton.Text = "Delete";
			this.DeleteButton.UseVisualStyleBackColor = true;
			this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
			// 
			// UpdateButton
			// 
			this.UpdateButton.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
			this.UpdateButton.Location = new System.Drawing.Point(930, 554);
			this.UpdateButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.UpdateButton.Name = "UpdateButton";
			this.UpdateButton.Size = new System.Drawing.Size(187, 66);
			this.UpdateButton.TabIndex = 11;
			this.UpdateButton.Text = "Update";
			this.UpdateButton.UseVisualStyleBackColor = true;
			this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
			// 
			// RowLabel
			// 
			this.RowLabel.AutoSize = true;
			this.RowLabel.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
			this.RowLabel.Location = new System.Drawing.Point(280, 411);
			this.RowLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.RowLabel.Name = "RowLabel";
			this.RowLabel.Size = new System.Drawing.Size(56, 23);
			this.RowLabel.TabIndex = 12;
			this.RowLabel.Text = "Row:";
			// 
			// PriceLabel
			// 
			this.PriceLabel.AutoSize = true;
			this.PriceLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
			this.PriceLabel.Location = new System.Drawing.Point(7, 228);
			this.PriceLabel.Name = "PriceLabel";
			this.PriceLabel.Size = new System.Drawing.Size(47, 21);
			this.PriceLabel.TabIndex = 4;
			this.PriceLabel.Text = "Price:";
			// 
			// PriceLabelTextBox
			// 
			this.PriceLabelTextBox.AutoSize = true;
			this.PriceLabelTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
			this.PriceLabelTextBox.Location = new System.Drawing.Point(23, 574);
			this.PriceLabelTextBox.Name = "PriceLabelTextBox";
			this.PriceLabelTextBox.Size = new System.Drawing.Size(57, 25);
			this.PriceLabelTextBox.TabIndex = 13;
			this.PriceLabelTextBox.Text = "Price";
			// 
			// textBox4
			// 
			this.textBox4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.textBox4.Location = new System.Drawing.Point(155, 577);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(486, 29);
			this.textBox4.TabIndex = 14;
			// 
			// AdminMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(1130, 653);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.PriceLabelTextBox);
			this.Controls.Add(this.RowLabel);
			this.Controls.Add(this.UpdateButton);
			this.Controls.Add(this.DeleteButton);
			this.Controls.Add(this.AddPerformancesButton);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.NameLabelWrite);
			this.Controls.Add(this.HourLabelWrite);
			this.Controls.Add(this.DateLabelWrite);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.LogOutButton);
			this.Controls.Add(this.dataGridView1);
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.Name = "AdminMenu";
			this.Text = "AdminMenu";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminMenu_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button LogOutButton;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label HourLabel;
		private System.Windows.Forms.Label DateLabel;
		private System.Windows.Forms.Label NameLabel;
		private System.Windows.Forms.Label PerformanceDetailsLabel;
		private System.Windows.Forms.Label DateLabelWrite;
		private System.Windows.Forms.Label HourLabelWrite;
		private System.Windows.Forms.Label NameLabelWrite;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Button AddPerformancesButton;
		private System.Windows.Forms.Button DeleteButton;
		private System.Windows.Forms.Button UpdateButton;
		private System.Windows.Forms.Label RowLabel;
		private System.Windows.Forms.Label PriceLabel;
		private System.Windows.Forms.Label PriceLabelTextBox;
		private System.Windows.Forms.TextBox textBox4;
	}
}