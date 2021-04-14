
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
			this.label1.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.label1.Location = new System.Drawing.Point(6, 115);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(106, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Username";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.label2.Location = new System.Drawing.Point(6, 174);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(102, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Password";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.label3.Location = new System.Drawing.Point(6, 50);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Email";
			// 
			// EmailTextBox
			// 
			this.EmailTextBox.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.EmailTextBox.Location = new System.Drawing.Point(118, 44);
			this.EmailTextBox.Name = "EmailTextBox";
			this.EmailTextBox.Size = new System.Drawing.Size(349, 29);
			this.EmailTextBox.TabIndex = 3;
			// 
			// UsernameTextBox
			// 
			this.UsernameTextBox.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.UsernameTextBox.Location = new System.Drawing.Point(118, 109);
			this.UsernameTextBox.Name = "UsernameTextBox";
			this.UsernameTextBox.Size = new System.Drawing.Size(349, 29);
			this.UsernameTextBox.TabIndex = 4;
			// 
			// PasswordTextBox
			// 
			this.PasswordTextBox.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.PasswordTextBox.Location = new System.Drawing.Point(118, 174);
			this.PasswordTextBox.Name = "PasswordTextBox";
			this.PasswordTextBox.Size = new System.Drawing.Size(349, 29);
			this.PasswordTextBox.TabIndex = 5;
			// 
			// RegisterButton
			// 
			this.RegisterButton.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.RegisterButton.Location = new System.Drawing.Point(10, 260);
			this.RegisterButton.Name = "RegisterButton";
			this.RegisterButton.Size = new System.Drawing.Size(178, 62);
			this.RegisterButton.TabIndex = 6;
			this.RegisterButton.Text = "Register";
			this.RegisterButton.UseVisualStyleBackColor = true;
			// 
			// BackButton
			// 
			this.BackButton.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.BackButton.Location = new System.Drawing.Point(289, 259);
			this.BackButton.Name = "BackButton";
			this.BackButton.Size = new System.Drawing.Size(178, 63);
			this.BackButton.TabIndex = 7;
			this.BackButton.Text = "Back";
			this.BackButton.UseVisualStyleBackColor = true;
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
			this.RegisterGroupBox.Location = new System.Drawing.Point(12, 12);
			this.RegisterGroupBox.Name = "RegisterGroupBox";
			this.RegisterGroupBox.Size = new System.Drawing.Size(487, 349);
			this.RegisterGroupBox.TabIndex = 0;
			this.RegisterGroupBox.TabStop = false;
			// 
			// RegisterForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(508, 373);
			this.Controls.Add(this.RegisterGroupBox);
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