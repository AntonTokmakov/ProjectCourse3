using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataLessonsCours3.View
{
	public partial class CardDayLessons : UserControl
	{

		public CardDayLessons(string nameDay, string firstLessonLabel, string secondLessonLabel, string thirdLessonLabel, string fourLessonLabel, string fiveLessonLabel,
			string link1, string link2, string link3, string link4, string link5)
		{
			InitializeComponent();

			nameDayLabel.Text = nameDay;
			this.firstLessonLabel.Text = firstLessonLabel;
			this.secondLessonLabel.Text = secondLessonLabel;
			this.thirdLessonLabel.Text = thirdLessonLabel;
			this.fourLessonLabel.Text = fourLessonLabel;
			this.fiveLessonLabel.Text = fiveLessonLabel;

			this.link1.Click += new EventHandler((e,t ) => {
				System.Diagnostics.Process.Start(link1);
			});
			this.link2.Click += new EventHandler((e, t) => {
				System.Diagnostics.Process.Start(link2);
			});
			this.link3.Click += new EventHandler((e, t) => {
				System.Diagnostics.Process.Start(link3);
			});
			this.link4.Click += new EventHandler((e, t) => {
				System.Diagnostics.Process.Start(link4);
			});
			this.link5.Click += new EventHandler((e, t) => {
				System.Diagnostics.Process.Start(link5);
			});
		}
	}
}
