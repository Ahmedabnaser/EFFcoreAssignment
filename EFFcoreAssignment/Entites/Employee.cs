using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFFcoreAssignment.Entites
{
    public  class Employee
    {
       [Key]public int Id { get; set; }
       [Required]public string Firstname { get; set; }
        public string  Lastname{ get; set; }
        public string Speciality { get; set; }
        public string? phone { get; set; }

    }
}
