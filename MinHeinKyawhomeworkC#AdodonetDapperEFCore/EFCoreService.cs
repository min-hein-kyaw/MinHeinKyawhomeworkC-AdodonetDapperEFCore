using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinHeinKyawhomeworkC_AdodonetDapperEFCore
{
    public class EFCoreService
    {
        AppDbContext db = new AppDbContext();
        public void Read()
        {
            List<EmployeeDTO> employees = db.Employees.ToList();
            foreach (EmployeeDTO item in employees)
            {
                Console.WriteLine($"{item.Id} {item.FirstName}");
            }

        }
        public void Create()
        {
            EmployeeDTO employee = new EmployeeDTO()
            {
                Id = 31,
                FirstName = "David",
                LastName = "Beckham",
                Email = "db@gmail.com",
                Department = "Finance",
                Salary = 70000,
                HireDate = DateTime.Now,
                DeleteFlag = false
            };
            db.Employees.Add(employee);
            int results = db.SaveChanges();
        }
        public void Update()
        {
            EmployeeDTO? editEmployee = db.Employees.Where(item => item.Id == 10).FirstOrDefault();
            if (editEmployee != null)
            {
                editEmployee.Salary = 1000000;
                int results = db.SaveChanges();
                Console.WriteLine($"{results} rows affected");
            }
        }
        public void Delete()
        {
            EmployeeDTO? deleEmployee = db.Employees.Where(item => item.Id == 10).FirstOrDefault();
            if (deleEmployee != null)
            {
                deleEmployee.DeleteFlag = true;
                int results = db.SaveChanges();
                Console.WriteLine($"{results} rows affected");
            }
        }
    }
}

