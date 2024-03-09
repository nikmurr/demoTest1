using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace TestDemoApp1
{
    public class PostgreSQLHandler
    {
        private readonly string connectionString;
        private NpgsqlConnection connection;

        public PostgreSQLHandler(string host, string database, string username, string password)
        {
            try
            {
                connectionString = $"Host={host};Database={database};Username={username};Password={password};";
                connection = new NpgsqlConnection(connectionString);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error connecting: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public DataTable ExecuteQuery(string query) 
        {
            try
            {
                connection.Open();
                using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error executing query: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        public void ExecuteNonQuery(string query)
        {
            try
            {
                connection.Open();
                {
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error executing non-query: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            { 
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }
    }

}
