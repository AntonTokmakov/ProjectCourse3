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
		SqlConnection connection = new SqlConnection("Server=localhost;Database=timeTable;Trusted_Connection=True");

		public void openConnection()
		{
			if (connection.State == System.Data.ConnectionState.Closed)
				connection.Open();
		}

		public void closeConnection()
		{
			if (connection.State == System.Data.ConnectionState.Open)
				connection.Close();
		}

		public SqlConnection getConnection()
		{
			return connection;
		}
				/*if (connection.State == System.Data.ConnectionState.Closed)
					connection.Open();


				connection.Open();
				SqlCommand command = new SqlCommand("SELECT * FROM Cathedra", connection);
				SqlDataReader reader = command.ExecuteReader();
				while (reader.Read())
				{

				}
				reader.Close();*/

	}
}
