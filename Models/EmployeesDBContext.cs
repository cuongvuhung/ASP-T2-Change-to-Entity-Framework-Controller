using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using ASPT2.DTO;

namespace ASPT2.Models
{
    public class EmployeesDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(Config.conStr);
        }
        public virtual DbSet<Employee> Employees { get; set; }
    }
}
