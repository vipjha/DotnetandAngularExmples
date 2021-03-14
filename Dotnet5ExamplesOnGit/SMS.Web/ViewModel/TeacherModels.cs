using SMS.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMS.Web.ViewModel
{
    public class TeachderDetailVm
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime BitrhDate { get; set; }
        public string Address { get; set; }
        public Gender Gender { get; set; }
    }
}
