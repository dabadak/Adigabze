using Adigabze.Data.Abstract;
using Adigabze.Data.Concrete.EFCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Adigabze.WebUI
{
    public class Program
    {
        public static void Main(string[] args)
        {


            var builder = WebApplication.CreateBuilder(args);

            // ==========================
            // SERVICES (DI)
            // ==========================

            // Repository registrations
            builder.Services.AddScoped<IYetkinlikRepository, EFYetkinlikRepository>();
            builder.Services.AddScoped<IUniteRepository, EFUniteRepository>();
            builder.Services.AddScoped<IKonuRepository, EFKonuRepository>();
            builder.Services.AddScoped<IKazanimRepository, EFKazanimRepository>();

            builder.Services.AddScoped<IHarfRepository, EFHarfRepository>();
            builder.Services.AddScoped<IAnahtarRepository, EFAnahtarRepository>();
            builder.Services.AddScoped<ISozcukRepository, EFSozcukRepository>();

            builder.Services.AddScoped<ISozcukEkRepository, EFSozcukEkRepository>();
            builder.Services.AddScoped<IParentRepository, EFParentRepository>();

            // DbContext
            builder.Services.AddDbContext<AdigabzeContext>(options =>
                options.UseSqlServer(
                    builder.Configuration.GetConnectionString("DefaultConnection")));

            // MVC
            builder.Services.AddControllersWithViews();

            var app = builder.Build();


            // ==========================
            // MIDDLEWARE PIPELINE
            // ==========================

            if (app.Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Sozluk}/{action=List}/{id?}");


            // ==========================
            // SEED DATA
            // ==========================
            using (var scope = app.Services.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<AdigabzeContext>();

                context.Database.Migrate();

                SeedData.Seed(context);
            }

            app.Run();
        }
    }
}
