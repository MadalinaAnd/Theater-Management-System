
namespace ISS_Project
{
	partial class RegisterForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.EmailTextBox = new System.Windows.Forms.TextBox();
			this.UsernameTextBox = new System.Windows.Forms.TextBox();
			this.PasswordTextBox = new System.Windows.Forms.TextBox();
			this.RegisterButton = new System.Windows.Forms.Button();
			this.BackButton = new System.Windows.Forms.Button();
			this.RegisterGroupBox = new System.Windows.Forms.GroupBox();
			this.RegisterGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(7, 133);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(106, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Username";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
			this.label2.Location = new System.Drawing.Point(7, 201);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(102, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Password";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
			this.label3.Location = new System.Drawing.Point(7, 58);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Email";
			// 
			// EmailTextBox
			// 
			this.EmailTextBox.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
			this.EmailTextBox.Location = new System.Drawing.Point(138, 51);
			this.EmailTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.EmailTextBox.Name = "EmailTextBox";
			this.EmailTextBox.Size = new System.Drawing.Size(406, 29);
			this.EmailTextBox.TabIndex = 3;
			// 
			// UsernameTextBox
			// 
			this.UsernameTextBox.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
			this.UsernameTextBox.Location = new System.Drawing.Point(138, 126);
			this.UsernameTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.UsernameTextBox.Name = "UsernameTextBox";
			this.UsernameTextBox.Size = new System.Drawing.Size(406, 29);
			this.UsernameTextBox.TabIndex = 4;
			// 
			// PasswordTextBox
			// 
			this.PasswordTextBox.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
			this.PasswordTextBox.Location = new System.Drawing.Point(138, 201);
			this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.PasswordTextBox.Name = "PasswordTextBox";
			this.PasswordTextBox.Size = new System.Drawing.Size(406, 29);
			this.PasswordTextBox.TabIndex = 5;
			// 
			// RegisterButton
			// 
			this.RegisterButton.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
			this.RegisterButton.Location = new System.Drawing.Point(12, 300);
			this.RegisterButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.RegisterButton.Name = "RegisterButton";
			this.RegisterButton.Size = new System.Drawing.Size(208, 72);
			this.RegisterButton.TabIndex = 6;
			this.RegisterButton.Text = "Register";
			this.RegisterButton.UseVisualStyleBackColor = true;
			this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
			// 
			// BackButton
			// 
			this.BackButton.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
			this.BackButton.Location = new System.Drawing.Point(337, 299);
			this.BackButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.BackButton.Name = "BackButton";
			this.BackButton.Size = new System.Drawing.Size(208, 73);
			this.BackButton.TabIndex = 7;
			this.BackButton.Text = "Back";
			this.BackButton.UseVisualStyleBackColor = true;
			this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
			// 
			// RegisterGroupBox
			// 
			this.RegisterGroupBox.Controls.Add(this.BackButton);
			this.RegisterGroupBox.Controls.Add(this.RegisterButton);
			this.RegisterGroupBox.Controls.Add(this.PasswordTextBox);
			this.RegisterGroupBox.Controls.Add(this.UsernameTextBox);
			this.RegisterGroupBox.Controls.Add(this.EmailTextBox);
			this.RegisterGroupBox.Controls.Add(this.label3);
			this.RegisterGroupBox.Controls.Add(this.label2);
			this.RegisterGroupBox.Controls.Add(this.label1);
			this.RegisterGroupBox.Location = new System.Drawing.Point(14, 14);
			this.RegisterGroupBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.RegisterGroupBox.Name = "RegisterGroupBox";
			this.RegisterGroupBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.RegisterGroupBox.Size = new System.Drawing.Size(568, 403);
			this.RegisterGroupBox.TabIndex = 0;
			this.RegisterGroupBox.TabStop = false;
			// 
			// RegisterForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(593, 430);
			this.Controls.Add(this.RegisterGroupBox);
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.Name = "RegisterForm";
			this.Text = "Register";
			this.RegisterGroupBox.ResumeLayout(false);
			this.RegisterGroupBox.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox EmailTextBox;
		private System.Windows.Forms.TextBox UsernameTextBox;
		private System.Windows.Forms.TextBox PasswordTextBox;
		private System.Windows.Forms.Button RegisterButton;
		private System.Windows.Forms.Button BackButton;
		private System.Windows.Forms.GroupBox RegisterGroupBox;
	}
}