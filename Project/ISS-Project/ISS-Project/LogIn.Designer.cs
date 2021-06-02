
namespace ISS_Project
{
	partial class LogInForm
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
			this.NameLogInLabel = new System.Windows.Forms.Label();
			this.PasswordLogInLabel = new System.Windows.Forms.Label();
			this.LogInButton = new System.Windows.Forms.Button();
			this.UsernameTextBox = new System.Windows.Forms.TextBox();
			this.PasswordTextBox = new System.Windows.Forms.TextBox();
			this.SingInGroupBox = new System.Windows.Forms.GroupBox();
			this.AdminButton = new System.Windows.Forms.Button();
			this.RegisterButton = new System.Windows.Forms.Button();
			this.SingInGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// NameLogInLabel
			// 
			this.NameLogInLabel.AutoSize = true;
			this.NameLogInLabel.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
			this.NameLogInLabel.Location = new System.Drawing.Point(23, 54);
			this.NameLogInLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.NameLogInLabel.Name = "NameLogInLabel";
			this.NameLogInLabel.Size = new System.Drawing.Size(106, 23);
			this.NameLogInLabel.TabIndex = 0;
			this.NameLogInLabel.Text = "Username";
			// 
			// PasswordLogInLabel
			// 
			this.PasswordLogInLabel.AutoSize = true;
			this.PasswordLogInLabel.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
			this.PasswordLogInLabel.Location = new System.Drawing.Point(23, 119);
			this.PasswordLogInLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.PasswordLogInLabel.Name = "PasswordLogInLabel";
			this.PasswordLogInLabel.Size = new System.Drawing.Size(102, 23);
			this.PasswordLogInLabel.TabIndex = 1;
			this.PasswordLogInLabel.Text = "Password";
			// 
			// LogInButton
			// 
			this.LogInButton.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
			this.LogInButton.Location = new System.Drawing.Point(23, 187);
			this.LogInButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.LogInButton.Name = "LogInButton";
			this.LogInButton.Size = new System.Drawing.Size(119, 44);
			this.LogInButton.TabIndex = 2;
			this.LogInButton.Text = "Log In";
			this.LogInButton.UseVisualStyleBackColor = true;
			this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
			// 
			// UsernameTextBox
			// 
			this.UsernameTextBox.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
			this.UsernameTextBox.Location = new System.Drawing.Point(167, 54);
			this.UsernameTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.UsernameTextBox.Name = "UsernameTextBox";
			this.UsernameTextBox.Size = new System.Drawing.Size(350, 29);
			this.UsernameTextBox.TabIndex = 3;
			// 
			// PasswordTextBox
			// 
			this.PasswordTextBox.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
			this.PasswordTextBox.Location = new System.Drawing.Point(167, 119);
			this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.PasswordTextBox.Name = "PasswordTextBox";
			this.PasswordTextBox.PasswordChar = '*';
			this.PasswordTextBox.Size = new System.Drawing.Size(350, 29);
			this.PasswordTextBox.TabIndex = 4;
			// 
			// SingInGroupBox
			// 
			this.SingInGroupBox.Controls.Add(this.AdminButton);
			this.SingInGroupBox.Controls.Add(this.RegisterButton);
			this.SingInGroupBox.Controls.Add(this.PasswordTextBox);
			this.SingInGroupBox.Controls.Add(this.UsernameTextBox);
			this.SingInGroupBox.Controls.Add(this.LogInButton);
			this.SingInGroupBox.Controls.Add(this.PasswordLogInLabel);
			this.SingInGroupBox.Controls.Add(this.NameLogInLabel);
			this.SingInGroupBox.Location = new System.Drawing.Point(15, 12);
			this.SingInGroupBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.SingInGroupBox.Name = "SingInGroupBox";
			this.SingInGroupBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.SingInGroupBox.Size = new System.Drawing.Size(561, 276);
			this.SingInGroupBox.TabIndex = 5;
			this.SingInGroupBox.TabStop = false;
			this.SingInGroupBox.Enter += new System.EventHandler(this.SingInGroupBox_Enter);
			// 
			// AdminButton
			// 
			this.AdminButton.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
			this.AdminButton.Location = new System.Drawing.Point(399, 187);
			this.AdminButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.AdminButton.Name = "AdminButton";
			this.AdminButton.Size = new System.Drawing.Size(119, 42);
			this.AdminButton.TabIndex = 6;
			this.AdminButton.Text = "Admin";
			this.AdminButton.UseVisualStyleBackColor = true;
			this.AdminButton.Click += new System.EventHandler(this.AdminButton_Click);
			// 
			// RegisterButton
			// 
			this.RegisterButton.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
			this.RegisterButton.Location = new System.Drawing.Point(215, 187);
			this.RegisterButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.RegisterButton.Name = "RegisterButton";
			this.RegisterButton.Size = new System.Drawing.Size(119, 44);
			this.RegisterButton.TabIndex = 5;
			this.RegisterButton.Text = "Register";
			this.RegisterButton.UseVisualStyleBackColor = true;
			this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
			// 
			// LogInForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(589, 309);
			this.Controls.Add(this.SingInGroupBox);
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.Name = "LogInForm";
			this.Text = "LogIn";
			this.SingInGroupBox.ResumeLayout(false);
			this.SingInGroupBox.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label NameLogInLabel;
		private System.Windows.Forms.Label PasswordLogInLabel;
		private System.Windows.Forms.Button LogInButton;
		private System.Windows.Forms.TextBox UsernameTextBox;
		private System.Windows.Forms.TextBox PasswordTextBox;
		private System.Windows.Forms.GroupBox SingInGroupBox;
		private System.Windows.Forms.Button AdminButton;
		private System.Windows.Forms.Button RegisterButton;
	}
}

