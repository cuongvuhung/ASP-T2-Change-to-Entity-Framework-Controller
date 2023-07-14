
using ASPT1.Views;
using ASPT1.Models;
using ASPT1.DTO;

namespace ASPT1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();
            Pages page = new Pages();
            app.MapGet("/", () => page.Content);
            //////////////////////////////////////////////////////////////////
            // GET /employee
            app.MapGet("/Employees", () => 
            {
                DAL dal = new DAL();
                string str = $"Select,Employees";
                List<string> list = dal.SQLQuery(str);
                str = "";
                foreach (string line in list) 
                {
                    str += line + "\n";
                }
                return str;
            });

            //////////////////////////////////////////////////////////////////
            // Get /{tblname}/{id}
            app.MapGet("/Employees/{id}", (string id) => 
            {
                DAL dal = new DAL();
                string str = $"Select,Employees,id,{id}";
                List<string> list = dal.SQLQuery(str);
                str = "";
                foreach (string line in list)
                {
                    str += line + "\n";
                }
                return str;
                
            });

            //////////////////////////////////////////////////////////////////
            // POST /employee/{name}/{fullname}/{password}/{role}
            app.MapPost("/employees", (Employee emp) =>
            {
                emp.Password = Utils.Hash(emp.Password);
                string str = $"Insert,Employees,{emp.Name},{emp.Fullname},{emp.Password},{emp.Role}";
                DAL dal = new DAL();
                int result = dal.SQLExecute(str);
                return $"{result} rows effected";
            });

            //////////////////////////////////////////////////////////////////
            // PUT /employee/{id}/{name}/{fullname}/{password}/{role}
            app.MapPut("/employees", (Employee emp) =>
            {
                emp.Password = Utils.Hash(emp.Password);
                string str = $"Update,Employees,{emp.Id},name,{emp.Name},fullname,{emp.Fullname},password,{emp.Password},role,{emp.Role}";
                DAL dal = new DAL();
                int result = dal.SQLExecute(str);
                return $"{result} rows effected";                
            });
            app.Run();
        }
    }
}