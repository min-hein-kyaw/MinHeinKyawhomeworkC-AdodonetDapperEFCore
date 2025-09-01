using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinHeinKyawhomeworkC_AdodonetDapperEFCore
{
    public class AdoDotNetService
    {
        SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder()
        {
            DataSource = ".",
            InitialCatalog = "MHKDotNetTrainingInPersonBatch1",
            UserID = "sa",
            Password = "sasa@123",
            TrustServerCertificate = true
        };
        public void Read()
        {


            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStringBuilder.ConnectionString);
            sqlConnection.Open();
            string query = @"SELECT [id]
      ,[first_name]
      ,[last_name]
      ,[email]
      ,[department]
      ,[salary]
      ,[hire_date]
  FROM [dbo].[employees]";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            Console.WriteLine("Complete");
            sqlConnection.Close();
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                DataRow data = dataTable.Rows[i];
                Console.WriteLine($"{data["first_name"]}");
            }
            Console.ReadLine();
        }
        public void Create()
        {
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStringBuilder.ConnectionString);
            sqlConnection.Open();
            string query = @"INSERT INTO employees (id, first_name, last_name, email, department, salary, hire_date) VALUES
(9, 'Ian', 'Clark', 'ian.clark@example.com', 'Marketing', 59000.00, '2021-06-18'),
(10, 'Jill', 'Wright', 'jill.wright@example.com', 'Sales', 63000.00, '2019-08-23');
";
            SqlCommand sqlCommand = new SqlCommand( query, sqlConnection);
            int rows = sqlCommand.ExecuteNonQuery();
            Console.WriteLine($"{rows} affected");
        }
        public void Update()
        {
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStringBuilder.ConnectionString);
            sqlConnection.Open();
            string query = @"UPDATE employees
SET department = 'Product', salary = 97000.00
WHERE id = 3;";
            SqlCommand sqlCommand = new SqlCommand(query,sqlConnection);
            int rows = sqlCommand.ExecuteNonQuery();
            Console.WriteLine($"{rows} affected");
        }
        public void Delete()
        {
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStringBuilder.ConnectionString);
            sqlConnection.Open();
            string query = @"UPDATE employees
SET delete_flag = 1
WHERE id = 3;";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            int rows = sqlCommand.ExecuteNonQuery();
            Console.WriteLine($"{rows} affected");
        }
    }
}
