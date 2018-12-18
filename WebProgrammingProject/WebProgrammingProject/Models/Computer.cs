using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebProgrammingProject.Models
{
    public class Computer
    {
        public int ID { get; set; }
        public String ModelName { get; set; }
        public int Year { get; set; }
        public double ScreenSize { get; set; }
        public int HDDSize { get; set; }
        public int SSDSize { get; set; }
        public int RAMSize { get; set; }
        public int CPUID { get; set; }
        public int GPUID { get; set; }
        public int ManufacturerID { get; set; }
        public int UserID { get; set; }
        public double Price { get; set; }
        public Boolean IsSold { get; set; }
        public String ImageUrl { get; set; }
        public String ImageThumbnailUrl { get; set; }
    }
}
