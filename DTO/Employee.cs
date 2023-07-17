using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASPT2.DTO
{
    [Table("Employees")]
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Fullname { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        public Employee()
        {
        }

        public Employee(int id, string name, string fullname, string password, string role)
        {
            Id = id;
            Name = name;
            Fullname = fullname;
            Password = password;
            Role = role;
        }

    }
}
