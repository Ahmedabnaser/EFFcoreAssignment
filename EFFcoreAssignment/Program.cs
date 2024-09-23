using EFFcoreAssignment.Entites;

namespace EFFcoreAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Context=new ApplicationDbContext();
            var e1 = new Employee
            {
                Firstname = "ahmed",
                Lastname = "hamed",
                Speciality = "tawleed",
                phone = "012345671555"
            };
            var p = new Patient
            {
                Firstname = "ibrahim",
                Lastname = "elsayed",
                disease = null,
                phonenumber = null,
            };
            Context.Add(p);
            Context.Add(e1);
            Context.SaveChanges();

            var res = Context.employees.Where(e => e.Id == 2).FirstOrDefault();

            // Handling the result output
            if (res != null)
            {
                Console.WriteLine($"Employee found: {res.Firstname} {res.Lastname}, Speciality: {res.Speciality}, Phone: {res.phone}");
            }
            else
            {
                Console.WriteLine("No employee found with Id = 2");
            }


        }
    }
}
