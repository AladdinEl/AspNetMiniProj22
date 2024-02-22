using AspNetMiniProj.Models;
using Microsoft.EntityFrameworkCore;

namespace AspNetMiniProj
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // St�d f�r controllers och views
            builder.Services.AddControllersWithViews();
            builder.Services.AddTransient<DataService>();


            var connString = builder.Configuration.GetConnectionString("DefaultConnection");
            builder.Services.AddDbContext<ApplicationContext>(o => o.UseSqlServer(connString));

            var app = builder.Build();

            // St�d f�r att mappa HTTP-anrop till v�ra controllers
            app.UseRouting();

            // St�d f�r Route-attribut p� v�ra Action-metoder
            app.UseEndpoints(c => c.MapControllers());

            //
            app.UseStaticFiles();
            app.UseEndpoints(endpoints => endpoints.MapControllers());
            app.Run();

        }
    }
}