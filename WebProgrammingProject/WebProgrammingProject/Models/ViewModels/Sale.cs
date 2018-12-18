using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebProgrammingProject.Models.ViewModels
{
    public class Sale
    {
        public Computer computer { get; set; }
        public User buyer { get; set; }
        public DateTime date { get; set; }

    }
}
