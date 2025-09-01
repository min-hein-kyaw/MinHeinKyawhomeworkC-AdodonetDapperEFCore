using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinHeinKyawhomeworkC_AdodonetDapperEFCore
{
    public class DapperService
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
            IDbConnection db = new SqlConnection(sqlConnectionStringBuilder.ConnectionString);
            db.Open();
            List<Employees> employees = db.Query<Employees>(@"
SELECT [id]
      ,[first_name]
      ,[last_name]
      ,[email]
      ,[department]
      ,[salary]
      ,[hire_date]
      ,[delete_flag]
  FROM [dbo].[Employees]").ToList();
            foreach (Employees item in employees)
            {
                Console.WriteLine($"{item.first_name}");
            }
            db.Close();
        }
        public void Create()
        {
            IDbConnection db = new SqlConnection(sqlConnectionStringBuilder.ConnectionString);
            db.Open();
            int results = db.Execute(@"INSERT INTO [dbo].[employees] (
    [id],
    [first_name],
    [last_name],
    [email],
    [department],
    [salary],
    [hire_date],
    [delete_flag]
)
VALUES
(13, 'First13', 'Last13', 'user13@example.com', 'Engineering', 60000.00, '2021-01-01', 0),
(14, 'First14', 'Last14', 'user14@example.com', 'HR',          61000.00, '2021-02-01', 0),
(15, 'First15', 'Last15', 'user15@example.com', 'Sales',       62000.00, '2021-03-01', 0),
(16, 'First16', 'Last16', 'user16@example.com', 'Marketing',   63000.00, '2021-04-01', 0),
(17, 'First17', 'Last17', 'user17@example.com', 'Finance',     64000.00, '2021-05-01', 0),
(18, 'First18', 'Last18', 'user18@example.com', 'Engineering', 65000.00, '2021-06-01', 0),
(19, 'First19', 'Last19', 'user19@example.com', 'HR',          66000.00, '2021-07-01', 0),
(20, 'First20', 'Last20', 'user20@example.com', 'Sales',       67000.00, '2021-08-01', 0),
(21, 'First21', 'Last21', 'user21@example.com', 'Marketing',   68000.00, '2021-09-01', 0),
(22, 'First22', 'Last22', 'user22@example.com', 'Finance',     69000.00, '2021-10-01', 0);
");

            Console.WriteLine($"{results} rows affected");
            db.Close();
        }

        public void Update() { 

            IDbConnection db = new SqlConnection( sqlConnectionStringBuilder.ConnectionString);
            db.Open();
            int results = db.Execute(@"UPDATE [dbo].[employees]
SET
    first_name = CASE id
        WHEN 13 THEN 'John'
        WHEN 14 THEN 'Emma'
        WHEN 15 THEN 'Michael'
        WHEN 16 THEN 'Sophia'
        WHEN 17 THEN 'Daniel'
        WHEN 18 THEN 'Olivia'
        WHEN 19 THEN 'James'
        WHEN 20 THEN 'Isabella'
        WHEN 21 THEN 'William'
        WHEN 22 THEN 'Ava'
    END,
    last_name = CASE id
        WHEN 13 THEN 'Walker'
        WHEN 14 THEN 'Watson'
        WHEN 15 THEN 'Smith'
        WHEN 16 THEN 'Johnson'
        WHEN 17 THEN 'Brown'
        WHEN 18 THEN 'Davis'
        WHEN 19 THEN 'Wilson'
        WHEN 20 THEN 'Moore'
        WHEN 21 THEN 'Taylor'
        WHEN 22 THEN 'Anderson'
    END
WHERE id BETWEEN 13 AND 22;");

            Console.WriteLine($"{results} rows affected");
            db.Close();
        }
        public void Delete() { 
        
        
            IDbConnection db = new SqlConnection(sqlConnectionStringBuilder.ConnectionString);
            db.Open();
            int results = db.Execute(@"UPDATE [dbo].[employees] SET delete_flag = 1 WHERE id IN (14, 17, 19, 22);");
            Console.WriteLine($"{results} rows affected");
        
        }





    }
}
