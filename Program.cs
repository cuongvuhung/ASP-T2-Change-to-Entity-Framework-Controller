
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
            app.MapGet("/{tblname}", (string tblname) => 
            {
                DAL dal = new DAL();
                string str = $"Select,{tblname}";
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
            app.MapGet("/{tblname}/{id}", (string tblname, string id) => 
            {
                DAL dal = new DAL();
                string str = $"Select,{tblname},id,{id}";
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
                string str = $"Insert,Employees,{emp.Name},{emp.Fullname},{emp.Password},{emp.Role}";
                DAL dal = new DAL();
                int result = dal.SQLExecute(str);
                return $"{result} rows effected";
            });

            //////////////////////////////////////////////////////////////////
            // PUT /employee/{id}/{name}/{fullname}/{password}/{role}
            app.MapPut("/employees", (Employee emp) =>
            {
                string str = $"Update,Employees,{emp.Id},{emp.Name},{emp.Fullname},{emp.Password},{emp.Role}";
                DAL dal = new DAL();
                int result = dal.SQLExecute(str);
                return $"{result} rows effected";                
            });
            app.Run();
        }
    }
}