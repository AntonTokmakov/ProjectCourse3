namespace DataLessonsCours3.View
{
	partial class AddLesson
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
			this.lbTitle = new System.Windows.Forms.Label();
			this.gunaGradient2Panel5 = new Guna.UI.WinForms.GunaGradient2Panel();
			this.save = new Guna.UI2.WinForms.Guna2Button();
			this.exit = new Guna.UI2.WinForms.Guna2Button();
			this.cbCahedra = new Guna.UI2.WinForms.Guna2ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.tbLink = new Guna.UI2.WinForms.Guna2TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tbShortName = new Guna.UI2.WinForms.Guna2TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tbFullName = new Guna.UI2.WinForms.Guna2TextBox();
			this.timeTableDataSet3 = new DataLessonsCours3.timeTableDataSet3();
			this.timeTableDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.cathedraBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.cathedraTableAdapter = new DataLessonsCours3.timeTableDataSet3TableAdapters.CathedraTableAdapter();
			this.label1 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.numericUpDownLecsii = new Guna.UI2.WinForms.Guna2NumericUpDown();
			this.numericUpDownPractic = new Guna.UI2.WinForms.Guna2NumericUpDown();
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			this.gunaGradient2Panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.timeTableDataSet3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.timeTableDataSet3BindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cathedraBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownLecsii)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownPractic)).BeginInit();
			this.SuspendLayout();
			// 
			// lbTitle
			// 
			this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lbTitle.ForeColor = System.Drawing.Color.White;
			this.lbTitle.Location = new System.Drawing.Point(-7, 9);
			this.lbTitle.MaximumSize = new System.Drawing.Size(511, 102);
			this.lbTitle.MinimumSize = new System.Drawing.Size(511, 102);
			this.lbTitle.Name = "lbTitle";
			this.lbTitle.Size = new System.Drawing.Size(511, 102);
			this.lbTitle.TabIndex = 4;
			this.lbTitle.Text = "Добавить дисциплину";
			this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// gunaGradient2Panel5
			// 
			this.gunaGradient2Panel5.BackColor = System.Drawing.Color.Transparent;
			this.gunaGradient2Panel5.Controls.Add(this.numericUpDownPractic);
			this.gunaGradient2Panel5.Controls.Add(this.numericUpDownLecsii);
			this.gunaGradient2Panel5.Controls.Add(this.label6);
			this.gunaGradient2Panel5.Controls.Add(this.label1);
			this.gunaGradient2Panel5.Controls.Add(this.save);
			this.gunaGradient2Panel5.Controls.Add(this.exit);
			this.gunaGradient2Panel5.Controls.Add(this.cbCahedra);
			this.gunaGradient2Panel5.Controls.Add(this.label5);
			this.gunaGradient2Panel5.Controls.Add(this.label4);
			this.gunaGradient2Panel5.Controls.Add(this.tbLink);
			this.gunaGradient2Panel5.Controls.Add(this.label3);
			this.gunaGradient2Panel5.Controls.Add(this.tbShortName);
			this.gunaGradient2Panel5.Controls.Add(this.label2);
			this.gunaGradient2Panel5.Controls.Add(this.tbFullName);
			this.gunaGradient2Panel5.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(101)))), ((int)(((byte)(143)))));
			this.gunaGradient2Panel5.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(101)))), ((int)(((byte)(143)))));
			this.gunaGradient2Panel5.Location = new System.Drawing.Point(-1, 115);
			this.gunaGradient2Panel5.Margin = new System.Windows.Forms.Padding(4);
			this.gunaGradient2Panel5.Name = "gunaGradient2Panel5";
			this.gunaGradient2Panel5.Radius = 10;
			this.gunaGradient2Panel5.Size = new System.Drawing.Size(505, 661);
			this.gunaGradient2Panel5.TabIndex = 5;
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
			this.save.Location = new System.Drawing.Point(306, 592);
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
			this.exit.Location = new System.Drawing.Point(12, 592);
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
			this.cbCahedra.Location = new System.Drawing.Point(12, 407);
			this.cbCahedra.MaxLength = 150;
			this.cbCahedra.Name = "cbCahedra";
			this.cbCahedra.ShadowDecoration.Parent = this.cbCahedra;
			this.cbCahedra.Size = new System.Drawing.Size(474, 36);
			this.cbCahedra.TabIndex = 10;
			this.cbCahedra.ValueMember = "id_cathedra";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(12, 361);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(474, 43);
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
			this.label4.Size = new System.Drawing.Size(474, 43);
			this.label4.TabIndex = 8;
			this.label4.Text = "Ссылка на МУДЛ";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tbLink
			// 
			this.tbLink.Animated = true;
			this.tbLink.BorderRadius = 5;
			this.tbLink.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbLink.DefaultText = "";
			this.tbLink.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbLink.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.tbLink.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbLink.DisabledState.Parent = this.tbLink;
			this.tbLink.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbLink.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(230)))), ((int)(((byte)(166)))));
			this.tbLink.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbLink.FocusedState.Parent = this.tbLink;
			this.tbLink.ForeColor = System.Drawing.Color.Black;
			this.tbLink.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbLink.HoverState.Parent = this.tbLink;
			this.tbLink.Location = new System.Drawing.Point(13, 296);
			this.tbLink.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tbLink.MaxLength = 30;
			this.tbLink.Name = "tbLink";
			this.tbLink.PasswordChar = '\0';
			this.tbLink.PlaceholderText = "";
			this.tbLink.SelectedText = "";
			this.tbLink.ShadowDecoration.Parent = this.tbLink;
			this.tbLink.Size = new System.Drawing.Size(478, 44);
			this.tbLink.TabIndex = 7;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(12, 141);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(474, 43);
			this.label3.TabIndex = 6;
			this.label3.Text = "Краткое наименование дисциплины";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tbShortName
			// 
			this.tbShortName.Animated = true;
			this.tbShortName.BorderRadius = 5;
			this.tbShortName.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbShortName.DefaultText = "";
			this.tbShortName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbShortName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.tbShortName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbShortName.DisabledState.Parent = this.tbShortName;
			this.tbShortName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbShortName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(230)))), ((int)(((byte)(166)))));
			this.tbShortName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbShortName.FocusedState.Parent = this.tbShortName;
			this.tbShortName.ForeColor = System.Drawing.Color.Black;
			this.tbShortName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbShortName.HoverState.Parent = this.tbShortName;
			this.tbShortName.Location = new System.Drawing.Point(13, 188);
			this.tbShortName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tbShortName.MaxLength = 10;
			this.tbShortName.Name = "tbShortName";
			this.tbShortName.PasswordChar = '\0';
			this.tbShortName.PlaceholderText = "";
			this.tbShortName.SelectedText = "";
			this.tbShortName.ShadowDecoration.Parent = this.tbShortName;
			this.tbShortName.Size = new System.Drawing.Size(478, 44);
			this.tbShortName.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(12, 36);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(474, 43);
			this.label2.TabIndex = 4;
			this.label2.Text = "Полное наименование дисциплины";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tbFullName
			// 
			this.tbFullName.Animated = true;
			this.tbFullName.BorderRadius = 5;
			this.tbFullName.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbFullName.DefaultText = "";
			this.tbFullName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbFullName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.tbFullName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbFullName.DisabledState.Parent = this.tbFullName;
			this.tbFullName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbFullName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(230)))), ((int)(((byte)(166)))));
			this.tbFullName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbFullName.FocusedState.Parent = this.tbFullName;
			this.tbFullName.ForeColor = System.Drawing.Color.Black;
			this.tbFullName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbFullName.HoverState.Parent = this.tbFullName;
			this.tbFullName.Location = new System.Drawing.Point(13, 83);
			this.tbFullName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tbFullName.MaxLength = 50;
			this.tbFullName.Name = "tbFullName";
			this.tbFullName.PasswordChar = '\0';
			this.tbFullName.PlaceholderText = "";
			this.tbFullName.SelectedText = "";
			this.tbFullName.ShadowDecoration.Parent = this.tbFullName;
			this.tbFullName.Size = new System.Drawing.Size(478, 44);
			this.tbFullName.TabIndex = 0;
			// 
			// timeTableDataSet3
			// 
			this.timeTableDataSet3.DataSetName = "timeTableDataSet3";
			this.timeTableDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// timeTableDataSet3BindingSource
			// 
			this.timeTableDataSet3BindingSource.DataSource = this.timeTableDataSet3;
			this.timeTableDataSet3BindingSource.Position = 0;
			// 
			// cathedraBindingSource
			// 
			this.cathedraBindingSource.DataMember = "Cathedra";
			this.cathedraBindingSource.DataSource = this.timeTableDataSet3BindingSource;
			// 
			// cathedraTableAdapter
			// 
			this.cathedraTableAdapter.ClearBeforeFill = true;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(12, 462);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(237, 49);
			this.label1.TabIndex = 14;
			this.label1.Text = "Кол-во часов практик";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(254, 462);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(237, 49);
			this.label6.TabIndex = 16;
			this.label6.Text = "Кол-во часов лекций";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// numericUpDownLecsii
			// 
			this.numericUpDownLecsii.BackColor = System.Drawing.Color.Transparent;
			this.numericUpDownLecsii.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(230)))), ((int)(((byte)(166)))));
			this.numericUpDownLecsii.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.numericUpDownLecsii.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.numericUpDownLecsii.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.numericUpDownLecsii.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.numericUpDownLecsii.DisabledState.Parent = this.numericUpDownLecsii;
			this.numericUpDownLecsii.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
			this.numericUpDownLecsii.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
			this.numericUpDownLecsii.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(230)))), ((int)(((byte)(166)))));
			this.numericUpDownLecsii.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.numericUpDownLecsii.FocusedState.Parent = this.numericUpDownLecsii;
			this.numericUpDownLecsii.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numericUpDownLecsii.ForeColor = System.Drawing.Color.Black;
			this.numericUpDownLecsii.Location = new System.Drawing.Point(259, 515);
			this.numericUpDownLecsii.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.numericUpDownLecsii.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDownLecsii.Name = "numericUpDownLecsii";
			this.numericUpDownLecsii.ShadowDecoration.Parent = this.numericUpDownLecsii;
			this.numericUpDownLecsii.Size = new System.Drawing.Size(227, 44);
			this.numericUpDownLecsii.TabIndex = 17;
			this.numericUpDownLecsii.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(70)))), ((int)(((byte)(121)))));
			this.numericUpDownLecsii.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// numericUpDownPractic
			// 
			this.numericUpDownPractic.BackColor = System.Drawing.Color.Transparent;
			this.numericUpDownPractic.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(230)))), ((int)(((byte)(166)))));
			this.numericUpDownPractic.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.numericUpDownPractic.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.numericUpDownPractic.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.numericUpDownPractic.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.numericUpDownPractic.DisabledState.Parent = this.numericUpDownPractic;
			this.numericUpDownPractic.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
			this.numericUpDownPractic.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
			this.numericUpDownPractic.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(230)))), ((int)(((byte)(166)))));
			this.numericUpDownPractic.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.numericUpDownPractic.FocusedState.Parent = this.numericUpDownPractic;
			this.numericUpDownPractic.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numericUpDownPractic.ForeColor = System.Drawing.Color.Black;
			this.numericUpDownPractic.Location = new System.Drawing.Point(13, 515);
			this.numericUpDownPractic.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.numericUpDownPractic.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDownPractic.Name = "numericUpDownPractic";
			this.numericUpDownPractic.ShadowDecoration.Parent = this.numericUpDownPractic;
			this.numericUpDownPractic.Size = new System.Drawing.Size(221, 44);
			this.numericUpDownPractic.TabIndex = 18;
			this.numericUpDownPractic.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(70)))), ((int)(((byte)(121)))));
			this.numericUpDownPractic.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// notifyIcon1
			// 
			this.notifyIcon1.Text = "notifyIcon1";
			this.notifyIcon1.Visible = true;
			// 
			// AddLesson
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(38)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(504, 775);
			this.Controls.Add(this.gunaGradient2Panel5);
			this.Controls.Add(this.lbTitle);
			this.MinimumSize = new System.Drawing.Size(522, 750);
			this.Name = "AddLesson";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AddLesson";
			this.Load += new System.EventHandler(this.AddLesson_Load);
			this.gunaGradient2Panel5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.timeTableDataSet3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.timeTableDataSet3BindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cathedraBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownLecsii)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownPractic)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lbTitle;
		private Guna.UI.WinForms.GunaGradient2Panel gunaGradient2Panel5;
		private Guna.UI2.WinForms.Guna2Button save;
		private Guna.UI2.WinForms.Guna2Button exit;
		private Guna.UI2.WinForms.Guna2ComboBox cbCahedra;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private Guna.UI2.WinForms.Guna2TextBox tbLink;
		private System.Windows.Forms.Label label3;
		private Guna.UI2.WinForms.Guna2TextBox tbShortName;
		private System.Windows.Forms.Label label2;
		private Guna.UI2.WinForms.Guna2TextBox tbFullName;
		private System.Windows.Forms.BindingSource timeTableDataSet3BindingSource;
		private timeTableDataSet3 timeTableDataSet3;
		private System.Windows.Forms.BindingSource cathedraBindingSource;
		private timeTableDataSet3TableAdapters.CathedraTableAdapter cathedraTableAdapter;
		private Guna.UI2.WinForms.Guna2NumericUpDown numericUpDownPractic;
		private Guna.UI2.WinForms.Guna2NumericUpDown numericUpDownLecsii;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NotifyIcon notifyIcon1;
	}
}