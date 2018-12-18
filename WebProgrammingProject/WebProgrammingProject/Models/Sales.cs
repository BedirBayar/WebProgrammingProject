using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebProgrammingProject.Models
{
    public class Sales
    {
        public int ID { get; set; }
        public int ComputerID { get; set; }
        public int BuyerID { get; set; }
        public DateTime date { get; set; }
    }
}
