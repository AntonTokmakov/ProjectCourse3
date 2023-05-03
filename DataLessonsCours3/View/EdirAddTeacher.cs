using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataLessonsCours3.View
{
	public partial class EdirAddTeacher : Form
	{

		private string[][] result;
		bool check = false;
		public EdirAddTeacher()
		{
			InitializeComponent();

		}
		public EdirAddTeacher(bool check)
		{
			InitializeComponent();
			this.check = check;

		}

		private void EdirAddTeacher_Load(object sender, EventArgs e)
		{
            // TODO: данная строка кода позволяет загрузить данные в таблицу "timeTableDataSet.Teacher". При необходимости она может быть перемещена или удалена.
            this.teacherTableAdapter.Fill(this.timeTableDataSet.Teacher);

        }

		private void save_Click(object sender, EventArgs e)
		{
			List<string[]> rows = new List<string[]>(); //	массив с выбраными преподавателями
			int count = 0;
			foreach (DataGridViewRow row in dataGridViewTeacher.Rows)
			{
				bool value = Convert.ToBoolean(row.Cells[5].Value);
				if (value)
				{
					count++;
					if (count > 4)
					{
						new MessageForm("Выберите не больше 4 преподавателей на пару", "Система").ShowDialog();
						return;
					}
					if (count > 1 && check)
					{
						new MessageForm("Выберите одного преподавателя", "Система").ShowDialog();
						return;
					}
					string[] cells = new string[3];
					cells[0] = row.Cells[0].Value.ToString().Trim();
					cells[1] = row.Cells[3].Value.ToString().Trim();
					cells[2] = row.Cells[2].Value.ToString().Trim();
					rows.Add(cells);
				}
			}
			result = rows.ToArray();
			this.Close();
		}

		public string[][] checkTeacher
		{
			get { return result; }
			set { result = value; }
		}

		private void exit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
