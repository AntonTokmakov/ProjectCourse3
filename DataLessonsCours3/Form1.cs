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
			DB db = new DB();
			db.dfg();
		}

		private void viewDaysTabPanel_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch (viewDaysTabPanel.SelectedIndex)
			{
				case 0:
					mainLayout.Controls.Clear();
					for (int i = 0; i < 6; i++)			//Подключить БД и поставить свои значения
					{
						CardDayLessons cardDay = new CardDayLessons("Понедельник", "УиАБД", "ТРПО", "ИСРПО", "ПД", "Мат мод",		//добавлять данные из БД
						"https://do.sibsiu.ru/day/course/view.php?id=19370", "", "","","");
						mainLayout.Controls.Add(cardDay);
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
	}
}
