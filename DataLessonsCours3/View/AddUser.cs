using DataLessonsCours3.Class;
using System;
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
	public partial class AddUser : Form
	{
		bool create = true;
		int id;
		public AddUser(int id, string tbName, string tbFirstName, string password, string login, int right)
		{
			InitializeComponent();
			this.id = id;
			this.tbLogin.Text = login;
			this.tbPassword.Text = password;
			this.tbFirstName.Text = tbFirstName;
			this.tbName.Text = tbName;
			numRight.Value = right;
			this.lbTitle.Text = "Изменение пользоваетеля";
			create = false;
		}

		public AddUser()
		{
			InitializeComponent();
		}

		private void save_Click(object sender, EventArgs e)
		{
			if (!(tbName.Text.Equals("") & tbFirstName.Text.Equals("") & tbPassword.Text.Equals("") & tbLogin.Text.Equals("")))
			{
				switch (create)
				{
					case true:
						DB db = new DB();
						string query = "IF NOT EXISTS (SELECT * FROM Auntefication WHERE password = @password AND login = @login)\r\n\t" +
							"BEGIN\r\n\t\t" +
							"	INSERT INTO Auntefication (name, firstName, password, login, accessRight) VALUES (@name, @firstName, @password, @login, @accessRight)\r\n\t" +
							"	SELECT 'Пользователь успешно добавлен в систему'" +
							"END\r\n\t" +
							"ELSE\r\n\tBEGIN\r\n\t\t" +
							"SELECT 'Такой пароль уже существует'\r\n\tEND";
						using (SqlCommand command = new SqlCommand(query, db.getConnection()))
						{
							command.Parameters.AddWithValue("@name", tbName.Text);
							command.Parameters.AddWithValue("@firstName", tbFirstName.Text);
							command.Parameters.AddWithValue("@password", tbPassword.Text);
							command.Parameters.AddWithValue("@login", tbLogin.Text);
							command.Parameters.AddWithValue("@accessRight", numRight.Value);


							db.getConnection().Open();
							int result = command.ExecuteNonQuery();
							SqlDataReader reader = command.ExecuteReader();
							while (reader.Read())
							{
								notifyIcon1.Icon = SystemIcons.Exclamation;
								notifyIcon1.BalloonTipTitle = "Добавление пользователя";
								notifyIcon1.BalloonTipText = reader.GetString(0);
								notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
								notifyIcon1.Visible = true;
								notifyIcon1.ShowBalloonTip(80000);

							}


							db.getConnection().Close();
							this.Close();
						}
						break;
					case false:
						DB db2 = new DB();
						string query2 = "UPDATE Auntefication SET name = @name, firstName = @firstName, password = @password, login = @login, accessRight = @accessRight WHERE id_user = @id";
						using (SqlCommand command = new SqlCommand(query2, db2.getConnection()))
						{
							command.Parameters.AddWithValue("@id", id);
							command.Parameters.AddWithValue("@name", tbName.Text);
							command.Parameters.AddWithValue("@firstName", tbFirstName.Text);
							command.Parameters.AddWithValue("@password", tbPassword.Text);
							command.Parameters.AddWithValue("@login", tbLogin.Text);
							command.Parameters.AddWithValue("@accessRight", numRight.Value);

							db2.getConnection().Open();
							int result = command.ExecuteNonQuery();

							if (result == 1)
							{
								notifyIcon1.Icon = SystemIcons.Hand;
								notifyIcon1.BalloonTipTitle = "Изменение пользователя";
								notifyIcon1.BalloonTipText = "Данные пользователя успешно изменены";
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
			}
			else
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
