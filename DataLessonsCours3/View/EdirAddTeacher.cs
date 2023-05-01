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
	public partial class EdirAddTeacher : Form
	{

		private string[][] result;
		public EdirAddTeacher()
		{
			InitializeComponent();

		}

		private void EdirAddTeacher_Load(object sender, EventArgs e)
		{
            // TODO: данная строка кода позволяет загрузить данные в таблицу "timeTableDataSet.Teacher". При необходимости она может быть перемещена или удалена.
            this.teacherTableAdapter.Fill(this.timeTableDataSet.Teacher);

        }

		private void save_Click(object sender, EventArgs e)
		{
			List<string[]> rows = new List<string[]>(); //	массив с выбраными преподавателями
			foreach (DataGridViewRow row in dataGridViewTeacher.Rows)
			{
				bool value = Convert.ToBoolean(row.Cells[5].Value);
				if (value)
				{
					string[] cells = new string[dataGridViewTeacher.Columns.Count];
					for (int i = 0; i < dataGridViewTeacher.Columns.Count; i++)
					{
						cells[i] = row.Cells[i].Value.ToString();
					}
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
