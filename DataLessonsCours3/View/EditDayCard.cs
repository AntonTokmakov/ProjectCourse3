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
		public EditDayCard(string[][] day)
		{
			InitializeComponent();

			Label[] lessons = new Label[] { firstLessonLabel , secondLessonLabel, thirdLessonLabel , fourLessonLabel , firstLessonLabel };

			try
			{
				/*for (int i = 0; i < lessons.Length; i++) 
				{
					for (int j = 0; j < day.Length; i++)
					{
						lessons[i].Text = day[j][3] + " " + day[j][5] + " " + day[j][9] + " " + day[j][8];

					}


				}	*/

				firstLessonLabel.Text = day[0][3] + " " + day[0][5] + " " + day[0][9] + " " + day[0][8];
				secondLessonLabel.Text = day[1][3] + " " + day[1][5] + " " + day[1][9] + " " + day[1][8];
				thirdLessonLabel.Text = day[2][3] + " " + day[2][5] + " " + day[2][9] + " " + day[2][8];
				fourLessonLabel.Text= day[3][3] + " " + day[3][5] + " " + day[3][9] + " " + day[3][8];
				firstLessonLabel.Text = day[4][3] + " " + day[4][5] + " " + day[4][9] + " " + day[4][8];
				nameDayLabel.Text = day[1][6];
			}
			catch (Exception)
			{
								
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
