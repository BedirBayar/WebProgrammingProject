using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using WebProgrammingProject.Models;
using WebProgrammingProject.Models.ViewModels;

namespace WebProgrammingProject.Controllers
{
    public class ComputerController : Controller
    {
       
      
        
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Buy(Sell sell)
        {
            return View(sell);
        }
        //public IActionResult Details(int id)
        //{

        //    Computer c1 = context.Computers.FirstOrDefault(i => i.ID == id);
        //    CPU Cpu1 = context.CPUs.FirstOrDefault(i => i.ID == c1.CPUID);
        //    GPU Gpu1 = context.GPUs.FirstOrDefault(i => i.ID == c1.GPUID);
        //    User user = context.Users.FirstOrDefault(i => i.ID == c1.UserID);
        //    Manufacturer m1 = context.Manufacturers.FirstOrDefault(i => i.ID == c1.ManufacturerID);


        //    Sell s = new Sell();
        //    s.computer = c1;
        //    s.cpu = Cpu1;
        //    s.gpu = Gpu1;
        //    s.user = user;
        //    s.man = m1;



        //    return View(s);
        //}
        

    }
}