using DataLessonsCours3.Class;
using DataLessonsCours3.timeTableDataSet3TableAdapters;
using Guna.UI.WinForms;
using Guna.UI2.WinForms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataLessonsCours3.View
{
	public partial class AddTeacher : Form
	{
		public AddTeacher()
		{
			InitializeComponent();
			this.cathedraTableAdapter.Fill(this.timeTableDataSet3.Cathedra);
		}

		bool create = true;
		int id;
		public AddTeacher(int id, int cbCahedra, string tbName, string tbFirstName, string tbOtchestvo)
		{
			InitializeComponent();
			this.cathedraTableAdapter.Fill(this.timeTableDataSet3.Cathedra);
			this.id = id;
			this.cbCahedra.SelectedIndex = cbCahedra - 1;
			this.tbOtchestvo.Text = tbOtchestvo;
			this.tbFirstName.Text = tbFirstName;
			this.tbName.Text = tbName;
			this.lbTitle.Text = "Изменение пользоваетеля";
			create = false;
		}

		private void AddTeacher_Load(object sender, EventArgs e)
		{
            // TODO: данная строка кода позволяет загрузить данные в таблицу "timeTableDataSet3.Cathedra". При необходимости она может быть перемещена или удалена.
           

        }

		private void save_Click(object sender, EventArgs e)
		{
			if (!(tbName.Text.Equals("") & tbFirstName.Text.Equals("") & tbOtchestvo.Text.Equals("")))
			{
				switch (create)
				{
					case true:
						DB db = new DB();
						string query = "INSERT INTO Teacher (cathedra, name, firstName, otchestvo) VALUES (@cachedra, @name, @firstName, @Otchestvo)";
						using (SqlCommand command = new SqlCommand(query, db.getConnection()))
						{
							command.Parameters.AddWithValue("@name", tbName.Text);
							command.Parameters.AddWithValue("@firstName", tbFirstName.Text);
							command.Parameters.AddWithValue("@Otchestvo", tbOtchestvo.Text);
							command.Parameters.AddWithValue("@cachedra", cbCahedra.SelectedValue);

							db.getConnection().Open();
							int result = command.ExecuteNonQuery();

							if (result == 1)
							{
								notifyIcon1.Icon = SystemIcons.Hand;
								notifyIcon1.BalloonTipTitle = "Добавление пользователя";
								notifyIcon1.BalloonTipText = "Пользователь успешно добавлен в систему";
								notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
								notifyIcon1.Visible = true;
								notifyIcon1.ShowBalloonTip(80000);
							}
							else
							{
								notifyIcon1.Icon = SystemIcons.Hand;
								notifyIcon1.BalloonTipTitle = "Ошибка";
								notifyIcon1.BalloonTipText = "Пользователь не добавлен в систему";
								notifyIcon1.BalloonTipIcon = ToolTipIcon.Error;
								notifyIcon1.Visible = true;
								notifyIcon1.ShowBalloonTip(80000);
							}
							db.getConnection().Close();
							this.Close();
						}
						break;
					case false:
						DB db2 = new DB();
						string query2 = "UPDATE Teacher SET cathedra = @cachedra, name = @name, firstName = @firstName, otchestvo = @Otchestvo WHERE id_teacher = @id";
						using (SqlCommand command = new SqlCommand(query2, db2.getConnection()))
						{
							command.Parameters.AddWithValue("@id", id);
							command.Parameters.AddWithValue("@name", tbName.Text);
							command.Parameters.AddWithValue("@firstName", tbFirstName.Text);
							command.Parameters.AddWithValue("@Otchestvo", tbOtchestvo.Text);
							command.Parameters.AddWithValue("@cachedra", cbCahedra.SelectedValue);

							db2.getConnection().Open();
							int result = command.ExecuteNonQuery();

							if (result == 1)
							{
								notifyIcon1.Icon = SystemIcons.Hand;
								notifyIcon1.BalloonTipTitle = "Изменение пользователя";
								notifyIcon1.BalloonTipText = "Данные пользователь успешно изменены";
								notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
								notifyIcon1.Visible = true;
								notifyIcon1.ShowBalloonTip(80000);
							}
							else
							{
								notifyIcon1.Icon = SystemIcons.Hand;
								notifyIcon1.BalloonTipTitle = "Ошибка";
								notifyIcon1.BalloonTipText = "Пользователь не изменён";
								notifyIcon1.BalloonTipIcon = ToolTipIcon.Error;
								notifyIcon1.Visible = true;
								notifyIcon1.ShowBalloonTip(80000);
							}
							db2.getConnection().Close();
							this.Close();
						}
						break;
					default:
						break;
				}
			} else
			{
				notifyIcon1.Icon = SystemIcons.Exclamation;
				notifyIcon1.BalloonTipTitle = "Ошибка";
				notifyIcon1.BalloonTipText = "Поля не заполнены";
				notifyIcon1.BalloonTipIcon = ToolTipIcon.Error;
				notifyIcon1.Visible = true;
				notifyIcon1.ShowBalloonTip(80000);
			}

		}

		private void exit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
