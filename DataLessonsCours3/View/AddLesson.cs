using DataLessonsCours3.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DataLessonsCours3.View
{
	public partial class AddLesson : Form
	{
		bool check = true;
		int id;

		public AddLesson()
		{
			InitializeComponent();
			this.cathedraTableAdapter.Fill(this.timeTableDataSet3.Cathedra);
		}

		public AddLesson(int id, int cathedra, string fullName,string shortName, int practic, int lectur, string link)
		{
			InitializeComponent();
			this.cathedraTableAdapter.Fill(this.timeTableDataSet3.Cathedra);
			this.id = id;
			tbFullName.Text = fullName;
			tbShortName.Text = shortName;
			tbLink.Text = link;
			cbCahedra.SelectedIndex = cathedra;
			numericUpDownPractic.Value = practic;
			numericUpDownLecsii.Value = lectur;
			lbTitle.Text = "Изменение дисциплины";
			check = false;
		}

		private void AddLesson_Load(object sender, EventArgs e)
		{
            // TODO: данная строка кода позволяет загрузить данные в таблицу "timeTableDataSet3.Cathedra". При необходимости она может быть перемещена или удалена.
            this.cathedraTableAdapter.Fill(this.timeTableDataSet3.Cathedra);

        }

		private void exit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void save_Click(object sender, EventArgs e)
		{
			if (!(tbFullName.Text.Equals("") & tbShortName.Text.Equals("") & numericUpDownPractic.Value > 1 & numericUpDownLecsii.Value < 1000 ))
			{
				switch (check)
				{
					case true:
						DB db = new DB();
						string query = "INSERT INTO Lesson (cathedra, fullNameLesson, shortNameLesson, numberPracticeHoursSemester, numberLectureHoursSemester, linkMudl)" +
							"VALUES (@cachedra, @fullName, @shortName, @practic, @lecture, @link)";
						using (SqlCommand command = new SqlCommand(query, db.getConnection()))
						{
							command.Parameters.AddWithValue("@fullName", tbFullName.Text);
							command.Parameters.AddWithValue("@shortName", tbShortName.Text);
							command.Parameters.AddWithValue("@link", tbLink.Text);
							command.Parameters.AddWithValue("@practic", numericUpDownPractic.Value);
							command.Parameters.AddWithValue("@lecture", numericUpDownLecsii.Value);
							command.Parameters.AddWithValue("@cachedra", cbCahedra.SelectedValue);

							db.getConnection().Open();
							int result = command.ExecuteNonQuery();

							if (result == 1)
							{
								notifyIcon1.Icon = SystemIcons.Hand;
								notifyIcon1.BalloonTipTitle = "Добавление дисциплины";
								notifyIcon1.BalloonTipText = "Дисциплина успешно добавлена";
								notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
								notifyIcon1.Visible = true;
								notifyIcon1.ShowBalloonTip(80000);
							}
							else
							{
								notifyIcon1.Icon = SystemIcons.Hand;
								notifyIcon1.BalloonTipTitle = "Ошибка";
								notifyIcon1.BalloonTipText = "Дисциплина не добавлена";
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
						string query2 = "UPDATE Lesson SET cathedra = @cachedra, fullNameLesson = @fullName, shortNameLesson = @shortName, numberPracticeHoursSemester = @practic, numberLectureHoursSemester = @lecture, linkMudl = @link WHERE   id_lesson = @id";
						using (SqlCommand command2 = new SqlCommand(query2, db2.getConnection()))
						{
							command2.Parameters.AddWithValue("@id", id);
							command2.Parameters.AddWithValue("@fullName", tbFullName.Text);
							command2.Parameters.AddWithValue("@shortName", tbShortName.Text);
							command2.Parameters.AddWithValue("@link", tbLink.Text);
							command2.Parameters.AddWithValue("@practic", numericUpDownPractic.Value);
							command2.Parameters.AddWithValue("@lecture", numericUpDownLecsii.Value);
							command2.Parameters.AddWithValue("@cachedra", cbCahedra.SelectedValue);

							db2.getConnection().Open();
							int result = command2.ExecuteNonQuery();

							if (result > 0)
							{
								notifyIcon1.Icon = SystemIcons.Hand;
								notifyIcon1.BalloonTipTitle = "Добавление дисциплины";
								notifyIcon1.BalloonTipText = "Дисуиплина успешно добавлена";
								notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
								notifyIcon1.Visible = true;
								notifyIcon1.ShowBalloonTip(80000);
							}
							else
							{
								notifyIcon1.Icon = SystemIcons.Hand;
								notifyIcon1.BalloonTipTitle = "Ошибка";
								notifyIcon1.BalloonTipText = "Дисциплина не добавлена";
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
	}
}
