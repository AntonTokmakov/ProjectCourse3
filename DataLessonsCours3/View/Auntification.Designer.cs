namespace DataLessonsCours3.View
{
	partial class Auntification
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Auntification));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.lbTitle = new System.Windows.Forms.Label();
			this.tbPassword = new Guna.UI2.WinForms.Guna2TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tbLogin = new Guna.UI2.WinForms.Guna2TextBox();
			this.btnSave = new Guna.UI2.WinForms.Guna2Button();
			this.lbRegistration = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.tbFirstName = new Guna.UI2.WinForms.Guna2TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.tbName = new Guna.UI2.WinForms.Guna2TextBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(9, 9);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(220, 61);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// lbTitle
			// 
			this.lbTitle.AutoSize = true;
			this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lbTitle.ForeColor = System.Drawing.Color.White;
			this.lbTitle.Location = new System.Drawing.Point(144, 106);
			this.lbTitle.Name = "lbTitle";
			this.lbTitle.Size = new System.Drawing.Size(272, 46);
			this.lbTitle.TabIndex = 2;
			this.lbTitle.Text = "Авторизация";
			// 
			// tbPassword
			// 
			this.tbPassword.Animated = true;
			this.tbPassword.BorderRadius = 5;
			this.tbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbPassword.DefaultText = "";
			this.tbPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.tbPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbPassword.DisabledState.Parent = this.tbPassword;
			this.tbPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(230)))), ((int)(((byte)(166)))));
			this.tbPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbPassword.FocusedState.Parent = this.tbPassword;
			this.tbPassword.ForeColor = System.Drawing.Color.Black;
			this.tbPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbPassword.HoverState.Parent = this.tbPassword;
			this.tbPassword.Location = new System.Drawing.Point(36, 53);
			this.tbPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tbPassword.MaxLength = 50;
			this.tbPassword.Name = "tbPassword";
			this.tbPassword.PasswordChar = '\0';
			this.tbPassword.PlaceholderText = "";
			this.tbPassword.SelectedText = "";
			this.tbPassword.ShadowDecoration.Parent = this.tbPassword;
			this.tbPassword.Size = new System.Drawing.Size(443, 44);
			this.tbPassword.TabIndex = 3;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.tbLogin);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.tbPassword);
			this.panel1.Location = new System.Drawing.Point(12, 170);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(522, 201);
			this.panel1.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(40, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(120, 36);
			this.label1.TabIndex = 4;
			this.label1.Text = "Пароль";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(40, 110);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(103, 36);
			this.label2.TabIndex = 6;
			this.label2.Text = "Логин";
			// 
			// tbLogin
			// 
			this.tbLogin.Animated = true;
			this.tbLogin.BorderRadius = 5;
			this.tbLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbLogin.DefaultText = "";
			this.tbLogin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.tbLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbLogin.DisabledState.Parent = this.tbLogin;
			this.tbLogin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(230)))), ((int)(((byte)(166)))));
			this.tbLogin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbLogin.FocusedState.Parent = this.tbLogin;
			this.tbLogin.ForeColor = System.Drawing.Color.Black;
			this.tbLogin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbLogin.HoverState.Parent = this.tbLogin;
			this.tbLogin.Location = new System.Drawing.Point(36, 150);
			this.tbLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tbLogin.MaxLength = 50;
			this.tbLogin.Name = "tbLogin";
			this.tbLogin.PasswordChar = '\0';
			this.tbLogin.PlaceholderText = "";
			this.tbLogin.SelectedText = "";
			this.tbLogin.ShadowDecoration.Parent = this.tbLogin;
			this.tbLogin.Size = new System.Drawing.Size(443, 44);
			this.tbLogin.TabIndex = 5;
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.Color.Transparent;
			this.btnSave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(230)))), ((int)(((byte)(166)))));
			this.btnSave.BorderRadius = 25;
			this.btnSave.BorderThickness = 3;
			this.btnSave.CheckedState.Parent = this.btnSave;
			this.btnSave.CustomImages.Parent = this.btnSave;
			this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(230)))), ((int)(((byte)(166)))));
			this.btnSave.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnSave.ForeColor = System.Drawing.Color.Black;
			this.btnSave.HoverState.Parent = this.btnSave;
			this.btnSave.Location = new System.Drawing.Point(128, 50);
			this.btnSave.Name = "btnSave";
			this.btnSave.ShadowDecoration.Parent = this.btnSave;
			this.btnSave.Size = new System.Drawing.Size(225, 64);
			this.btnSave.TabIndex = 13;
			this.btnSave.Text = "Сохранить";
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// lbRegistration
			// 
			this.lbRegistration.AutoSize = true;
			this.lbRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lbRegistration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(179)))), ((int)(((byte)(201)))));
			this.lbRegistration.Location = new System.Drawing.Point(173, 16);
			this.lbRegistration.Name = "lbRegistration";
			this.lbRegistration.Size = new System.Drawing.Size(131, 25);
			this.lbRegistration.TabIndex = 7;
			this.lbRegistration.Text = "Регистрация";
			this.lbRegistration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lbRegistration.Click += new System.EventHandler(this.lbRegistration_Click);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.tbFirstName);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.tbName);
			this.panel2.Location = new System.Drawing.Point(9, 529);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(522, 197);
			this.panel2.TabIndex = 7;
			this.panel2.Visible = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(40, 105);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(124, 29);
			this.label3.TabIndex = 6;
			this.label3.Text = "Фамилия";
			// 
			// tbFirstName
			// 
			this.tbFirstName.Animated = true;
			this.tbFirstName.BorderRadius = 5;
			this.tbFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbFirstName.DefaultText = "";
			this.tbFirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbFirstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.tbFirstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbFirstName.DisabledState.Parent = this.tbFirstName;
			this.tbFirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbFirstName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(230)))), ((int)(((byte)(166)))));
			this.tbFirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbFirstName.FocusedState.Parent = this.tbFirstName;
			this.tbFirstName.ForeColor = System.Drawing.Color.Black;
			this.tbFirstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbFirstName.HoverState.Parent = this.tbFirstName;
			this.tbFirstName.Location = new System.Drawing.Point(36, 145);
			this.tbFirstName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tbFirstName.MaxLength = 50;
			this.tbFirstName.Name = "tbFirstName";
			this.tbFirstName.PasswordChar = '\0';
			this.tbFirstName.PlaceholderText = "";
			this.tbFirstName.SelectedText = "";
			this.tbFirstName.ShadowDecoration.Parent = this.tbFirstName;
			this.tbFirstName.Size = new System.Drawing.Size(443, 44);
			this.tbFirstName.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(40, 8);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(64, 29);
			this.label4.TabIndex = 4;
			this.label4.Text = "Имя";
			// 
			// tbName
			// 
			this.tbName.Animated = true;
			this.tbName.BorderRadius = 5;
			this.tbName.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbName.DefaultText = "";
			this.tbName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.tbName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbName.DisabledState.Parent = this.tbName;
			this.tbName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(230)))), ((int)(((byte)(166)))));
			this.tbName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbName.FocusedState.Parent = this.tbName;
			this.tbName.ForeColor = System.Drawing.Color.Black;
			this.tbName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbName.HoverState.Parent = this.tbName;
			this.tbName.Location = new System.Drawing.Point(36, 48);
			this.tbName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tbName.MaxLength = 50;
			this.tbName.Name = "tbName";
			this.tbName.PasswordChar = '\0';
			this.tbName.PlaceholderText = "";
			this.tbName.SelectedText = "";
			this.tbName.ShadowDecoration.Parent = this.tbName;
			this.tbName.Size = new System.Drawing.Size(443, 44);
			this.tbName.TabIndex = 3;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.btnSave);
			this.panel3.Controls.Add(this.lbRegistration);
			this.panel3.Location = new System.Drawing.Point(15, 377);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(519, 142);
			this.panel3.TabIndex = 14;
			// 
			// notifyIcon1
			// 
			this.notifyIcon1.Text = "notifyIcon1";
			this.notifyIcon1.Visible = true;
			// 
			// Auntification
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(38)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(546, 738);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.lbTitle);
			this.Controls.Add(this.pictureBox1);
			this.Name = "Auntification";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Auntification";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label lbTitle;
		private Guna.UI2.WinForms.Guna2TextBox tbPassword;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label2;
		private Guna.UI2.WinForms.Guna2TextBox tbLogin;
		private System.Windows.Forms.Label label1;
		private Guna.UI2.WinForms.Guna2Button btnSave;
		private System.Windows.Forms.Label lbRegistration;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label3;
		private Guna.UI2.WinForms.Guna2TextBox tbFirstName;
		private System.Windows.Forms.Label label4;
		private Guna.UI2.WinForms.Guna2TextBox tbName;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.NotifyIcon notifyIcon1;
	}
}