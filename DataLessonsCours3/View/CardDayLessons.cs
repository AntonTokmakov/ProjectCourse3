using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace DataLessonsCours3.View
{
	public partial class CardDayLessons : UserControl
	{
		public CardDayLessons(SqlDataReader reader)
		{
			InitializeComponent();
            //reader.GetString(7).Trim() + " " + reader.GetString(9).Trim()
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
			}

			/*nameDayLabel.Text = nameDay;
			this.firstLessonLabel.Text = firstLessonLabel;
			this.secondLessonLabel.Text = secondLessonLabel;
			this.thirdLessonLabel.Text = thirdLessonLabel;
			this.fourLessonLabel.Text = fourLessonLabel;
			this.fiveLessonLabel.Text = fiveLessonLabel;

			this.link1.Click += new EventHandler((e, t) => {
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
			});*/
		}

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
