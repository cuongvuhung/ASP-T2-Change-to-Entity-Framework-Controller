
using ASPT2.Views;
using ASPT2.Models;
using ASPT2.DTO;

namespace ASPT2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllers();
            var app = builder.Build();
            Pages page = new Pages();
            app.MapGet("/", () => page.Content);
            app.MapControllers();
            app.Run();
        }
    }
}