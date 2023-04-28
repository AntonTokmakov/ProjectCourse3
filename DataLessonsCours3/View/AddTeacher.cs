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
		}
		string name, firstName, otchestvo, cachedra; 
		bool create = true;
		public AddTeacher(string cbCahedra, string tbOtchestvo, string tbFirstName, string tbName, string lbTitle)
		{
			InitializeComponent();
			this.cbCahedra.Text = cbCahedra;
			this.tbOtchestvo.Text = tbOtchestvo;
			this.tbFirstName.Text = tbFirstName;
			this.tbName.Text = tbName;
			this.lbTitle.Text = lbTitle;

			cachedra = cbCahedra;
			otchestvo = tbOtchestvo;
			firstName = tbFirstName;
			name = tbName;
			create = false;
		}

		private void AddTeacher_Load(object sender, EventArgs e)
		{
            // TODO: данная строка кода позволяет загрузить данные в таблицу "timeTableDataSet3.Cathedra". При необходимости она может быть перемещена или удалена.
            this.cathedraTableAdapter.Fill(this.timeTableDataSet3.Cathedra);

        }

		private void save_Click(object sender, EventArgs e)
		{

			//lbTitle.Text = cbCahedra.SelectedValue.ToString();

			/*switch (create)
			{
				case false:
					DB db = new DB();
					string query = "INSERT INTO Teacher (cathedra, name, firstName, otchestvo) VALUES (@cachedra,'@name', '@firstName', '@Otchestvo')";
					using (SqlCommand command = new SqlCommand(query, db.getConnection()))
					{
						// добавление параметров к команде SQL
						command.Parameters.AddWithValue("@name", name);
						command.Parameters.AddWithValue("@firstName", firstName);
						command.Parameters.AddWithValue("@Otchestvo", otchestvo);
						command.Parameters.AddWithValue("@cachedra", cachedra);

						// открытие подключения к базе данных
						db.getConnection().Open();

						// выполнение команды SQL
						int result = command.ExecuteNonQuery();

						// закрытие подключения к базе данных
						db.getConnection().Close();
					}
					break;
				case true:
					//создание
					break;
				default:
					break;
			}*/

		}

		private void exit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
