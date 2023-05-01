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
	public partial class MessageForm : Form
	{
		public MessageForm(string text, string title)
		{
			InitializeComponent();
			lbText.Text = text;
			lbTitle.Text = title;
		}

		private void exit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void save_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
