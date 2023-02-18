using Microsoft.EntityFrameworkCore;
using WebApp.Data;
using WebApp.Resources;
using MySql.EntityFrameworkCore;
using System.Diagnostics;
using WebApp.Models;

namespace WebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Debug.WriteLine("********* MAIN FUNCTION**********************************");
            TestDatabase();

            var builder = WebApplication.CreateBuilder(args);

            St.InitializeLocalization("en-US");
            // Add services to the container.
            builder.Services.AddControllersWithViews();
           // builder.Services.AddDbContext<ApplicationDBContext>(options => options.UseSqlServer(
                //builder.Configuration.GetConnectionString("DefaultConnection")));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();

        }

        private static void TestDatabase()
        {
            try
            {
                using (var context = new ApplicationDBContext())
                {
                    context.Database.EnsureCreated();

                    //Add sighting report

                    var sighting = new Sighting()
                    {
                        ObserverName = "Benedikt Örn Hjaltason",
                        AllowPublicDisplay = true,
                        ObserverLocation = "Hessdalen",
                        PhenomenonLocationName = "Hessdalen",
                        PhenomenonLocationCoordinates = "32498432980432,9084329432098",
                        DateAndTime = DateTime.Now,
                        Description = "Så lys på himmelen."
                    };

                    context.Sightings.Add(sighting);

                    context.SaveChanges();
                }

                //Add sighting report
                using (var context = new ApplicationDBContext())
                {
                    context.Database.EnsureCreated();

                    foreach (var sighting in context.Sightings)
                    {
                        Debug.WriteLine(sighting);
                    }
                }
            }

            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }
    }
}