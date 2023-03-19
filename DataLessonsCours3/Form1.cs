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
			int pointX = mainPage.Location.X;
			int pointY = mainPage.Location.Y;
			navSeparator.Location = new Point(pointX, pointY);
		}


		private void addExam_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < 5; i++)
			{
				CardExam card = new CardExam();
			
				examLayoutPanel.Controls.Add(card);
			}
		}

		private void viewDaysTabPanel_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch (viewDaysTabPanel.SelectedIndex)
			{
				case 0:
					for (int i = 0; i < 5; i++)			//Подключить БД и поставить свои значения
					{
						CardDayLessons cardDay = new CardDayLessons("Понедельник", "УиАБД", "ТРПО", "ИСРПО", "ПД", "Мат мод",
						"https://do.sibsiu.ru/day/course/view.php?id=19370", "", "","","");
						mainLayout.Controls.Add(cardDay);
					}
					
					break;

				case 1:
					break;

				case 2:
					break; 

				case 3:
					break;

				default:
					viewDaysTabPanel.SelectedIndex = 0;
					break;
			}
		}
	}
}
