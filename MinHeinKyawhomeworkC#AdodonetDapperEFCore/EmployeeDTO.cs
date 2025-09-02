using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinHeinKyawhomeworkC_AdodonetDapperEFCore
{
    [Table("Employees")]
    public class EmployeeDTO
    {
        [Key]
        public int Id { get; set; }

        [Column("first_name")]
        public string FirstName { get; set; }

        [Column("last_name")]
        public string LastName { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("department")]
        public string Department { get; set; }

        [Column("salary")]
        public decimal Salary { get; set; }

        [Column("hire_date")]
        public DateTime HireDate { get; set; }

        [Column("delete_flag")]
        public bool DeleteFlag { get; set; }
    }
}
