using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;
using DataLessonsCours3.View;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Security.AccessControl;

namespace DataLessonsCours3.Class
{
	public class DayLesson
	{
		int group, weekDay, week;
		string[][][] day;
		public DayLesson(int group, int weekDay, int week)
		{
			this.group = group;
			this.weekDay = weekDay;
			this.week = week;
		}

		public string[][][] selectDB()
		{
			day = new string[6][][];
			string[][] lesson = new string[10][];
			DB db = new DB();
			db.openConnection();
			string quest = $"SELECT AppointmentLesson.id, " +
				$"AppointmentLesson.numberLesson, Lesson.fullNameLesson, " +
				$"\r\nLesson.shortNameLesson, \r\nTypeLesson.type_lesson, " +
				$"\r\nOffice.id_office, \r\nweekDay.weekDay,\r\nGroupStudent.shortNameGroup," +
				$"\r\nTeacher.name,\r\nTeacher.firstName, \r\nTeacher.otchestvo,\r\nLesson.linkMudl, Lesson.id_lesson,\r\nOffice.id_office,\r\nTeacher.id_teacher" +
				$"\r\n\r\n" +
				$"FROM" +
				$" \r\nLesson, Week, NumberLesson, \r\nTypeLesson, WeekDay, " +
				$"\r\nOffice, \r\nTeacher,\r\nGroupStudent,\r\nAppointmentLesson\r\nJOIN Group_AppointmentLessons ON (AppointmentLesson.id = Group_AppointmentLessons.id_appointment_lesson)" +
				$"\r\nJOIN Teacher_AppointmentLesson ON (AppointmentLesson.id = Teacher_AppointmentLesson.id_appointmentLesson)\r\n\r\n" +
				$"WHERE" +
				$"\r\nAppointmentLesson.lesson = Lesson.id_lesson AND\r\nAppointmentLesson.week = Week.id_week AND\r\n" +
				$"AppointmentLesson.numberLesson = NumberLesson.id_number_lesson AND\r\nAppointmentLesson.typeLesson = TypeLesson.type_lesson AND\r\n" +
				$"AppointmentLesson.office = Office.id_office AND\r\nAppointmentLesson.weekDay = WeekDay.id_weekDay AND\r\n" +
				$"Group_AppointmentLessons.group_student = GroupStudent.idGroup AND\r\nTeacher_AppointmentLesson.id_teacher = Teacher.id_teacher AND\r\n" +
				$"GroupStudent.idGroup = @group AND\r\nWeekDay.id_weekDay = @weekDay AND\r\nWeek.id_week = @week";
			SqlCommand command = new SqlCommand(quest, db.getConnection());
			command.Parameters.AddWithValue("@group", group);
			command.Parameters.AddWithValue("@weekDay", weekDay);
			command.Parameters.AddWithValue("@week", week);
			SqlDataReader reader = command.ExecuteReader();

			int count = 1;
			while (reader.Read())
			{
				lesson[count] = new string[reader.FieldCount];

				for (int i = 0; i < reader.FieldCount; i++)
				{
				lesson[count][i] = reader[i].ToString().Trim();
				}
				count++;
			}
			reader.Close();
			db.closeConnection();

			int c, startJ = 1, countJ = 0;
			day = new string[6][][];
			for (int i = 0; i < 5; i++)
			{
				day[i] = new string[4][];
				countJ = 0;
				for (int j = startJ; j < lesson.Length; j++)		// заполнение преподов
				{
					if (!(lesson[j] == null))
					{
						c = i + 1;
						if (lesson[j][1].Equals(c.ToString()))
						{
							day[i][countJ] = new string[lesson[j].Length];
							
							for (int k = 0; k < lesson[j].Length; k++)		// заполнение данных
							{
								day[i][countJ][k] = lesson[j][k];
							}
							startJ = j + 1;
							countJ++;
						}
					}
				}
			}
			return day;
		}

		public string[][][] GetDay
		{
			get { return day; }
		}

	}
}
