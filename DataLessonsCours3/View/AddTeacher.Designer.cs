namespace DataLessonsCours3.View
{
	partial class AddTeacher
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
			this.gunaGradient2Panel5 = new Guna.UI.WinForms.GunaGradient2Panel();
			this.save = new Guna.UI2.WinForms.Guna2Button();
			this.exit = new Guna.UI2.WinForms.Guna2Button();
			this.cbCahedra = new Guna.UI2.WinForms.Guna2ComboBox();
			this.cathedraBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.timeTableDataSet3 = new DataLessonsCours3.timeTableDataSet3();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.tbOtchestvo = new Guna.UI2.WinForms.Guna2TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tbFirstName = new Guna.UI2.WinForms.Guna2TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tbName = new Guna.UI2.WinForms.Guna2TextBox();
			this.lbTitle = new System.Windows.Forms.Label();
			this.cathedraTableAdapter = new DataLessonsCours3.timeTableDataSet3TableAdapters.CathedraTableAdapter();
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			this.gunaGradient2Panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cathedraBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.timeTableDataSet3)).BeginInit();
			this.SuspendLayout();
			// 
			// gunaGradient2Panel5
			// 
			this.gunaGradient2Panel5.BackColor = System.Drawing.Color.Transparent;
			this.gunaGradient2Panel5.Controls.Add(this.save);
			this.gunaGradient2Panel5.Controls.Add(this.exit);
			this.gunaGradient2Panel5.Controls.Add(this.cbCahedra);
			this.gunaGradient2Panel5.Controls.Add(this.label5);
			this.gunaGradient2Panel5.Controls.Add(this.label4);
			this.gunaGradient2Panel5.Controls.Add(this.tbOtchestvo);
			this.gunaGradient2Panel5.Controls.Add(this.label3);
			this.gunaGradient2Panel5.Controls.Add(this.tbFirstName);
			this.gunaGradient2Panel5.Controls.Add(this.label2);
			this.gunaGradient2Panel5.Controls.Add(this.tbName);
			this.gunaGradient2Panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.gunaGradient2Panel5.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(101)))), ((int)(((byte)(143)))));
			this.gunaGradient2Panel5.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(101)))), ((int)(((byte)(143)))));
			this.gunaGradient2Panel5.Location = new System.Drawing.Point(0, 123);
			this.gunaGradient2Panel5.Margin = new System.Windows.Forms.Padding(4);
			this.gunaGradient2Panel5.Name = "gunaGradient2Panel5";
			this.gunaGradient2Panel5.Radius = 10;
			this.gunaGradient2Panel5.Size = new System.Drawing.Size(500, 584);
			this.gunaGradient2Panel5.TabIndex = 2;
			// 
			// save
			// 
			this.save.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(230)))), ((int)(((byte)(166)))));
			this.save.BorderRadius = 5;
			this.save.BorderThickness = 3;
			this.save.CheckedState.Parent = this.save;
			this.save.CustomImages.Parent = this.save;
			this.save.FillColor = System.Drawing.Color.Transparent;
			this.save.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.save.ForeColor = System.Drawing.Color.White;
			this.save.HoverState.Parent = this.save;
			this.save.Location = new System.Drawing.Point(311, 512);
			this.save.Name = "save";
			this.save.ShadowDecoration.Parent = this.save;
			this.save.Size = new System.Drawing.Size(180, 45);
			this.save.TabIndex = 12;
			this.save.Text = "Сохранить";
			this.save.Click += new System.EventHandler(this.save_Click);
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
			this.exit.Location = new System.Drawing.Point(17, 512);
			this.exit.Name = "exit";
			this.exit.ShadowDecoration.Parent = this.exit;
			this.exit.Size = new System.Drawing.Size(180, 45);
			this.exit.TabIndex = 11;
			this.exit.Text = "Отмена";
			this.exit.Click += new System.EventHandler(this.exit_Click);
			// 
			// cbCahedra
			// 
			this.cbCahedra.Animated = true;
			this.cbCahedra.BackColor = System.Drawing.Color.Transparent;
			this.cbCahedra.DataSource = this.cathedraBindingSource;
			this.cbCahedra.DisplayMember = "shortName";
			this.cbCahedra.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbCahedra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbCahedra.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(230)))), ((int)(((byte)(166)))));
			this.cbCahedra.FocusedColor = System.Drawing.Color.Empty;
			this.cbCahedra.FocusedState.Parent = this.cbCahedra;
			this.cbCahedra.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.cbCahedra.ForeColor = System.Drawing.Color.Black;
			this.cbCahedra.FormattingEnabled = true;
			this.cbCahedra.HoverState.Parent = this.cbCahedra;
			this.cbCahedra.ItemHeight = 30;
			this.cbCahedra.ItemsAppearance.Parent = this.cbCahedra;
			this.cbCahedra.Location = new System.Drawing.Point(17, 407);
			this.cbCahedra.MaxLength = 150;
			this.cbCahedra.Name = "cbCahedra";
			this.cbCahedra.ShadowDecoration.Parent = this.cbCahedra;
			this.cbCahedra.Size = new System.Drawing.Size(474, 36);
			this.cbCahedra.TabIndex = 10;
			this.cbCahedra.ValueMember = "id_cathedra";
			// 
			// cathedraBindingSource
			// 
			this.cathedraBindingSource.DataMember = "Cathedra";
			this.cathedraBindingSource.DataSource = this.timeTableDataSet3;
			// 
			// timeTableDataSet3
			// 
			this.timeTableDataSet3.DataSetName = "timeTableDataSet3";
			this.timeTableDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(12, 361);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(282, 43);
			this.label5.TabIndex = 9;
			this.label5.Text = "Выбирите кафедру";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(12, 249);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(282, 43);
			this.label4.TabIndex = 8;
			this.label4.Text = "Введите отчество";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tbOtchestvo
			// 
			this.tbOtchestvo.Animated = true;
			this.tbOtchestvo.BorderRadius = 5;
			this.tbOtchestvo.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbOtchestvo.DefaultText = "";
			this.tbOtchestvo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbOtchestvo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.tbOtchestvo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbOtchestvo.DisabledState.Parent = this.tbOtchestvo;
			this.tbOtchestvo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbOtchestvo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(230)))), ((int)(((byte)(166)))));
			this.tbOtchestvo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbOtchestvo.FocusedState.Parent = this.tbOtchestvo;
			this.tbOtchestvo.ForeColor = System.Drawing.Color.Black;
			this.tbOtchestvo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbOtchestvo.HoverState.Parent = this.tbOtchestvo;
			this.tbOtchestvo.Location = new System.Drawing.Point(13, 296);
			this.tbOtchestvo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tbOtchestvo.MaxLength = 30;
			this.tbOtchestvo.Name = "tbOtchestvo";
			this.tbOtchestvo.PasswordChar = '\0';
			this.tbOtchestvo.PlaceholderText = "";
			this.tbOtchestvo.SelectedText = "";
			this.tbOtchestvo.ShadowDecoration.Parent = this.tbOtchestvo;
			this.tbOtchestvo.Size = new System.Drawing.Size(478, 44);
			this.tbOtchestvo.TabIndex = 7;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(12, 141);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(282, 43);
			this.label3.TabIndex = 6;
			this.label3.Text = "Введите фамилию";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			this.tbFirstName.Location = new System.Drawing.Point(13, 188);
			this.tbFirstName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tbFirstName.MaxLength = 20;
			this.tbFirstName.Name = "tbFirstName";
			this.tbFirstName.PasswordChar = '\0';
			this.tbFirstName.PlaceholderText = "";
			this.tbFirstName.SelectedText = "";
			this.tbFirstName.ShadowDecoration.Parent = this.tbFirstName;
			this.tbFirstName.Size = new System.Drawing.Size(478, 44);
			this.tbFirstName.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(12, 36);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(282, 43);
			this.label2.TabIndex = 4;
			this.label2.Text = "Введите имя";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			this.tbName.Location = new System.Drawing.Point(13, 83);
			this.tbName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tbName.MaxLength = 20;
			this.tbName.Name = "tbName";
			this.tbName.PasswordChar = '\0';
			this.tbName.PlaceholderText = "";
			this.tbName.SelectedText = "";
			this.tbName.ShadowDecoration.Parent = this.tbName;
			this.tbName.Size = new System.Drawing.Size(478, 44);
			this.tbName.TabIndex = 0;
			// 
			// lbTitle
			// 
			this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lbTitle.ForeColor = System.Drawing.Color.White;
			this.lbTitle.Location = new System.Drawing.Point(0, 9);
			this.lbTitle.MaximumSize = new System.Drawing.Size(511, 102);
			this.lbTitle.MinimumSize = new System.Drawing.Size(511, 102);
			this.lbTitle.Name = "lbTitle";
			this.lbTitle.Size = new System.Drawing.Size(511, 102);
			this.lbTitle.TabIndex = 3;
			this.lbTitle.Text = "Добавить преподавателя";
			this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cathedraTableAdapter
			// 
			this.cathedraTableAdapter.ClearBeforeFill = true;
			// 
			// notifyIcon1
			// 
			this.notifyIcon1.Text = "notifyIcon1";
			this.notifyIcon1.Visible = true;
			// 
			// AddTeacher
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(38)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(500, 707);
			this.Controls.Add(this.lbTitle);
			this.Controls.Add(this.gunaGradient2Panel5);
			this.MaximumSize = new System.Drawing.Size(518, 754);
			this.MinimumSize = new System.Drawing.Size(518, 754);
			this.Name = "AddTeacher";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AddTeacher";
			this.Load += new System.EventHandler(this.AddTeacher_Load);
			this.gunaGradient2Panel5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cathedraBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.timeTableDataSet3)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Guna.UI.WinForms.GunaGradient2Panel gunaGradient2Panel5;
		private Guna.UI2.WinForms.Guna2Button save;
		private Guna.UI2.WinForms.Guna2Button exit;
		private Guna.UI2.WinForms.Guna2ComboBox cbCahedra;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private Guna.UI2.WinForms.Guna2TextBox tbOtchestvo;
		private System.Windows.Forms.Label label3;
		private Guna.UI2.WinForms.Guna2TextBox tbFirstName;
		private System.Windows.Forms.Label label2;
		private Guna.UI2.WinForms.Guna2TextBox tbName;
		private System.Windows.Forms.Label lbTitle;
		private timeTableDataSet3 timeTableDataSet3;
		private System.Windows.Forms.BindingSource cathedraBindingSource;
		private timeTableDataSet3TableAdapters.CathedraTableAdapter cathedraTableAdapter;
		private System.Windows.Forms.NotifyIcon notifyIcon1;
	}
}