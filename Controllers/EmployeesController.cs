using ASPT2.DTO;
using Microsoft.AspNetCore.Mvc;
using ASPT2.Models;
namespace ASPT2.Controllers
{
    [ApiController]
    [Route("Employees")]
    public class EmployeesControllers : ControllerBase
    {
        [HttpGet()]
        public List<Employee> EmpSelectAll()
        {
            return (from Employee in new EmployeesDBContext().Employees
                    select Employee).ToList();
        }
        [HttpGet("{id}")]
        public List<Employee> EmpSelectId(int id)
        {
            return (from Employee in new EmployeesDBContext().Employees
                    where Employee.Id == id
                    select Employee).ToList();
        }
        [HttpPost()]
        public int EmpInsert(Employee emp)
        {
            var context = new EmployeesDBContext();
            context.Employees.Add(emp);
            return context.SaveChanges();
        }
        [HttpPut("{id}")]
        public int EmpUpdate(int id, Employee emp)
        {
            var context = new EmployeesDBContext();
            var item = (from Employee in context.Employees
                                      where Employee.Id == id
                                      select Employee).FirstOrDefault();
            if (item != null) 
            { 
                item.Fullname = emp.Fullname;
                item.Name = emp.Name;
                item.Role = emp.Role;
                item.Password = emp.Password;
            }
            else { return 0; }
            return context.SaveChanges();
        }
        [HttpDelete("{id}")]
        public int EmpDelete(int id)
        {
            var context = new EmployeesDBContext();
            var item = (from Employee in context.Employees
                        where Employee.Id == id
                        select Employee).FirstOrDefault();
            if (item != null)
            {
                context.Employees.Remove((from Employee in context.Employees
                                          where Employee.Id == id
                                          select Employee).FirstOrDefault());
            }
            else { return 0; }
            return context.SaveChanges();
        }
    }
}