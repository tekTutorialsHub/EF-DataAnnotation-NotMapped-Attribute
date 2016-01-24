using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_NotMapped_Attribute
{

    public class Employee
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }

        public DateTime DOB { get; set;}
        [NotMapped]
        public int Age { get; set; }
      
    }

}
