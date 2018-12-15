using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebProgrammingProject.Models
{
    public static class DbInitializer
    {
        public static void InitializeDb(IApplicationBuilder app) {
        ComputerDbContext context = app.ApplicationServices.GetRequiredService<ComputerDbContext>();
            
            context.Database.Migrate();

            if (!(context.Computers.Any()))
            {
                context.Computers.Add(new Computer() { ModelName = "U310", Year = 2010, ScreenSize = 13.3, HDDSize = 0, SSDSize = 240, RAMSize = 8, CPUID = 1, GPUID = 1, ManufacturerID = 1, UserID = 1, Price = 2500.0 });
                context.CPUs.Add(new CPU() { Name = "Intel Core i5-3317U", Architecture = 28, Power = 75, Frequency = 1.70 });
                context.GPUs.Add(new GPU() { Name = "Paylaşımlı", Power = 0, Bit = 64 });
                context.Manufacturers.Add(new Manufacturer() { Name = "Lenovo" });
                context.Users.Add(new User() { Name = "Antiochus", Password = "123456", Email = "antiochus.official@gmail.com", Phone = "0555 555 55 55" });
            }
            context.SaveChanges();
        }

    }
}
