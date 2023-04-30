using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;
using DataLessonsCours3.View;
using System.Data.SqlClient;

namespace DataLessonsCours3.Class
{
	public class DayLesson
	{
		int group, weekDay, week;
		public DayLesson(int group, int weekDay, int week)
		{
			this.group = group;
			this.weekDay = weekDay;
			this.week = week;
		}

		public string[][][] selectDB()
		{
			string[][][] day = new string[6][][];
			DB db = new DB();
			db.openConnection();
			string quest = $"SELECT AppointmentLesson.id, AppointmentLesson.numberLesson, Lesson.fullNameLesson, \r\nLesson.shortNameLesson, \r\nTypeLesson.type_lesson, \r\nOffice.id_office, \r\nweekDay.weekDay,\r\nGroupStudent.shortNameGroup,\r\nTeacher.name,\r\nTeacher.firstName, \r\nTeacher.otchestvo\r\n\r\nFROM \r\nLesson, Week, NumberLesson, \r\nTypeLesson, WeekDay, \r\nOffice, \r\nTeacher,\r\nGroupStudent,\r\nAppointmentLesson\r\nJOIN Group_AppointmentLessons ON (AppointmentLesson.id = Group_AppointmentLessons.id_appointment_lesson)\r\nJOIN Teacher_AppointmentLesson ON (AppointmentLesson.id = Teacher_AppointmentLesson.id_appointmentLesson)\r\n\r\nWHERE\r\nAppointmentLesson.lesson = Lesson.id_lesson AND\r\nAppointmentLesson.week = Week.id_week AND\r\nAppointmentLesson.numberLesson = NumberLesson.id_number_lesson AND\r\nAppointmentLesson.typeLesson = TypeLesson.type_lesson AND\r\nAppointmentLesson.office = Office.id_office AND\r\nAppointmentLesson.weekDay = WeekDay.id_weekDay AND\r\nGroup_AppointmentLessons.group_student = GroupStudent.idGroup AND\r\nTeacher_AppointmentLesson.id_teacher = Teacher.id_teacher AND\r\nGroupStudent.idGroup = @group AND\r\nWeekDay.id_weekDay = @weekDay AND\r\nWeek.id_week = @week";
			SqlCommand command = new SqlCommand(quest, db.getConnection());
			command.Parameters.AddWithValue("@group", group);
			command.Parameters.AddWithValue("@weekDay", weekDay);
			command.Parameters.AddWithValue("@week", week);
			SqlDataReader reader = command.ExecuteReader();

			int count = 1;
			int numberLesson = 0;
			int teacher = 1;    //для отображения всех преподавателей
			while (reader.Read())
			{
				if (count == 1) numberLesson = reader.GetInt32(1);
				count++;
				/*if (!(numberLesson == reader.GetInt32(1)))
				{
					day[numberLesson] = new string[4][];
					day[numberLesson][0] = new string[reader.FieldCount]; // Создание массива с заданным кол-вом столбцов
					for (int i = 0; i < reader.FieldCount; i++)
					{
						day[count][0][i] = reader[i].ToString().Trim();
					}
					numberLesson++;

					count++;
					teacher = 1;
				}
				else
				{
					//day[count] = new string[4][];
					day[count][teacher] = new string[reader.FieldCount]; // Создание массива с заданным кол-вом столбцов
					for (int i = 0; i < reader.FieldCount; i++)
					{
						day[count][teacher][i] = reader[i].ToString().Trim();
					}
					teacher++;
				}*/


				//надо сделать, чтоб данные сохранялись 

				/*if (numberLesson == reader.GetInt32(1))
				{
					day[numberLesson] = new string[2][];
					day[numberLesson][0] = new string[reader.FieldCount];
					for (int i = 0; i < reader.FieldCount; i++)
					{
						day[numberLesson][0][i] = reader[i].ToString().Trim();
					}
				} else
				{
					day[numberLesson][teacher] = new string[reader.FieldCount];
					for (int i = 0; i < reader.FieldCount; i++)
					{
						day[numberLesson][teacher][i] = reader[i].ToString().Trim();
					}
					teacher++;
					numberLesson = reader.GetInt32(1);
				}*/




				/*if (numberLesson == reader.GetInt32(1))
				{
					count++;
					day[count] = new string[4][];
					day[count][0] = new string[reader.FieldCount]; // Создание массива с заданным кол-вом столбцов
					for (int i = 0; i < reader.FieldCount; i++)
					{
						day[count][0][i] = reader[i].ToString().Trim();
					}
					numberLesson++;
					
					teacher = 1;
				}
				else
				{
					//day[count] = new string[4][];
					day[count][teacher] = new string[reader.FieldCount]; // Создание массива с заданным кол-вом столбцов
					for (int i = 0; i < reader.FieldCount; i++)
					{
						day[count][teacher][i] = reader[i].ToString().Trim();
					}
					teacher++;
				}*/
				
			}
			reader.Close();
			db.closeConnection();
			return day;


			/*int count = -1;					// работает, но только первая пара жолжна быть всегда заполнена
			int numberLesson = 1;
			int teacher = 1;	//для отображения всех преподавателеё
			while (reader.Read())
			{

				if (numberLesson == reader.GetInt32(1))
				{
					count++;
					day[count] = new string[4][];
					day[count][0] = new string[reader.FieldCount]; // Создание массива с заданным кол-вом столбцов
					for (int i = 0; i < reader.FieldCount; i++)
					{
						day[count][0][i] = reader[i].ToString().Trim();
					}
					numberLesson++;
					
					teacher = 1;
				}
				else
				{
					//day[count] = new string[4][];
					day[count][teacher] = new string[reader.FieldCount]; // Создание массива с заданным кол-вом столбцов
					for (int i = 0; i < reader.FieldCount; i++)
					{
						day[count][teacher][i] = reader[i].ToString().Trim();
					}
					teacher++;
				}
				
			}
			reader.Close();
			db.closeConnection();
			return day;*/

		}
	}
}
