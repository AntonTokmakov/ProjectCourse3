using DataLessonsCours3.Properties;
using DataLessonsCours3.View;
using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLessonsCours3.Class;
using Guna.UI2.WinForms;
using System.Data.SqlClient;
using System.Xml.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Drawing.Printing;
using static System.Net.Mime.MediaTypeNames;
using Microsoft.SqlServer.Server;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace DataLessonsCours3
{
	public partial class Form1 : Form
	{

		DayLesson monday;
		DayLesson tuesday;
		DayLesson wednesday;
		DayLesson thursday;
		DayLesson friday;
		DayLesson saturday;
		DayLesson[] daysLesson;

		Guna2ComboBox[] cbLesson;
		Guna2ComboBox[] cbOffice;
		Guna2TextBox[] tbTeacher;
		Guna2CustomCheckBox[] cbLecture;

		(int, string, string, int) user;
		string[][][] day;
		string[][][] nowDayTeacher = new string[6][][];
		string[] weekDayName;
		
		int nowWeekDay;

		private void Form1_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "timeTableDataSet14.Office". При необходимости она может быть перемещена или удалена.
			this.officeTableAdapter5.Fill(this.timeTableDataSet14.Office);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "timeTableDataSet13.Office". При необходимости она может быть перемещена или удалена.
			this.officeTableAdapter4.Fill(this.timeTableDataSet13.Office);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "timeTableDataSet12.Office". При необходимости она может быть перемещена или удалена.
			this.officeTableAdapter3.Fill(this.timeTableDataSet12.Office);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "timeTableDataSet11.Office". При необходимости она может быть перемещена или удалена.
			this.officeTableAdapter2.Fill(this.timeTableDataSet11.Office);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "timeTableDataSet10.Lesson". При необходимости она может быть перемещена или удалена.
			this.lessonTableAdapter6.Fill(this.timeTableDataSet10.Lesson);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "timeTableDataSet9.Lesson". При необходимости она может быть перемещена или удалена.
			this.lessonTableAdapter5.Fill(this.timeTableDataSet9.Lesson);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "timeTableDataSet8.Lesson". При необходимости она может быть перемещена или удалена.
			this.lessonTableAdapter4.Fill(this.timeTableDataSet8.Lesson);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "dataSetLessonEdit2.Lesson". При необходимости она может быть перемещена или удалена.
			this.lessonTableAdapter3.Fill(this.dataSetLessonEdit2.Lesson);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "timeTableDataSet7.Office". При необходимости она может быть перемещена или удалена.
			this.officeTableAdapter1.Fill(this.timeTableDataSet7.Office);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "timeTableDataSet6.Lesson". При необходимости она может быть перемещена или удалена.
			this.lessonTableAdapter2.Fill(this.timeTableDataSet6.Lesson);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "timeTableDataSet5.Lesson". При необходимости она может быть перемещена или удалена.
			this.lessonTableAdapter1.Fill(this.timeTableDataSet5.Lesson);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "timeTableDataSet4.Week". При необходимости она может быть перемещена или удалена.
			this.weekTableAdapter.Fill(this.timeTableDataSet4.Week);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "groupStudIdShortName.GroupStudent". При необходимости она может быть перемещена или удалена.
			this.groupStudentTableAdapter.Fill(this.groupStudIdShortName.GroupStudent);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "timeTableDataSet2.Office".
			this.officeTableAdapter.Fill(this.timeTableDataSet2.Office);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "timeTableDataSet1.Lesson".
			this.lessonTableAdapter.Fill(this.timeTableDataSet1.Lesson);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "timeTableTeacher.Teacher".
			this.teacherTableAdapter1.Fill(this.timeTableTeacher.Teacher);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "timeTableDataSet.Teacher".
			this.teacherTableAdapter.Fill(this.timeTableDataSet.Teacher);

			cbGroupEdit_SelectedIndexChanged(sender, e);
			viewDaysTabPanel_SelectedIndexChanged(sender, e);

		}

		public Form1()
		{
			InitializeComponent();
			/////////////////////////////////////////////////////////////////////////////////										при записи он говорит, что кабинет занят про другие пары
			user.Item4 = 2;                                                                             ////////////// УДАЛИТЬ
			////////////////////////////////////////////////////////////////////////////////

			cbLesson = new Guna2ComboBox[] { cbEditLesson1, cbEditLesson2, cbEditLesson3, cbEditLesson4, cbEditLesson5 };
			cbOffice = new Guna2ComboBox[] { cbEditOffice1, cbEditOffice2, cbEditOffice3, cbEditOffice4, cbEditOffice5 };
			tbTeacher = new Guna2TextBox[] { tbListTeacher1, tbListTeacher2, tbListTeacher3, tbListTeacher4, tbListTeacher5 };
			cbLecture = new Guna2CustomCheckBox[] { lecture1, lecture2, lecture3, lecture4, lecture5 };
			daysLesson = new DayLesson[] { monday, tuesday, wednesday, thursday , friday , saturday };
			weekDayName = new string[] { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота" };

		}

		private void mainPage_Click(object sender, EventArgs e)
		{

		}

		private void addExam_Click(object sender, EventArgs e)
		{

		}

		private void viewDaysTabPanel_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch (viewDaysTabPanel.SelectedIndex)
			{
				case 0: // appointment panel
					mainLayout.Controls.Clear();
					try
					{
						for (int i = 0; i < daysLesson.Length; i++)
						{
							string[][][] dayL = daysLesson[i].selectDB();
							CardDayLessons DayCard = new CardDayLessons(dayL, i);
							mainLayout.Controls.Add(DayCard);
						}
					}
					catch (Exception) { }
					break;

				case 1:	// edit panel
					if (user.Item4 == 2)
					{
						flEditDay.Controls.Clear();
						try
						{
							for (int i = 0; i < daysLesson.Length; i++)
							{
								string[][][] dayL = daysLesson[i].selectDB();
								EditDayCard editDayCard = new EditDayCard(dayL, i);
								flEditDay.Controls.Add(editDayCard);
							}
						}
						catch (Exception) {	}
					}
					else
						new MessageForm("У вас не достаточно прав", "Система").ShowDialog();
					/*foreach (var day in daysLesson)
					{
					}*/
					break;
					
				case 2:  // exam panel
					if (user.Item4 == 2)
					{
						examLayoutPanel.Controls.Clear();
						for (int i = 0; i < 5; i++)
						{
							CardExam cardExam = new CardExam();

							examLayoutPanel.Controls.Add(cardExam);
						}
					}
					else
						new MessageForm("У вас не достаточно прав", "Система").ShowDialog();
					break;

				case 3:	// teacher panel
					break;

				default:
					viewDaysTabPanel.SelectedIndex = 0;
					break;
			}
		}

		private void schedulePage_Click(object sender, EventArgs e)
		{
			viewDaysTabPanel.SelectTab(0);
		}

		private void examPage_Click(object sender, EventArgs e)
		{
			viewDaysTabPanel.SelectTab(2);
		}

		private void editShedulePage_Click(object sender, EventArgs e)
		{
			if (user.Item4 == 2)
				viewDaysTabPanel.SelectTab(1);
			else
				new MessageForm("У вас не достаточно прав", "Система").ShowDialog();
		}

		private void fillByToolStripButton_Click(object sender, EventArgs e)
		{
			try
			{
				this.teacherTableAdapter.FillBy(this.timeTableDataSet.Teacher);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

		}

		private void selectSpr_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch (selectSpr.SelectedIndex)
			{
				case 1:
					if (user.Item4 >= 2)
					{
						viewDaysTabPanel.SelectTab(3);
					}
					else
					{
						new MessageForm("У вас не достаточно прав","Система").ShowDialog();
					}
					break;
				case 2:
					if (user.Item4 >= 2)
					{
						viewDaysTabPanel.SelectTab(4);
					}
					else
					{
						new MessageForm("У вас не достаточно прав", "Система").ShowDialog();
					}
					break;
				case 3:
					if (user.Item4 >= 2)
					{
						viewDaysTabPanel.SelectTab(5);
					}
					else
					{
						new MessageForm("У вас не достаточно прав", "Система").ShowDialog();
					}
					break;
				case 4:
					if (user.Item4 >= 3)
					{
						viewDaysTabPanel.SelectTab(6);
					}
					else
					{
						new MessageForm("У вас не достаточно прав", "Система").ShowDialog();
					}
					break;
				default:
					viewDaysTabPanel.SelectedIndex = 0;
					break;
			}
		}

		#region Panel Teacher

		private void btnAddTicher_Click(object sender, EventArgs e)
		{
			new AddTeacher().ShowDialog();
			this.teacherTableAdapter.Fill(this.timeTableDataSet.Teacher);
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			try
			{
				int eventRow = dataGridTeacher.SelectedCells[0].RowIndex;
				int idTeacher = Convert.ToInt32(dataGridTeacher.Rows[eventRow].Cells[0].Value.ToString().Trim());
				int idCathedra = Convert.ToInt32(dataGridTeacher.Rows[eventRow].Cells[1].Value.ToString().Trim());
				string name = dataGridTeacher.Rows[eventRow].Cells[2].Value.ToString().Trim();
				string firstName = dataGridTeacher.Rows[eventRow].Cells[3].Value.ToString().Trim();
				string otchestvo = dataGridTeacher.Rows[eventRow].Cells[4].Value.ToString().Trim();
				new AddTeacher(idTeacher, idCathedra, name, firstName, otchestvo).ShowDialog();
			}
			catch (Exception)
			{
				MessageBox.Show("Выбирите ячейку для просмотра информации", "Система");
			}

			this.teacherTableAdapter.Fill(this.timeTableDataSet.Teacher);
		}

		private void DeleteTeacher_Click(object sender, EventArgs e)
		{
			try
			{
				int eventRow = dataGridTeacher.SelectedCells[0].RowIndex;
				int idTeacher = Convert.ToInt32(dataGridTeacher.Rows[eventRow].Cells[0].Value.ToString().Trim());
				DialogResult result1 = MessageBox.Show("Удалить пользователя из информационной системы?", "Удаление пользователя", MessageBoxButtons.YesNoCancel);
				if (result1 == DialogResult.Yes)
				{
					DB db = new DB();
					string query = "DELETE FROM Teacher WHERE id_teacher = @id";
					using (SqlCommand command = new SqlCommand(query, db.getConnection()))
					{
						command.Parameters.AddWithValue("@id", idTeacher);
						db.getConnection().Open();
						int result = command.ExecuteNonQuery();

						if (result == 1)
						{
							notifyIcon1.Icon = SystemIcons.Hand;
							notifyIcon1.BalloonTipTitle = "Удаление пользователя";
							notifyIcon1.BalloonTipText = "Пользователь удален из системы";
							notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
							notifyIcon1.Visible = true;
							notifyIcon1.ShowBalloonTip(80000);
						}
						db.getConnection().Close();
					}
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Выбирите ячейку для просмотра информации", "Система");
			}			

			this.teacherTableAdapter.Fill(this.timeTableDataSet.Teacher);
		}

		#endregion

		#region Panel Lesson

		private void addLesson_Click(object sender, EventArgs e)
		{
			new AddLesson().ShowDialog();
			this.lessonTableAdapter1.Fill(this.timeTableDataSet5.Lesson);
		}

		private void updateLesson_Click(object sender, EventArgs e)
		{
			try
			{
				int eventRow = dataGridViewLesson.SelectedCells[0].RowIndex;
				int idLesson = Convert.ToInt32(dataGridViewLesson.Rows[eventRow].Cells[5].Value.ToString().Trim());
				int idCathedra = Convert.ToInt32(dataGridViewLesson.Rows[eventRow].Cells[0].Value.ToString().Trim());
				string fullName = dataGridViewLesson.Rows[eventRow].Cells[1].Value.ToString().Trim();
				string shortName = dataGridViewLesson.Rows[eventRow].Cells[2].Value.ToString().Trim();
				string link = dataGridViewLesson.Rows[eventRow].Cells[6].Value.ToString().Trim();
				int practic = Convert.ToInt32(dataGridViewLesson.Rows[eventRow].Cells[3].Value);
				int lecture = Convert.ToInt32(dataGridViewLesson.Rows[eventRow].Cells[4].Value);
				new AddLesson(idLesson, idCathedra, fullName, shortName, practic, lecture, link).ShowDialog();
			}
			catch (Exception)
			{
				MessageBox.Show("Выбирите ячейку для просмотра информации", "Система");
			}
			this.lessonTableAdapter1.Fill(this.timeTableDataSet5.Lesson);
		}

		private void deleteLesson_Click(object sender, EventArgs e)
		{
			try
			{
				int eventRow = dataGridViewLesson.SelectedCells[0].RowIndex;
				int idLesson = Convert.ToInt32(dataGridViewLesson.Rows[eventRow].Cells[5].Value.ToString().Trim());
				DialogResult result1 = MessageBox.Show("Удалить дисциплину из информационной системы?", "Удаление дисциплины", MessageBoxButtons.YesNoCancel);
				if (result1 == DialogResult.Yes)
				{
					DB db = new DB();
					string query = "DELETE FROM Lesson WHERE id_lesson = @id";
					using (SqlCommand command = new SqlCommand(query, db.getConnection()))
					{
						command.Parameters.AddWithValue("@id", idLesson);
						db.getConnection().Open();
						int result = command.ExecuteNonQuery();

						if (result == 1)
						{
							notifyIcon1.Icon = SystemIcons.Hand;
							notifyIcon1.BalloonTipTitle = "Удаление дисциплины";
							notifyIcon1.BalloonTipText = "Дисциплина удалена из системы";
							notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
							notifyIcon1.Visible = true;
							notifyIcon1.ShowBalloonTip(80000);
						}
						db.getConnection().Close();
					}
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Выбирите ячейку для просмотра информации", "Система");
			}
			this.lessonTableAdapter1.Fill(this.timeTableDataSet5.Lesson);
		}

		#endregion

		#region Panel EditCard

		private void addTeacher1_Click(object sender, EventArgs e)
		{
			changeTeacher(0);
		}

		private void addTeacher2_Click(object sender, EventArgs e)
		{
			changeTeacher(1);
		}

		private void addTeacher3_Click(object sender, EventArgs e)
		{
			changeTeacher(2);
		}

		private void addTeacher4_Click(object sender, EventArgs e)
		{
			changeTeacher(3);
		}

		private void addTeacher5_Click(object sender, EventArgs e)
		{
			changeTeacher(4);
		}

		private void changeTeacher(int numberLesson)
		{
			EdirAddTeacher editAdd = new EdirAddTeacher();
			editAdd.ShowDialog();

			string[][] rows = editAdd.checkTeacher;
			if (!(rows == null))
			{
				tbTeacher[numberLesson].Text = "";
				nowDayTeacher[numberLesson] = rows;  // номер пары где поменяли препода
				for (int i = 0; i < rows.Length; i++)
				{
					tbTeacher[numberLesson].Text += rows[i][2] + " " + rows[i][1] + "\n";
				}
			}
		}

		private void cbGroupEdit_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				int group = Convert.ToInt32(cbGroupEdit.SelectedValue.ToString());
				int week = Convert.ToInt32(cbWeekEdit.SelectedValue.ToString());
				for (int i = 0; i < daysLesson.Length; i++)
				{
					daysLesson[i] = new DayLesson(group, i + 1, week);
					daysLesson[i].selectDB();
				}
				viewDaysTabPanel_SelectedIndexChanged(sender, e);
			}
			catch (Exception)
			{

			}
		}

		private void cbWeekEdit_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				int group = Convert.ToInt32(cbGroupEdit.SelectedValue.ToString());
				int week = Convert.ToInt32(cbWeekEdit.SelectedValue.ToString());
				for (int i = 0; i < daysLesson.Length; i++)
				{
					daysLesson[i] = new DayLesson(group, i + 1, week);
					daysLesson[i].selectDB();
				}
				viewDaysTabPanel_SelectedIndexChanged(sender, e);
			}
			catch (Exception)
			{
								
			}
		}

		public void clickViewEditDay(int dayWeek)
		{
			day = daysLesson[dayWeek].selectDB();
			titleWeekDay.Text = weekDayName[dayWeek];
			nowWeekDay = dayWeek;

			for (int i = 0; i < cbLesson.Length; i++)
			{
				cbLesson[i].SelectedIndex = 0;
				cbOffice[i].SelectedIndex = 0;
				cbLecture[i].Checked = false;
			}

			if (day != null)
			{
				string text = "";
				try
				{ 
					for (int i = 0; i < cbLesson.Length; i++)		// номер пары
					{
						nowDayTeacher[i] = new string[4][];
						if (!(day[i] == null))
						{
							for (int j = 0; j + 1 < day[i].Length; j++)
							{
								nowDayTeacher[i][j] = new string[3];
								if (!(day[i][j] == null))
								{
									nowDayTeacher[i][j][0] = day[i][j][14];
									nowDayTeacher[i][j][1] = day[i][j][9];
									nowDayTeacher[i][j][2] = day[i][j][8];
									if (j == 0)
									{
										cbLesson[i].SelectedIndex = Convert.ToInt32(day[i][j][12])-1 ;
										int indexOffice = cbOffice[i].FindString(day[i][j][13]);
										cbOffice[i].SelectedIndex = indexOffice;
										bool checkLecture = day[i][j][4].ToString().Equals("2") ? true : false;
										cbLecture[i].Checked = checkLecture;
										text = day[i][j][9] + " " + day[i][j][8] + "\n ";
									}
									else
									{
										text += day[i][j][9] + " " + day[i][j][8] + "\n ";

									}
								}
							}
							tbTeacher[i].Text = text;
							text = "";
						}
					}
				}
				catch (Exception) { }
			}
		}

		private void saveEditDay_Click(object sender, EventArgs e)
		{
			var result = MessageBox.Show("Вы хотите заменить данные дня?", "Составление расписание", MessageBoxButtons.YesNoCancel);
			if (result == DialogResult.No || result == DialogResult.Cancel)
			{
				return;
			}

			string[][] editLessons = new string[5][];
			int count = 4;
			int weekDay;
			for (int i = 0; i < editLessons.Length; i++)		// номер пары
			{
				string a = cbLesson[i].SelectedIndex.ToString();
				string b = cbOffice[i].Text;
				string id = day[i][0] == null ? "" : Convert.ToInt32(day[i][0][0]).ToString();
				editLessons[i] = new string[count];
				editLessons[i][0] = id;
				if (!(a.Equals("0") || b.Equals(" ") /*|| */))															//////////////////////////////    user.Item1
				{
					editLessons[i][1] = a;
					editLessons[i][2] = b;
					editLessons[i][3] = Convert.ToInt32(cbLecture[i].Checked).ToString();
				}
			}

			nowDayTeacher = nowDayTeacher.Where(x => x != null).Select(x => x.Where(y => y != null).ToArray()).ToArray();
			int[] countTeacher = new int[6];

			for (int i = 0; i < nowDayTeacher.Length; i++)
			{
				for (int j = 0; j < nowDayTeacher[i].Length; j++)
				{
					if (!(nowDayTeacher[i][j][0] == null))
					{
						countTeacher[i] += 1;
					}
				}
			}


			for (int i = 0; i < editLessons.Length; i++)
			{

				if (!(editLessons[i][0].Equals("") && editLessons[i][1] == null))
				{
					string addTeacher = "";
					switch (countTeacher[i])
					{
						case 0:
							MessageBox.Show("Заполните преподавателей", "Система");
							return;
						case 1:
							if (!(nowDayTeacher[i][0][0] == null))
							{
								addTeacher = "(" + nowDayTeacher[i][0][0] +")";
							}
							break; 
						case 2:
							addTeacher += "(";
							for (int j = 0; j < nowDayTeacher[i].Length; j++)
							{
								if (!(nowDayTeacher[i][j][0] == null))
								{
									addTeacher += nowDayTeacher[i][j][0] + ", ";
								}
							}
							addTeacher = addTeacher.Substring(0, addTeacher.Length - 2);
							addTeacher += ")";
							break;
						case 3:
							addTeacher += "(";
							for (int j = 0; j < nowDayTeacher[i].Length; j++)
							{
								if (!(nowDayTeacher[i][j][0] == null))
								{
									addTeacher += nowDayTeacher[i][j][0] + ", ";
								}
							}
							addTeacher.Substring(0, addTeacher.Length - 1);
							addTeacher += ")";
							break;
						case 4:
							addTeacher += "(";
							for (int j = 0; j < nowDayTeacher[i].Length; j++)
							{
								if (!(nowDayTeacher[i][j][0] == null))
								{
									addTeacher += nowDayTeacher[i][j][0] + ", ";
								}
							}
							addTeacher.Substring(0, addTeacher.Length - 1);
							addTeacher += ")";
							break;
						default:
							break;
					}

					DB db = new DB();
					db.openConnection();



					string query = $"DECLARE @ids TABLE(id int);" +
					" DECLARE @id int;" +
						" INSERT INTO @ids(id)" +
						" SELECT id FROM AppointmentLesson WHERE week = @week AND weekDay = @weekDay AND numberLesson = @numberLesson AND  id <> @idLes; " +
					" IF NOT EXISTS(SELECT * FROM Teacher_AppointmentLesson WHERE id_appointmentLesson IN(SELECT id FROM @ids) AND id_teacher IN" + addTeacher + ")" +
						" BEGIN" +
							" IF NOT EXISTS(SELECT * FROM AppointmentLesson WHERE id = @idLes)" +
							" BEGIN" +
							" IF EXISTS(SELECT * FROM AppointmentLesson WHERE office = @office AND week = @week AND weekDay = @weekDay AND numberLesson = @numberLesson)" +
								" BEGIN" +
									" SELECT 'Кабинет занят' AS Warning;" +
								" END" +
								" ELSE" +
								" BEGIN" +
									" INSERT INTO AppointmentLesson(office, lesson, week, weekDay, numberLesson, typeLesson)" +
									" VALUES(@office, @lesson, @week, @weekDay, @numberLesson, @typeLesson); " +
										" SET @id = SCOPE_IDENTITY(); " +
										" INSERT INTO Teacher_AppointmentLesson(id_appointmentLesson, id_teacher)" +
									" SELECT @id, id_teacher FROM Teacher WHERE id_teacher IN" + addTeacher + "; " +
										" INSERT INTO Group_AppointmentLessons(group_student, id_appointment_lesson)" +
									" VALUES(@group, @id)" +
								"END" +
							" END" +
							" ELSE" +
							" BEGIN" +
							" IF EXISTS(SELECT * FROM AppointmentLesson WHERE office = @office AND week = @week AND weekDay = @weekDay AND numberLesson = @numberLesson AND  id <> @idLes)" +
								" BEGIN" +
									" SELECT 'Кабинет занят' AS Warning;" +
								" END" +
								" ELSE" +
								" BEGIN" +
									" UPDATE AppointmentLesson" +
									" SET office = @office, lesson = @lesson, week = @week, weekDay = @weekDay, numberLesson = @numberLesson, typeLesson = @typeLesson" +
									" WHERE id = @idLes; " +
										" DELETE FROM Teacher_AppointmentLesson WHERE id_appointmentLesson = @idLes" +
									" DELETE FROM Group_AppointmentLessons WHERE id_appointment_lesson = @idLes" +
									" INSERT INTO Teacher_AppointmentLesson(id_appointmentLesson, id_teacher)" +
									" SELECT @idLes, id_teacher FROM Teacher WHERE id_teacher IN" + addTeacher + "; " +
									" INSERT INTO Group_AppointmentLessons(group_student, id_appointment_lesson)" +
									" VALUES(@group, @idLes)" +
								"END" +
							" END" +
						" END" +
						" ELSE" +
						" BEGIN" +
							" DELETE FROM AppointmentLesson WHERE id = @id; " +
							" SELECT 'Преподаватель занят' AS Warning; " +
							" END";




					/*string query = $"DECLARE @ids TABLE(id int);" +
					" DECLARE @id int;" +
					" IF EXISTS(SELECT * FROM AppointmentLesson WHERE office = @office AND week = @week AND weekDay = @weekDay AND numberLesson = @numberLesson)" +
					" BEGIN" +
						" SELECT 'Кабинет занят' AS Warning;" +
					" END" +
					" ELSE" +
					" BEGIN" +
						" INSERT INTO @ids(id)" +
						" SELECT id FROM AppointmentLesson WHERE week = @week AND weekDay = @weekDay AND numberLesson = @numberLesson AND  id <> @idLes; " +
									" IF NOT EXISTS(SELECT * FROM Teacher_AppointmentLesson WHERE id_appointmentLesson IN(SELECT id FROM @ids) AND id_teacher IN" + addTeacher + ")" +
						" BEGIN" +
							" IF NOT EXISTS(SELECT * FROM AppointmentLesson WHERE id = @idLes)" +
							" BEGIN" +
								" INSERT INTO AppointmentLesson(office, lesson, week, weekDay, numberLesson, typeLesson)" +
								" VALUES(@office, @lesson, @week, @weekDay, @numberLesson, @typeLesson); " +
									" SET @id = SCOPE_IDENTITY(); " +
									" INSERT INTO Teacher_AppointmentLesson(id_appointmentLesson, id_teacher)" +
								" SELECT @id, id_teacher FROM Teacher WHERE id_teacher IN" + addTeacher + "; " +
									" INSERT INTO Group_AppointmentLessons(group_student, id_appointment_lesson)" +
								" VALUES(@group, @id)" +
							" END" +
							" ELSE" +
							" BEGIN" +
								" UPDATE AppointmentLesson" +
								" SET office = @office, lesson = @lesson, week = @week, weekDay = @weekDay, numberLesson = @numberLesson, typeLesson = @typeLesson" +
								" WHERE id = @idLes; " +
									" DELETE FROM Teacher_AppointmentLesson WHERE id_appointmentLesson = @idLes" +
								" DELETE FROM Group_AppointmentLessons WHERE id_appointment_lesson = @idLes" +
								" INSERT INTO Teacher_AppointmentLesson(id_appointmentLesson, id_teacher)" +
								" SELECT @idLes, id_teacher FROM Teacher WHERE id_teacher IN" + addTeacher + "; " +
							" INSERT INTO Group_AppointmentLessons(group_student, id_appointment_lesson)" +
								" VALUES(@group, @idLes)" +
							" END" +
						" END" +
						" ELSE" +
						" BEGIN" +
							" DELETE FROM AppointmentLesson WHERE id = @id; " +
							" SELECT 'Преподаватель занят' AS Warning; " +
							" END" +
						" END";*/

					/*string query = $"DECLARE @ids TABLE (id int);"
                    + " DECLARE @id int;"
					+ " IF EXISTS (SELECT * FROM AppointmentLesson WHERE office = @office AND week = @week AND weekDay = @weekDay AND numberLesson = @numberLesson)"
					+ " BEGIN    SELECT 'Кабинет занят' AS Warning;"
					+ " END ELSE BEGIN INSERT INTO AppointmentLesson (office, lesson, week, weekDay, numberLesson, typeLesson)"
					+ " VALUES (@office, @lesson, @week, @weekDay, @numberLesson, @typeLesson);"
					+ " SET @id = SCOPE_IDENTITY();"
					+ " INSERT INTO @ids (id)"
					+ " SELECT id FROM AppointmentLesson WHERE week = @week AND weekDay = @weekDay AND numberLesson = @numberLesson;"
					+ " IF NOT EXISTS (SELECT * FROM Teacher_AppointmentLesson WHERE id_appointmentLesson IN (SELECT id FROM @ids) AND id_teacher IN" + addTeacher + ")"
					+ " BEGIN"
					+ " INSERT INTO Teacher_AppointmentLesson (id_appointmentLesson, id_teacher)"
					+ " SELECT @id, id_teacher FROM Teacher WHERE id_teacher IN" + addTeacher + ";"
					+ " INSERT INTO Group_AppointmentLessons (group_student, id_appointment_lesson)"
					+ " VALUES (1, @id)" 
					+ " END"
					+ " ELSE"
					+ " BEGIN"
					+ " DELETE FROM AppointmentLesson WHERE id = @id;"
					+ " SELECT 'Преподаватель занят' AS Warning; END END";*/

					/*string query = $"DECLARE @ids TABLE (id int);" +
					$"DECLARE @id int;" +
					$"IF EXISTS (SELECT * FROM AppointmentLesson WHERE office = @office AND week = @week AND weekDay = @weekDay AND numberLesson = @numberLesson)" +
					$"BEGIN SELECT 'Кабинет занят' AS Warning;" +
					$"END ELSE BEGIN INSERT INTO AppointmentLesson (office, lesson, week, weekDay, numberLesson, typeLesson)" +
					$"VALUES (@office, @lesson, @week, @weekDay, @numberLesson, @typeLesson);" +
					$"SET @id = SCOPE_IDENTITY();" +
					$"INSERT INTO @ids (id)" +
					$"SELECT id FROM AppointmentLesson WHERE week = @week AND weekDay = @weekDay AND numberLesson = @numberLesson;" +
					$"IF NOT EXISTS (SELECT * FROM Teacher_AppointmentLesson WHERE id_appointmentLesson IN (SELECT id FROM @ids) AND id_teacher IN" + addTeacher + ")" +
					$"BEGIN" +
					$"INSERT INTO Teacher_AppointmentLesson (id_appointmentLesson, id_teacher)" +
					$"SELECT @id, id_teacher FROM Teacher WHERE id_teacher IN" + addTeacher + ";" +
					$"INSERT INTO Group_AppointmentLessons (group_student, id_appointment_lesson)" +
					$"VALUES (1, @id);" +
					$"END ELSE BEGIN" +
					$"DELETE FROM AppointmentLesson WHERE id = @id;" +
					$"SELECT 'Преподаватель занят' AS Warning;" +
					$"END";*/
					/*string query = $"DECLARE @ids TABLE (id int);" +
				   $" DECLARE @id int;" +
				   $" IF EXISTS (SELECT * FROM AppointmentLesson WHERE office = @office AND week = @week AND weekDay = @weekDay AND numberLesson = @numberLesson)" +
				   $" BEGIN INSERT INTO AppointmentLesson (office, lesson, week, weekDay, numberLesson, typeLesson)" +
				   $" VALUES (@office, @lesson, @week, @weekDay, @numberLesson, @typeLesson);" +
				   $" SET @id = SCOPE_IDENTITY();" +
				   $" INSERT INTO @ids (id)" +
				   $" SELECT id FROM AppointmentLesson WHERE week = @week AND weekDay = @weekDay AND numberLesson = @numberLesson;" +
				   $" IF NOT EXISTS (SELECT * FROM Teacher_AppointmentLesson WHERE id_appointmentLesson IN (SELECT id FROM @ids) AND id_teacher IN" + addTeacher + ")" +
				   $" BEGIN" +
				   $" INSERT INTO Teacher_AppointmentLesson (id_appointmentLesson, id_teacher)" +
				   $" SELECT @id, id_teacher FROM Teacher WHERE id_teacher IN" + addTeacher + ";" +
				   $" INSERT INTO Group_AppointmentLessons (group_student, id_appointment_lesson)" +
				   $" VALUES (1, @id)" +
				   $" END " +
				   $" ELSE BEGIN" +
				   $" DELETE FROM AppointmentLesson WHERE id = @id;" +
				   $" SELECT 'Преподаватель занят' AS Warning;" +
				   $" END";*/
					/*string query = "DECLARE @ids TABLE (id int); " +
				   "DECLARE @id int; " +
				   "IF EXISTS (SELECT * FROM AppointmentLesson WHERE office = '502' AND week = 1 AND weekDay = 3 AND numberLesson = 1) " +
				   "BEGIN SELECT 'Кабинет занят' AS Warning; " +
				   "END ELSE BEGIN INSERT INTO AppointmentLesson (office, lesson, week, weekDay, numberLesson, typeLesson) " +
				   "VALUES ('502', 3, 1, 2, 1, 1); " +
				   "SET @id = SCOPE_IDENTITY(); " +
				   "INSERT INTO @ids (id) " +
				   "SELECT id FROM AppointmentLesson WHERE week = 1 AND weekDay = 2 AND numberLesson = 1; " +
				   "IF NOT EXISTS (SELECT * FROM Teacher_AppointmentLesson WHERE id_appointmentLesson IN (SELECT id FROM @ids) AND id_teacher IN (4, 8)) " +
				   "BEGIN INSERT INTO Teacher_AppointmentLesson (id_appointmentLesson, id_teacher) " +
				   "SELECT @id, id_teacher FROM Teacher WHERE id_teacher IN (4, 8); " +
				   "INSERT INTO Group_AppointmentLessons (group_student, id_appointment_lesson) " +
				   "VALUES (1, @id) " +
				   "END ELSE BEGIN " +
				   "DELETE FROM AppointmentLesson WHERE id = @id; " +
				   "SELECT 'Преподаватель занят' AS Warning; " +
				   "END END";*/


					SqlCommand command = new SqlCommand(query, db.getConnection());
					int id = editLessons[i][0].Equals("") ? 2000 : Convert.ToInt32(editLessons[i][0]);
					command.Parameters.AddWithValue("@idLes", id);
					command.Parameters.AddWithValue("@office", editLessons[i][2]);
					command.Parameters.AddWithValue("@lesson", Convert.ToInt32(editLessons[i][1]) + 1);
					command.Parameters.AddWithValue("@week", cbWeekEdit.SelectedIndex + 1);
					command.Parameters.AddWithValue("@weekDay", nowWeekDay + 1);
					command.Parameters.AddWithValue("@numberLesson", i + 1);
					command.Parameters.AddWithValue("@typeLesson", Convert.ToInt32(editLessons[i][3]) + 1);
					command.Parameters.AddWithValue("@group", (int)cbGroupEdit.SelectedValue);
					SqlDataReader reader = command.ExecuteReader();
					if (reader.Read())
					{
						//MessageBox.Show(reader.GetString(0), "Система");
						new MessageForm(reader.GetString(0), "Система").ShowDialog();
					}
					reader.Close();
					db.closeConnection(); 


					/*DB db = new DB();
					db.openConnection();
					string query = "MERGE INTO AppointmentLesson AS target " +
				   "USING (SELECT @id AS id, @office AS office, @lesson AS lesson, @week AS week, @weekDay AS weekDay, @numberLesson AS numberLesson, @typeLesson AS typeLesson) AS source " +
				   "ON target.id = source.id " +
				   "WHEN MATCHED THEN " +
				   "    UPDATE SET office = source.office, lesson = source.lesson, week = source.week, weekDay = source.weekDay, numberLesson = source.numberLesson, typeLesson = source.typeLesson " +
				   "WHEN NOT MATCHED THEN " +
				   "    INSERT (office, lesson, week, weekDay, numberLesson, typeLesson) VALUES (source.office, source.lesson, source.week, source.weekDay, source.numberLesson, source.typeLesson);";
					SqlCommand command = new SqlCommand(query, db.getConnection());
					int id = editLessons[i][0].Equals("") ? 2000 : Convert.ToInt32(editLessons[i][0]);
					command.Parameters.AddWithValue("@id", id);
					command.Parameters.AddWithValue("@office", editLessons[i][2]);
					command.Parameters.AddWithValue("@lesson", Convert.ToInt32(editLessons[i][1]) + 1);
					command.Parameters.AddWithValue("@week", cbWeekEdit.SelectedIndex + 1);
					command.Parameters.AddWithValue("@weekDay", nowWeekDay + 1);
					command.Parameters.AddWithValue("@numberLesson", i + 1);
					command.Parameters.AddWithValue("@typeLesson", Convert.ToInt32(editLessons[i][3]) + 1);
					SqlDataReader reader = command.ExecuteReader();
					db.closeConnection();*/

				}

			}

			/*if (day != null)
			{
				string text = "";
				try
				{
					for (int i = 0; i < cbLesson.Length; i++)
					{
						if (!(day[i] == null))
						{
							for (int j = 0; j + 1 < day[i].Length; j++)
							{
								if (!(day[i][j] == null))
								{
									if (j == 0)
									{
										cbLesson[i].SelectedIndex = Convert.ToInt32(day[i][j][12]) - 1;
										int indexOffice = cbOffice[i].FindString(day[i][j][13]);
										cbOffice[i].SelectedIndex = indexOffice;
										bool checkLecture = day[i][j][4].ToString().Equals("1") ? true : false;
										cbLecture[i].Checked = checkLecture;
										text = day[i][j][9] + " " + day[i][j][8] + "\n ";
									}
									else
									{
										text += day[i][j][9] + " " + day[i][j][8] + "\n ";
									}
								}
							}
							tbTeacher[i].Text = text;
							text = "";
						}
					}
				}
				catch (Exception) { }
			}*/
		}

		#endregion

		private void LogIn_Click(object sender, EventArgs e)
		{
			if (LogIn.Text.Equals("Выйти"))
			{
				user.Item1 = 0;
				user.Item2 = "";
				user.Item3 = "";
				user.Item4 = 0;

				LogIn.Text = "Войти";
			}
			else
			{
				Auntification auntification = new Auntification();
				auntification.ShowDialog();
				user = auntification.GetIdUser;
				if (user.Item1 != 0) LogIn.Text = "Выйти";
			}

		}

		private string printText;

		private void btnPrint_Click(object sender, EventArgs e)
		{
			if (!(user.Item4 >= 2)) { new MessageForm("Зарегистрируйтесь в системе, что бы использовать функцию Печать", "Система").ShowDialog(); return; }

			string[][][] printDay = new string[5][][];
			printText += "\n" + "Группа: " + cbGroupStudent.Text.Trim() + " Неделя: " + cbWeek.Text + "\n";
			for (int t = 0; t < daysLesson.Length; t++)
			{
				printDay = daysLesson[t].selectDB();
				printText += "\n" + weekDayName[t] + "\n";
				if (printDay != null)
				{
					try
					{
						for (int i = 0; i < printDay.Length; i++)
						{
							if (!(printDay[i] == null))
							{
								for (int j = 0; j + 1 < printDay[i].Length; j++)
								{
									if (!(printDay[i][j] == null))
									{
										if (j == 0)
										{
											printText += (i + 1) + ". " + printDay[i][j][2] + " (" + printDay[i][j][3] + ") \n" +
												"- " + printDay[i][j][9] + " " + printDay[i][j][10] + "\n";
										}
										else
										{
											printText += "- " + printDay[i][j][9] + " " + printDay[i][j][10] + "\n ";
											break;
										}
									} else if (j == 0)
									{
										printText += (i + 1) + ". " + "__________________________\n";

									}
								}
							}
						}
					}
					catch (Exception) { }
				}
			}

			PrintDocument printDocument = new PrintDocument();

			printDocument.PrintPage += PrintPageHandler;

			PrintDialog printDialog = new PrintDialog();

			printDialog.Document = printDocument;

			if (printDialog.ShowDialog() == DialogResult.OK)
				printDialog.Document.Print();
			printText = "";
		}

		void PrintPageHandler(object sender, PrintPageEventArgs e)
		{
			e.Graphics.DrawString(printText, new Font("Arial", 11), Brushes.Black, 7, 7);
		}
	}
}
