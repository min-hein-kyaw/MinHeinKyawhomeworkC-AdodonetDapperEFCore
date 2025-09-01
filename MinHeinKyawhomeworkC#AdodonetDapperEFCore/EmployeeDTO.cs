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

        public string first_name { get; set; }

        public string last_name { get; set; }

        public string email { get; set; }

        public string department { get; set; }

        public decimal salary { get; set; }

        public DateTime hire_date { get; set; }

        public bool delete_flag { get; set; }
    }
}
