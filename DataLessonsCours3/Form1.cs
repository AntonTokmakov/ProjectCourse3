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

namespace DataLessonsCours3
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
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
				case 0:
					mainLayout.Controls.Clear();
					for (int i = 1; i < 5; i++)
					{
						DB db = new DB();
						db.openConnection();
						string quest = $"SELECT AppointmentLesson.numberLesson, Lesson.fullNameLesson, \r\nLesson.shortNameLesson, \r\nTypeLesson.type_lesson, \r\nOffice.id_office, \r\nweekDay.weekDay,\r\nGroupStudent.shortNameGroup,\r\nTeacher.name,\r\nTeacher.firstName, \r\nTeacher.otchestvo\r\n\r\nFROM \r\nLesson, Week, NumberLesson, \r\nTypeLesson, WeekDay, \r\nOffice, \r\nTeacher,\r\nGroupStudent,\r\nAppointmentLesson\r\nJOIN Group_AppointmentLessons ON (AppointmentLesson.id = Group_AppointmentLessons.id_appointment_lesson)\r\nJOIN Teacher_AppointmentLesson ON (AppointmentLesson.id = Teacher_AppointmentLesson.id_appointmentLesson)\r\n\r\nWHERE\r\nAppointmentLesson.lesson = Lesson.id_lesson AND\r\nAppointmentLesson.week = Week.id_week AND\r\nAppointmentLesson.numberLesson = NumberLesson.id_number_lesson AND\r\nAppointmentLesson.typeLesson = TypeLesson.type_lesson AND\r\nAppointmentLesson.office = Office.id_office AND\r\nAppointmentLesson.weekDay = WeekDay.id_weekDay AND\r\nGroup_AppointmentLessons.group_student = GroupStudent.idGroup AND\r\nTeacher_AppointmentLesson.id_teacher = Teacher.id_teacher AND\r\nGroupStudent.idGroup = {cbGroupStudent.SelectedValue.ToString()} AND\r\nWeekDay.id_weekDay = {i} AND\r\nWeek.id_week = {cbWeek.SelectedValue.ToString()}";
						SqlCommand command = new SqlCommand(quest, db.getConnection());
						SqlDataReader reader = command.ExecuteReader();
						CardDayLessons cardDay = new CardDayLessons(reader);
						mainLayout.Controls.Add(cardDay);
						db.closeConnection();


						/*CardDayLessons cardDay = new CardDayLessons("Понедельник", "УиАБД", "ТРПО", "ИСРПО", "ПД", "Мат мод",		//добавлять данные из БД
						"https://do.sibsiu.ru/day/course/view.php?id=19370", "", "","","");
						mainLayout.Controls.Add(cardDay);*/
					}
					
					break;

				case 1:
					break;

				case 2:
					examLayoutPanel.Controls.Clear();
					for (int i = 0; i < 5; i++)
					{
						CardExam cardExam = new CardExam();

						examLayoutPanel.Controls.Add(cardExam);
					}
					break; 

				case 3:
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
			viewDaysTabPanel.SelectTab(1);
		}

		private void selectSpr_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch (selectSpr.SelectedIndex)
			{
				case 1:
					viewDaysTabPanel.SelectTab(3);
					break;
				case 2:
					viewDaysTabPanel.SelectTab(4);
					break;
				case 3:
					viewDaysTabPanel.SelectTab(5);
					break;
				default:
					viewDaysTabPanel.SelectedIndex = 0;
					break;
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
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

		}

		private void fillByToolStripButton_Click(object sender, EventArgs e)
		{
			try
			{
				this.teacherTableAdapter.FillBy(this.timeTableDataSet.Teacher);
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}

		}

		private void btnAddTicher_Click(object sender, EventArgs e)
		{
			new AddTeacher().ShowDialog();
		}
	}
}
