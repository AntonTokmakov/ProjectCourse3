using DataLessonsCours3.Class;
using Microsoft.VisualBasic.ApplicationServices;
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
	public partial class Auntification : Form
	{
		bool check = true;
		int idUser, accessRigth;
		string name, firstName;

		public Auntification()
		{
			InitializeComponent();
		}

		private void lbRegistration_Click(object sender, EventArgs e)
		{
			if (check)
			{
				panel3.Location = new Point(12, 470);
				panel2.Location = new Point(12, 300);
				panel2.Visible = true;
				btnSave.Text = "Регистрация";
				lbRegistration.Text = "Вход";
				check = false;
			} else
			{
				panel3.Location = new Point(12, 300);
				panel2.Location = new Point(12, 490);
				panel2.Visible = false;
				btnSave.Text = "Вход";
				lbRegistration.Text = "Регистрация";
				check = true;
			}
		}

		private void btnShowLogin_Click(object sender, EventArgs e)
		{
			if (tbLogin.PasswordChar == '*')
			{
				tbLogin.PasswordChar = '\0';
				btnShowLogin.Text = "***";
			}
			else
			{
				tbLogin.PasswordChar = '*';
				btnShowLogin.Text = "123";
			}
		}

		private void btnShowPassword_Click(object sender, EventArgs e)
		{
			if (tbPassword.PasswordChar == '*')
			{
				tbPassword.PasswordChar = '\0';
				btnShowLogin.Text = "***";
			}
			else
			{
				tbPassword.PasswordChar = '*';
				btnShowLogin.Text = "123";
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (!(tbPassword.Text.Equals("") && tbLogin.Text.Equals("") && tbFirstName.Text.Equals("") && tbName.Text.Equals("")))
			{
				if (check)
				{
					DB db = new DB();
					db.openConnection();
					string quest = $"SELECT id_user, name, firstName, accessRight FROM Auntefication WHERE login = @login AND password = @password";
					SqlCommand command = new SqlCommand(quest, db.getConnection());
					command.Parameters.AddWithValue("@password", tbPassword.Text);
					command.Parameters.AddWithValue("@login", tbLogin.Text);
					SqlDataReader reader = command.ExecuteReader();
					while (reader.Read())
					{
						idUser = reader.GetInt32(0);
						name = reader.GetValue(1).ToString();
						firstName = reader.GetValue(2).ToString();
						accessRigth = reader.GetInt32(3);
					}
					reader.Close();
					db.closeConnection();
					notifyIcon1.Icon = SystemIcons.Hand;
					notifyIcon1.BalloonTipTitle = "Вход в систему";
					notifyIcon1.BalloonTipText = name + " " + firstName + " успешно вошел(а) в систему.";
					notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
					notifyIcon1.Visible = true;
					notifyIcon1.ShowBalloonTip(80000);
				}
				else
				{
					DB db = new DB();
					db.openConnection();
					string quest = $"INSERT INTO Auntefication (name, firstName, password, login, accessRight)\r\nVALUES (@name, @firstName, @password, @login, @accessRight)";
					SqlCommand command = new SqlCommand(quest, db.getConnection());
					command.Parameters.AddWithValue("@password", tbPassword.Text);
					command.Parameters.AddWithValue("@login", tbLogin.Text);
					command.Parameters.AddWithValue("@name", tbName.Text);
					command.Parameters.AddWithValue("@firstName", tbFirstName.Text);
					command.Parameters.AddWithValue("@accessRight", 1);
					SqlDataReader reader = command.ExecuteReader();
					db.closeConnection();
				}
			}
			this.Close();
		}
		public (int, string, string, int) GetIdUser
		{
			get { return (idUser, name, firstName, accessRigth); }
		}
	}
}
