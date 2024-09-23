using EFFcoreAssignment.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFFcoreAssignment
{
    public  class ApplicationDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\ProjectModels;Initial Catalog=ItcAhmed;Integrated Security=True");
        }
        public DbSet<Employee> employees { get; set; }
        public DbSet<Patient> Patients { get; set; }



    }
}
