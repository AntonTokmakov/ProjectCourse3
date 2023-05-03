using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace DataLessonsCours3.View
{
	public partial class CardDayLessons : UserControl
	{
		public CardDayLessons(SqlDataReader reader, int weekDay)
		{
			InitializeComponent();
			string[] weekDayName = new string[] { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота" };

			nameDayLabel.Text = weekDayName[weekDay];
			System.Windows.Forms.Label[] labels = new System.Windows.Forms.Label[] { firstLessonLabel, secondLessonLabel, thirdLessonLabel, fourLessonLabel, fiveLessonLabel};
			int count = 1;
			/*while (reader.Read())
			{
				if (count == Convert.ToInt32(reader.GetValue(1)))
				{
					labels[count - 1].Text += reader.GetString(2) + " " + reader.GetString(0) + " " + reader.GetString(3);
					count++;
				}
			}*/

			while (reader.Read())
			{
				labels[Convert.ToInt32(reader.GetValue(1)) - 1].Text += reader.GetString(2) + " " + reader.GetString(0) + " " + reader.GetString(3);
				//count++;
			}

		}

		public CardDayLessons(string[][][] day, int weekDay)
		{
			InitializeComponent();

			string[] weekDayName = new string[] { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота" };
			nameDayLabel.Text = weekDayName[weekDay];
			string[] links = new string[5];
			System.Windows.Forms.Label[] lessons = new System.Windows.Forms.Label[] { firstLessonLabel, secondLessonLabel, thirdLessonLabel, fourLessonLabel, fiveLessonLabel };
			if (day != null)
			{
				string text = "";
				try
				{
					for (int i = 0; i < lessons.Length; i++)
					{
						if (!(day[i] == null))
						{
							for (int j = 0; j + 1 < day[i].Length; j++)
							{
								if (!(day[i][j] == null))
								{
									if (day[i][j][4].Equals("2")) lessons[i].ForeColor = Color.FromArgb(177, 4, 4);

									if (j == 0)
									{
										text = day[i][j][3] + " " + day[i][j][5] + " " + day[i][j][9];
										links[i] = day[i][j][11];
									}
									else
									{
										text += " " + day[i][j][9];
										break;
									}
								}
							}
							lessons[i].Text = text;
							text = "";
						}
					}
				}
				catch (Exception) { }

				/*//reader.GetString(7).Trim() + " " + reader.GetString(9).Trim()
				System.Windows.Forms.Label[] labels = new System.Windows.Forms.Label[] { firstLessonLabel, secondLessonLabel, thirdLessonLabel, fourLessonLabel, fiveLessonLabel};
				int count = 1;
				while (reader.Read())
				{
					if (count == Convert.ToInt32(reader.GetValue(0)))
					{
						if (1 == Convert.ToInt32(reader.GetValue(3)))
						{
							labels[count-1].ForeColor = Color.FromArgb(177, 4, 4);
						}
						labels[count-1].Text = reader.GetString(2) + " " + reader.GetString(4);
						nameDayLabel.Text = reader.GetString(5);
						count++;
					}
				}*/

				string moodle = "https://do.sibsiu.ru/day/course/";

				this.link1.Click += new EventHandler((e,t ) => {
					System.Diagnostics.Process.Start(moodle + links[0]);
				});
				this.link2.Click += new EventHandler((e, t) => {
					System.Diagnostics.Process.Start(moodle + links[1]);
				});
				this.link3.Click += new EventHandler((e, t) => {
					System.Diagnostics.Process.Start(moodle + links[2]);
				});
				this.link4.Click += new EventHandler((e, t) => {
					System.Diagnostics.Process.Start(moodle + links[3]);
				});
				this.link5.Click += new EventHandler((e, t) => {
					System.Diagnostics.Process.Start(moodle + links[4]);
				});
			}

			/*public CardDayLessons(string nameDay, string firstLessonLabel, string secondLessonLabel, string thirdLessonLabel, string fourLessonLabel, string fiveLessonLabel,
				string link1, string link2, string link3, string link4, string link5)
			{
				InitializeComponent();

				nameDayLabel.Text = nameDay;
				this.firstLessonLabel.Text = firstLessonLabel;
				this.secondLessonLabel.Text = secondLessonLabel;
				this.thirdLessonLabel.Text = thirdLessonLabel;
				this.fourLessonLabel.Text = fourLessonLabel;
				this.fiveLessonLabel.Text = fiveLessonLabel;

			}*/
		}
	}
}
