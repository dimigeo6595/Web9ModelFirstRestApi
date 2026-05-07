
using Microsoft.EntityFrameworkCore;

namespace SchoolApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var conString = builder.Configuration.GetConnectionString("DevConnection");

            builder.Services.AddDbContext<Data.SchoolMvc9Context>(options =>
                options.UseSqlServer(conString));

            // Add services to the container.

            builder.Services.AddControllers();
            

            var app = builder.Build();

            

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
