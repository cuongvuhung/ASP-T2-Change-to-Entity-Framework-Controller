namespace ASPT1.DTO
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Fullname { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }    

        public Employee(int iD, string name, string fullname, string password, string role)
        {
            Id = iD;
            Name = name;
            Fullname = fullname;
            Password = password;
            Role = role;
        }

    }
}
