using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebProgrammingProject.Models;
using WebProgrammingProject.Models.ViewModels;


namespace WebProgrammingProject.Controllers
{
    public class HomeController : Controller
    {

        public ComputerDbContext context;
        public HomeController(ComputerDbContext c)
        {
            context = c;

        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }
        public IActionResult Deneme()
        {
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Details(int id)
        {

            Computer c1 = context.Computers.FirstOrDefault(i => i.ID == id);
            CPU Cpu1 = context.CPUs.FirstOrDefault(i => i.ID == c1.CPUID);
            GPU Gpu1 = context.GPUs.FirstOrDefault(i => i.ID == c1.GPUID);
            User user = context.Users.FirstOrDefault(i => i.ID == c1.UserID);
            Manufacturer m1 = context.Manufacturers.FirstOrDefault(i => i.ID == c1.ManufacturerID);


            Sell s = new Sell();
            s.computer = c1;
            s.cpu = Cpu1;
            s.gpu = Gpu1;
            s.user = user;
            s.man = m1;

            return View(s);
        }
       public IActionResult Payment(int id)
        {

            Computer c1 = context.Computers.FirstOrDefault(i => i.ID == id);
            CPU Cpu1 = context.CPUs.FirstOrDefault(i => i.ID == c1.CPUID);
            GPU Gpu1 = context.GPUs.FirstOrDefault(i => i.ID == c1.GPUID);
            User user = context.Users.FirstOrDefault(i => i.ID == c1.UserID);
            Manufacturer m1 = context.Manufacturers.FirstOrDefault(i => i.ID == c1.ManufacturerID);


            Sell s = new Sell();
            s.computer = c1;
            s.cpu = Cpu1;
            s.gpu = Gpu1;
            s.user = user;
            s.man = m1;

            return View(s);
        }
        public IActionResult payComplete(int id)
        {
            Computer c1 = context.Computers.FirstOrDefault(i => i.ID == id);
            CPU Cpu1 = context.CPUs.FirstOrDefault(i => i.ID == c1.CPUID);
            GPU Gpu1 = context.GPUs.FirstOrDefault(i => i.ID == c1.GPUID);
            User user = context.Users.FirstOrDefault(i => i.ID == c1.UserID);
            Manufacturer m1 = context.Manufacturers.FirstOrDefault(i => i.ID == c1.ManufacturerID);


            Sell s = new Sell();
            s.computer = c1;
            s.cpu = Cpu1;
            s.gpu = Gpu1;
            s.user = user;
            s.man = m1;
            return View(s);
        }
        List<Sell> sells = null; 

    }
}
