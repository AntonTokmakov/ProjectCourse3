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
		public EditDayCard(string[][][] day, int weekDay)
		{
			InitializeComponent();
			string[] weekDayName = new string[] { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота" };
			nameDayLabel.Text = weekDayName[weekDay];
			Label[] lessons = new Label[] { firstLessonLabel , secondLessonLabel, thirdLessonLabel , fourLessonLabel , firstLessonLabel };
			if (day != null)
			{
				int numberLesson = 1;
				int teacher = 0;
				string text = "";
				try
				{
					for (int i = 0; i < lessons.Length; i++)
					{
						if (!(day[i] == null))
						{
							for (int j = 0; j + 1 < day[i].Length; j++)
							{
								//for (int k = 0; k < day[i][j].Length; k++)			//вот эта штука скорей всего и не нужна, так как day[][][] это уже элементы массива
								//{
								if (!(day[i][j] == null)) 
								{
									if (j == 0)
										text = day[i][j][3] + " " + day[i][j][5] + " " + day[i][j][9] + " " + day[i][j][8];
									else text += " " + day[i][j][9] + " " + day[i][j][8];
								}
								//}
								
							}
							lessons[i].Text = text;
							text = "";
							/*if (day[i][teacher][4].Equals(numberLesson.ToString()))
							{
								lessons[numberLesson-1].Text = day[i][0][3] + " " + day[i][0][5] + " " + day[i][0][9] + " " + day[i][0][8];
								numberLesson++;
							} else 
							{
								lessons[numberLesson-2].Text += " " + day[i][9] + " " + day[i][8];
							}*/
						}
					}

					/*firstLessonLabel.Text = day[0][3] + " " + day[0][5] + " " + day[0][9] + " " + day[0][8];
					secondLessonLabel.Text = day[1][3] + " " + day[1][5] + " " + day[1][9] + " " + day[1][8];
					thirdLessonLabel.Text = day[2][3] + " " + day[2][5] + " " + day[2][9] + " " + day[2][8];
					fourLessonLabel.Text= day[3][3] + " " + day[3][5] + " " + day[3][9] + " " + day[3][8];
					firstLessonLabel.Text = day[4][3] + " " + day[4][5] + " " + day[4][9] + " " + day[4][8];
					nameDayLabel.Text = day[1][6];*/
				}
				catch (Exception)
				{

				}
			}
		}

		private void nameDayLabel_DoubleClick(object sender, EventArgs e)
		{

		}

		private void firstLessonLabel_DoubleClick(object sender, EventArgs e)
		{

		}

		private void secondLessonLabel_DoubleClick(object sender, EventArgs e)
		{

		}

		private void thirdLessonLabel_DoubleClick(object sender, EventArgs e)
		{

		}

		private void fourLessonLabel_DoubleClick(object sender, EventArgs e)
		{

		}

		private void fiveLessonLabel_DoubleClick(object sender, EventArgs e)
		{

		}

		private void gunaGradient2Panel5_DoubleClick(object sender, EventArgs e)
		{

		}
	}
}
