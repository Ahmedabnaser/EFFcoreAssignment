using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFFcoreAssignment.Entites
{
    public  class Patient
    {
        [Key]public int Id { get; set; }
        [Required]public string Firstname { get; set; }
        public string? Lastname { get; set; }
        public string? disease { get; set; }
        public string? phonenumber { get; set; }

    }
}
