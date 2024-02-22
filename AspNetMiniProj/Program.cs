using AspNetMiniProj.Models;
using Microsoft.EntityFrameworkCore;

namespace AspNetMiniProj
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Stöd för controllers och views
            builder.Services.AddControllersWithViews();
            builder.Services.AddTransient<DataService>();


            var connString = builder.Configuration.GetConnectionString("DefaultConnection");
            builder.Services.AddDbContext<ApplicationContext>(o => o.UseSqlServer(connString));

            var app = builder.Build();

            // Stöd för att mappa HTTP-anrop till våra controllers
            app.UseRouting();

            // Stöd för Route-attribut på våra Action-metoder
            app.UseEndpoints(c => c.MapControllers());

            //
            app.UseStaticFiles();
            app.UseEndpoints(endpoints => endpoints.MapControllers());
            app.Run();

        }
    }
}