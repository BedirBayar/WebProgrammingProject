using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebProgrammingProject.Models;
using WebProgrammingProject.Models.ViewModels;


namespace WebProgrammingProject.Controllers
{
    public class HomeController : Controller
    {

        

        public ComputerDbContext context;
        public static List<Sell> listCart = new List<Sell>();
        public static List<Sell> listCompare = new List<Sell>();
        public HomeController(ComputerDbContext c)
        {
            context = c;

        }
        public IActionResult Index()
        {
          
            return View(context.Computers.Where(i =>i.ID>=1));
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

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
        public Sell sellByID(int id)
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
            return s;
        }
        public IActionResult Details(int id)
        {
            Sell s = sellByID(id);
            return View(s);
        }
       public IActionResult Payment(int id)
        {

            Sell s = sellByID(id);

            return View(s);
        }
        public IActionResult payComplete(int id)
        {
            Sell s = sellByID(id);
            return View(s);
        }
        
        public IActionResult Compare()
        {
            return View(listCompare);
        }
        public ActionResult deCompare(int ID)
        {
            listCompare.Remove(listCompare.SingleOrDefault(i => i.computer.ID == ID));
            return RedirectToAction("Compare", "Home");
        }
        public ActionResult addToCart(int id)
        {
            Sell s = sellByID(id);
            listCart.Add(s);
            return RedirectToAction("Index", "Home");
        }
        public ActionResult addToCompare(int id)
        {
            Sell s = sellByID(id);
            listCompare.Add(s);
            return RedirectToAction("Index", "Home");
        }

    }
}
