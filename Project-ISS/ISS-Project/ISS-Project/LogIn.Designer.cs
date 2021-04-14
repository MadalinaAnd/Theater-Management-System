
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
			this.NameLogInLabel = new System.Windows.Forms.Label();
			this.PasswordLogInLabel = new System.Windows.Forms.Label();
			this.LogInButton = new System.Windows.Forms.Button();
			this.UsernameTextBox = new System.Windows.Forms.TextBox();
			this.PasswordTextBox = new System.Windows.Forms.TextBox();
			this.SingInGroupBox = new System.Windows.Forms.GroupBox();
			this.RegisterButton = new System.Windows.Forms.Button();
			this.AdminButton = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.SingInGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// NameLogInLabel
			// 
			this.NameLogInLabel.AutoSize = true;
			this.NameLogInLabel.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.NameLogInLabel.Location = new System.Drawing.Point(20, 47);
			this.NameLogInLabel.Name = "NameLogInLabel";
			this.NameLogInLabel.Size = new System.Drawing.Size(106, 23);
			this.NameLogInLabel.TabIndex = 0;
			this.NameLogInLabel.Text = "Username";
			// 
			// PasswordLogInLabel
			// 
			this.PasswordLogInLabel.AutoSize = true;
			this.PasswordLogInLabel.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.PasswordLogInLabel.Location = new System.Drawing.Point(20, 103);
			this.PasswordLogInLabel.Name = "PasswordLogInLabel";
			this.PasswordLogInLabel.Size = new System.Drawing.Size(102, 23);
			this.PasswordLogInLabel.TabIndex = 1;
			this.PasswordLogInLabel.Text = "Password";
			// 
			// LogInButton
			// 
			this.LogInButton.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.LogInButton.Location = new System.Drawing.Point(20, 162);
			this.LogInButton.Name = "LogInButton";
			this.LogInButton.Size = new System.Drawing.Size(102, 38);
			this.LogInButton.TabIndex = 2;
			this.LogInButton.Text = "Log In";
			this.LogInButton.UseVisualStyleBackColor = true;
			// 
			// UsernameTextBox
			// 
			this.UsernameTextBox.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.UsernameTextBox.Location = new System.Drawing.Point(143, 47);
			this.UsernameTextBox.Name = "UsernameTextBox";
			this.UsernameTextBox.Size = new System.Drawing.Size(301, 29);
			this.UsernameTextBox.TabIndex = 3;
			// 
			// PasswordTextBox
			// 
			this.PasswordTextBox.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.PasswordTextBox.Location = new System.Drawing.Point(143, 103);
			this.PasswordTextBox.Name = "PasswordTextBox";
			this.PasswordTextBox.PasswordChar = '*';
			this.PasswordTextBox.Size = new System.Drawing.Size(301, 29);
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
			this.SingInGroupBox.Location = new System.Drawing.Point(12, 230);
			this.SingInGroupBox.Name = "SingInGroupBox";
			this.SingInGroupBox.Size = new System.Drawing.Size(481, 237);
			this.SingInGroupBox.TabIndex = 5;
			this.SingInGroupBox.TabStop = false;
			this.SingInGroupBox.Enter += new System.EventHandler(this.SingInGroupBox_Enter);
			// 
			// RegisterButton
			// 
			this.RegisterButton.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.RegisterButton.Location = new System.Drawing.Point(184, 162);
			this.RegisterButton.Name = "RegisterButton";
			this.RegisterButton.Size = new System.Drawing.Size(102, 38);
			this.RegisterButton.TabIndex = 5;
			this.RegisterButton.Text = "Register";
			this.RegisterButton.UseVisualStyleBackColor = true;
			// 
			// AdminButton
			// 
			this.AdminButton.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.AdminButton.Location = new System.Drawing.Point(342, 162);
			this.AdminButton.Name = "AdminButton";
			this.AdminButton.Size = new System.Drawing.Size(102, 36);
			this.AdminButton.TabIndex = 6;
			this.AdminButton.Text = "Admin";
			this.AdminButton.UseVisualStyleBackColor = true;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(141, 9);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(223, 221);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 6;
			this.pictureBox1.TabStop = false;
			// 
			// LogInForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(505, 478);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.SingInGroupBox);
			this.Name = "LogInForm";
			this.Text = "LogIn";
			this.SingInGroupBox.ResumeLayout(false);
			this.SingInGroupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}

