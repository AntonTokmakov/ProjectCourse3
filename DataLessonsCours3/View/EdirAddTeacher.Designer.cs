namespace DataLessonsCours3.View
{
	partial class EdirAddTeacher
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dataGridViewTeacher = new Guna.UI2.WinForms.Guna2DataGridView();
			this.idteacherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cathedraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.otchestvoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.teacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.timeTableDataSet = new DataLessonsCours3.timeTableDataSet();
			this.timeTableDataSet3 = new DataLessonsCours3.timeTableDataSet3();
			this.timeTableDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.teacherTableAdapter = new DataLessonsCours3.timeTableDataSetTableAdapters.TeacherTableAdapter();
			this.label1 = new System.Windows.Forms.Label();
			this.save = new Guna.UI2.WinForms.Guna2Button();
			this.exit = new Guna.UI2.WinForms.Guna2Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeacher)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.timeTableDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.timeTableDataSet3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.timeTableDataSet3BindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridViewTeacher
			// 
			this.dataGridViewTeacher.AllowUserToAddRows = false;
			this.dataGridViewTeacher.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			this.dataGridViewTeacher.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridViewTeacher.AutoGenerateColumns = false;
			this.dataGridViewTeacher.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridViewTeacher.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(88)))), ((int)(((byte)(122)))));
			this.dataGridViewTeacher.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridViewTeacher.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dataGridViewTeacher.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewTeacher.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridViewTeacher.ColumnHeadersHeight = 27;
			this.dataGridViewTeacher.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idteacherDataGridViewTextBoxColumn,
            this.cathedraDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.otchestvoDataGridViewTextBoxColumn,
            this.Check});
			this.dataGridViewTeacher.DataSource = this.teacherBindingSource;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewTeacher.DefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridViewTeacher.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.dataGridViewTeacher.EnableHeadersVisualStyles = false;
			this.dataGridViewTeacher.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dataGridViewTeacher.Location = new System.Drawing.Point(0, 137);
			this.dataGridViewTeacher.Name = "dataGridViewTeacher";
			this.dataGridViewTeacher.RowHeadersVisible = false;
			this.dataGridViewTeacher.RowHeadersWidth = 51;
			this.dataGridViewTeacher.RowTemplate.Height = 24;
			this.dataGridViewTeacher.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewTeacher.Size = new System.Drawing.Size(522, 356);
			this.dataGridViewTeacher.TabIndex = 0;
			this.dataGridViewTeacher.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
			this.dataGridViewTeacher.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.dataGridViewTeacher.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.dataGridViewTeacher.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.dataGridViewTeacher.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.dataGridViewTeacher.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.dataGridViewTeacher.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(88)))), ((int)(((byte)(122)))));
			this.dataGridViewTeacher.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dataGridViewTeacher.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.dataGridViewTeacher.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dataGridViewTeacher.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			this.dataGridViewTeacher.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.dataGridViewTeacher.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.dataGridViewTeacher.ThemeStyle.HeaderStyle.Height = 27;
			this.dataGridViewTeacher.ThemeStyle.ReadOnly = false;
			this.dataGridViewTeacher.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.dataGridViewTeacher.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dataGridViewTeacher.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			this.dataGridViewTeacher.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.dataGridViewTeacher.ThemeStyle.RowsStyle.Height = 24;
			this.dataGridViewTeacher.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dataGridViewTeacher.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			// 
			// idteacherDataGridViewTextBoxColumn
			// 
			this.idteacherDataGridViewTextBoxColumn.DataPropertyName = "id_teacher";
			this.idteacherDataGridViewTextBoxColumn.HeaderText = "id_teacher";
			this.idteacherDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.idteacherDataGridViewTextBoxColumn.Name = "idteacherDataGridViewTextBoxColumn";
			this.idteacherDataGridViewTextBoxColumn.Visible = false;
			// 
			// cathedraDataGridViewTextBoxColumn
			// 
			this.cathedraDataGridViewTextBoxColumn.DataPropertyName = "cathedra";
			this.cathedraDataGridViewTextBoxColumn.HeaderText = "cathedra";
			this.cathedraDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.cathedraDataGridViewTextBoxColumn.Name = "cathedraDataGridViewTextBoxColumn";
			this.cathedraDataGridViewTextBoxColumn.Visible = false;
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "name";
			this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			// 
			// firstNameDataGridViewTextBoxColumn
			// 
			this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "firstName";
			this.firstNameDataGridViewTextBoxColumn.HeaderText = "firstName";
			this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
			// 
			// otchestvoDataGridViewTextBoxColumn
			// 
			this.otchestvoDataGridViewTextBoxColumn.DataPropertyName = "otchestvo";
			this.otchestvoDataGridViewTextBoxColumn.HeaderText = "otchestvo";
			this.otchestvoDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.otchestvoDataGridViewTextBoxColumn.Name = "otchestvoDataGridViewTextBoxColumn";
			// 
			// Check
			// 
			this.Check.HeaderText = "Выбор";
			this.Check.MinimumWidth = 6;
			this.Check.Name = "Check";
			// 
			// teacherBindingSource
			// 
			this.teacherBindingSource.DataMember = "Teacher";
			this.teacherBindingSource.DataSource = this.timeTableDataSet;
			// 
			// timeTableDataSet
			// 
			this.timeTableDataSet.DataSetName = "timeTableDataSet";
			this.timeTableDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
			// teacherTableAdapter
			// 
			this.teacherTableAdapter.ClearBeforeFill = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(107, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(290, 29);
			this.label1.TabIndex = 1;
			this.label1.Text = "Выбор преподавателей";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
			this.save.Location = new System.Drawing.Point(329, 72);
			this.save.Name = "save";
			this.save.ShadowDecoration.Parent = this.save;
			this.save.Size = new System.Drawing.Size(180, 45);
			this.save.TabIndex = 13;
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
			this.exit.Location = new System.Drawing.Point(12, 72);
			this.exit.Name = "exit";
			this.exit.ShadowDecoration.Parent = this.exit;
			this.exit.Size = new System.Drawing.Size(180, 45);
			this.exit.TabIndex = 14;
			this.exit.Text = "Отмена";
			this.exit.Click += new System.EventHandler(this.exit_Click);
			// 
			// EdirAddTeacher
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(88)))), ((int)(((byte)(122)))));
			this.ClientSize = new System.Drawing.Size(522, 493);
			this.Controls.Add(this.exit);
			this.Controls.Add(this.save);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridViewTeacher);
			this.MaximumSize = new System.Drawing.Size(540, 540);
			this.MinimumSize = new System.Drawing.Size(540, 540);
			this.Name = "EdirAddTeacher";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "EdirAddTeacher";
			this.Load += new System.EventHandler(this.EdirAddTeacher_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeacher)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.timeTableDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.timeTableDataSet3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.timeTableDataSet3BindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Guna.UI2.WinForms.Guna2DataGridView dataGridViewTeacher;
		private System.Windows.Forms.BindingSource timeTableDataSet3BindingSource;
		private timeTableDataSet3 timeTableDataSet3;
		private timeTableDataSet timeTableDataSet;
		private System.Windows.Forms.BindingSource teacherBindingSource;
		private timeTableDataSetTableAdapters.TeacherTableAdapter teacherTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn idteacherDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn cathedraDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn otchestvoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Check;
		private System.Windows.Forms.Label label1;
		private Guna.UI2.WinForms.Guna2Button save;
		private Guna.UI2.WinForms.Guna2Button exit;
	}
}