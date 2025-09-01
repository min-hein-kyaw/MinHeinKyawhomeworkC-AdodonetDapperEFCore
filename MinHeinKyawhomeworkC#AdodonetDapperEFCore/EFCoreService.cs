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
                Console.WriteLine($"{item.Id} {item.first_name}");
            }

        }
        public void Create()
        {
            EmployeeDTO employee = new EmployeeDTO()
            {
                Id = 31,
                first_name = "David",
                last_name = "Beckham",
                email = "db@gmail.com",
                department = "Finance",
                salary = 70000,
                hire_date = DateTime.Now,
                delete_flag = false
            };
            db.Employees.Add(employee);
            int results = db.SaveChanges();
        }
        public void Update()
        {
            EmployeeDTO? editEmployee = db.Employees.Where(item => item.Id == 10).FirstOrDefault();
            if (editEmployee != null)
            {
                editEmployee.salary = 1000000;
                int results = db.SaveChanges();
                Console.WriteLine($"{results} rows affected");
            }
        }
        public void Delete()
        {
            EmployeeDTO? deleEmployee = db.Employees.Where(item => item.Id == 10).FirstOrDefault();
            if (deleEmployee != null)
            {
                deleEmployee.delete_flag = true;
                int results = db.SaveChanges();
                Console.WriteLine($"{results} rows affected");
            }
        }
    }
}

