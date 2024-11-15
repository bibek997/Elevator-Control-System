using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiftDemo_A
{
	internal class DBContext
	{
        //define connection string
        string connectionString = @"Server = LAPTOP-D5A78GLB\MSSQLSERVER01;Database=LiftDB;Trusted_Connection=True;";

		public void InsertLogsIntoDB(DataTable dt) // methods to insert logs
		{
			try
			{
				using (SqlConnection conn = new SqlConnection(connectionString)) //establish connection using database strategy
                {
					string query = @"Insert into EVENTS (Timestamp, Type) values (@Time, @Log)";

					using (SqlDataAdapter adapter = new SqlDataAdapter()) //handle the database updates
					{
						adapter.InsertCommand = new SqlCommand(query, conn); //sql insert command with parameter for time and log
                        adapter.InsertCommand.Parameters.Add("@Time", SqlDbType.DateTime, 0, "Timestamp");
						adapter.InsertCommand.Parameters.Add("@Log", SqlDbType.NVarChar, 255, "Type");

						conn.Open();

						adapter.Update(dt);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error saving logs to DB: " + ex.Message);
			}
		}

		public void loadLogsFromDB(DataTable dt, DataGridView dataGridViewLogs)
		{
			try
			{
				using (SqlConnection conn = new SqlConnection(connectionString))
				{
					string query = @"Select Timestamp, Type from EVENTS order by Timestamp desc";

					using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
					{
						dt.Rows.Clear();

						adapter.Fill(dt);

						dataGridViewLogs.Rows.Clear();

						foreach (DataRow row in dt.Rows)
						{
							string currentTime = Convert.ToDateTime(row["Timestamp"]).ToString("hh:mm:ss");
							string events = row["Type"].ToString();

							dataGridViewLogs.Rows.Add(currentTime, events);
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading logs from DB: " + ex.Message);
			}

		}

        public void clearLogsFromDB(DataTable dt, DataGridView dataGridViewLogs)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"TRUNCATE TABLE EVENTS";
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.ExecuteNonQuery(); //exxecute the command
                    }

                    dt.Rows.Clear();
                    dataGridViewLogs.Rows.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error clearing logs from DB: " + ex.Message);
            }
        }

    }
}
