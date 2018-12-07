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
            context.SaveChanges();
        }

    }
}
