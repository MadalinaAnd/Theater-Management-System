
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
			this.PerformanceDetailsLabel = new System.Windows.Forms.Label();
			this.NameLabel = new System.Windows.Forms.Label();
			this.DateLabel = new System.Windows.Forms.Label();
			this.HourLabel = new System.Windows.Forms.Label();
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
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(538, 335);
			this.dataGridView1.TabIndex = 0;
			// 
			// LogOutButton
			// 
			this.LogOutButton.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.LogOutButton.Location = new System.Drawing.Point(678, 12);
			this.LogOutButton.Name = "LogOutButton";
			this.LogOutButton.Size = new System.Drawing.Size(160, 57);
			this.LogOutButton.TabIndex = 1;
			this.LogOutButton.Text = "Log Out";
			this.LogOutButton.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.HourLabel);
			this.groupBox1.Controls.Add(this.DateLabel);
			this.groupBox1.Controls.Add(this.NameLabel);
			this.groupBox1.Controls.Add(this.PerformanceDetailsLabel);
			this.groupBox1.Location = new System.Drawing.Point(556, 75);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(401, 256);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			// 
			// PerformanceDetailsLabel
			// 
			this.PerformanceDetailsLabel.AutoSize = true;
			this.PerformanceDetailsLabel.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.PerformanceDetailsLabel.Location = new System.Drawing.Point(90, 16);
			this.PerformanceDetailsLabel.Name = "PerformanceDetailsLabel";
			this.PerformanceDetailsLabel.Size = new System.Drawing.Size(201, 23);
			this.PerformanceDetailsLabel.TabIndex = 0;
			this.PerformanceDetailsLabel.Text = "Performance Details";
			// 
			// NameLabel
			// 
			this.NameLabel.AutoSize = true;
			this.NameLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.NameLabel.Location = new System.Drawing.Point(7, 86);
			this.NameLabel.Name = "NameLabel";
			this.NameLabel.Size = new System.Drawing.Size(52, 17);
			this.NameLabel.TabIndex = 1;
			this.NameLabel.Text = "Name:";
			// 
			// DateLabel
			// 
			this.DateLabel.AutoSize = true;
			this.DateLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.DateLabel.Location = new System.Drawing.Point(7, 132);
			this.DateLabel.Name = "DateLabel";
			this.DateLabel.Size = new System.Drawing.Size(43, 17);
			this.DateLabel.TabIndex = 2;
			this.DateLabel.Text = "Date:";
			// 
			// HourLabel
			// 
			this.HourLabel.AutoSize = true;
			this.HourLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.HourLabel.Location = new System.Drawing.Point(6, 183);
			this.HourLabel.Name = "HourLabel";
			this.HourLabel.Size = new System.Drawing.Size(44, 17);
			this.HourLabel.TabIndex = 3;
			this.HourLabel.Text = "Hour:";
			// 
			// DateLabelWrite
			// 
			this.DateLabelWrite.AutoSize = true;
			this.DateLabelWrite.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.DateLabelWrite.Location = new System.Drawing.Point(19, 469);
			this.DateLabelWrite.Name = "DateLabelWrite";
			this.DateLabelWrite.Size = new System.Drawing.Size(52, 23);
			this.DateLabelWrite.TabIndex = 3;
			this.DateLabelWrite.Text = "Date";
			// 
			// HourLabelWrite
			// 
			this.HourLabelWrite.AutoSize = true;
			this.HourLabelWrite.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.HourLabelWrite.Location = new System.Drawing.Point(19, 514);
			this.HourLabelWrite.Name = "HourLabelWrite";
			this.HourLabelWrite.Size = new System.Drawing.Size(56, 23);
			this.HourLabelWrite.TabIndex = 4;
			this.HourLabelWrite.Text = "Hour";
			// 
			// NameLabelWrite
			// 
			this.NameLabelWrite.AutoSize = true;
			this.NameLabelWrite.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.NameLabelWrite.Location = new System.Drawing.Point(19, 421);
			this.NameLabelWrite.Name = "NameLabelWrite";
			this.NameLabelWrite.Size = new System.Drawing.Size(64, 23);
			this.NameLabelWrite.TabIndex = 5;
			this.NameLabelWrite.Text = "Name";
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.textBox1.Location = new System.Drawing.Point(132, 421);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(418, 29);
			this.textBox1.TabIndex = 6;
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.textBox2.Location = new System.Drawing.Point(132, 466);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(418, 29);
			this.textBox2.TabIndex = 7;
			// 
			// textBox3
			// 
			this.textBox3.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.textBox3.Location = new System.Drawing.Point(132, 508);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(418, 29);
			this.textBox3.TabIndex = 8;
			// 
			// AddPerformancesButton
			// 
			this.AddPerformancesButton.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.AddPerformancesButton.Location = new System.Drawing.Point(565, 337);
			this.AddPerformancesButton.Name = "AddPerformancesButton";
			this.AddPerformancesButton.Size = new System.Drawing.Size(160, 57);
			this.AddPerformancesButton.TabIndex = 9;
			this.AddPerformancesButton.Text = "Add";
			this.AddPerformancesButton.UseVisualStyleBackColor = true;
			// 
			// DeleteButton
			// 
			this.DeleteButton.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.DeleteButton.Location = new System.Drawing.Point(678, 407);
			this.DeleteButton.Name = "DeleteButton";
			this.DeleteButton.Size = new System.Drawing.Size(160, 57);
			this.DeleteButton.TabIndex = 10;
			this.DeleteButton.Text = "Delete";
			this.DeleteButton.UseVisualStyleBackColor = true;
			// 
			// UpdateButton
			// 
			this.UpdateButton.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.UpdateButton.Location = new System.Drawing.Point(797, 480);
			this.UpdateButton.Name = "UpdateButton";
			this.UpdateButton.Size = new System.Drawing.Size(160, 57);
			this.UpdateButton.TabIndex = 11;
			this.UpdateButton.Text = "Update";
			this.UpdateButton.UseVisualStyleBackColor = true;
			// 
			// RowLabel
			// 
			this.RowLabel.AutoSize = true;
			this.RowLabel.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.RowLabel.Location = new System.Drawing.Point(202, 371);
			this.RowLabel.Name = "RowLabel";
			this.RowLabel.Size = new System.Drawing.Size(56, 23);
			this.RowLabel.TabIndex = 12;
			this.RowLabel.Text = "Row:";
			// 
			// AdminMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(969, 566);
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
			this.Name = "AdminMenu";
			this.Text = "AdminMenu";
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
	}
}