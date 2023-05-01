namespace DataLessonsCours3.View
{
	partial class MessageForm
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
			this.gunaGradient2Panel5 = new Guna.UI.WinForms.GunaGradient2Panel();
			this.exit = new Guna.UI2.WinForms.Guna2Button();
			this.save = new Guna.UI2.WinForms.Guna2Button();
			this.lbText = new System.Windows.Forms.Label();
			this.lbTitle = new System.Windows.Forms.Label();
			this.gunaGradient2Panel5.SuspendLayout();
			this.SuspendLayout();
			// 
			// gunaGradient2Panel5
			// 
			this.gunaGradient2Panel5.BackColor = System.Drawing.Color.Transparent;
			this.gunaGradient2Panel5.Controls.Add(this.exit);
			this.gunaGradient2Panel5.Controls.Add(this.save);
			this.gunaGradient2Panel5.Controls.Add(this.lbText);
			this.gunaGradient2Panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.gunaGradient2Panel5.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(101)))), ((int)(((byte)(143)))));
			this.gunaGradient2Panel5.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(101)))), ((int)(((byte)(143)))));
			this.gunaGradient2Panel5.Location = new System.Drawing.Point(0, 76);
			this.gunaGradient2Panel5.Margin = new System.Windows.Forms.Padding(4);
			this.gunaGradient2Panel5.Name = "gunaGradient2Panel5";
			this.gunaGradient2Panel5.Radius = 10;
			this.gunaGradient2Panel5.Size = new System.Drawing.Size(685, 218);
			this.gunaGradient2Panel5.TabIndex = 2;
			// 
			// exit
			// 
			this.exit.BorderRadius = 5;
			this.exit.CheckedState.Parent = this.exit;
			this.exit.CustomImages.Parent = this.exit;
			this.exit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(70)))), ((int)(((byte)(121)))));
			this.exit.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.exit.ForeColor = System.Drawing.Color.White;
			this.exit.HoverState.Parent = this.exit;
			this.exit.Location = new System.Drawing.Point(36, 145);
			this.exit.Name = "exit";
			this.exit.ShadowDecoration.Parent = this.exit;
			this.exit.Size = new System.Drawing.Size(196, 46);
			this.exit.TabIndex = 14;
			this.exit.Text = "Отмена";
			this.exit.Click += new System.EventHandler(this.exit_Click);
			// 
			// save
			// 
			this.save.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(230)))), ((int)(((byte)(166)))));
			this.save.BorderRadius = 5;
			this.save.BorderThickness = 3;
			this.save.CheckedState.Parent = this.save;
			this.save.CustomImages.Parent = this.save;
			this.save.FillColor = System.Drawing.Color.Transparent;
			this.save.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.save.ForeColor = System.Drawing.Color.White;
			this.save.HoverState.Parent = this.save;
			this.save.Location = new System.Drawing.Point(449, 145);
			this.save.Name = "save";
			this.save.ShadowDecoration.Parent = this.save;
			this.save.Size = new System.Drawing.Size(196, 46);
			this.save.TabIndex = 13;
			this.save.Text = "Ок";
			this.save.Click += new System.EventHandler(this.save_Click);
			// 
			// lbText
			// 
			this.lbText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lbText.ForeColor = System.Drawing.Color.White;
			this.lbText.Location = new System.Drawing.Point(61, 26);
			this.lbText.Name = "lbText";
			this.lbText.Size = new System.Drawing.Size(561, 107);
			this.lbText.TabIndex = 12;
			this.lbText.Text = "2";
			this.lbText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbTitle
			// 
			this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lbTitle.ForeColor = System.Drawing.Color.White;
			this.lbTitle.Location = new System.Drawing.Point(14, 9);
			this.lbTitle.Name = "lbTitle";
			this.lbTitle.Size = new System.Drawing.Size(659, 55);
			this.lbTitle.TabIndex = 11;
			this.lbTitle.Text = "Сообщение";
			this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MessageForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(84)))), ((int)(((byte)(117)))));
			this.ClientSize = new System.Drawing.Size(685, 294);
			this.Controls.Add(this.gunaGradient2Panel5);
			this.Controls.Add(this.lbTitle);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "MessageForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MessageForm";
			this.gunaGradient2Panel5.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Guna.UI.WinForms.GunaGradient2Panel gunaGradient2Panel5;
		private System.Windows.Forms.Label lbText;
		private System.Windows.Forms.Label lbTitle;
		private Guna.UI2.WinForms.Guna2Button save;
		private Guna.UI2.WinForms.Guna2Button exit;
	}
}