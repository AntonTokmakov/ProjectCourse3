using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DataLessonsCours3.Class
{
	public class DB
	{
		public void dfg()
		{
			string a, c;
			int b;
			string connectionString = "Server=localhost;Database=timeTable;Trusted_Connection=True";
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();
				SqlCommand command = new SqlCommand("SELECT * FROM Cathedra", connection);
				SqlDataReader reader = command.ExecuteReader();
				while (reader.Read())
				{
					a = "{0}\t{1}";
					b = reader.GetInt32(0);
					c = reader.GetString(1);
				}
				reader.Close();
			}
		}

	}
}
