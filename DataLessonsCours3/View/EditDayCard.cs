using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataLessonsCours3.View
{
	public partial class EditDayCard : UserControl
	{
		int getWeekDay;
		public EditDayCard(string[][][] day, int weekDay)
		{
			InitializeComponent();
			string[] weekDayName = new string[] { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота" };
			nameDayLabel.Text = weekDayName[weekDay];
			getWeekDay = weekDay;
			string[] links = new string[5];
			Label[] lessons = new Label[] { firstLessonLabel, secondLessonLabel, thirdLessonLabel, fourLessonLabel, fiveLessonLabel };
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

				string moodle = "https://do.sibsiu.ru/day/course/";

				this.link1.Click += new EventHandler((e, t) => {
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
		}

		private void nameDayLabel_DoubleClick(object sender, EventArgs e)
		{
			getForm();
		}

		private void firstLessonLabel_DoubleClick(object sender, EventArgs e)
		{
			getForm();
		}

		private void secondLessonLabel_DoubleClick(object sender, EventArgs e)
		{
			getForm();
		}

		private void thirdLessonLabel_DoubleClick(object sender, EventArgs e)
		{
			getForm();
		}

		private void fourLessonLabel_DoubleClick(object sender, EventArgs e)
		{
			getForm();
		}

		private void fiveLessonLabel_DoubleClick(object sender, EventArgs e)
		{
			getForm();
		}

		private void gunaGradient2Panel5_DoubleClick(object sender, EventArgs e)
		{
			getForm();
		}
		private void getForm()
		{
			Form1 form1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();
			form1.clickViewEditDay(getWeekDay);
			//form1.MethodName(getWeekDay);
		}

	}
}
