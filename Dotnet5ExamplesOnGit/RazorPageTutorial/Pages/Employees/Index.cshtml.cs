using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPageTutorial.Models;
using RezorPageTutotial.Services;

namespace RazorPageTutorial.Pages.Employees
{
    public class IndexModel : PageModel
    {
        private readonly IEmployeeRespositry employeeRespositry;

        public IEnumerable<Employee> Employees { get; set; }

        public IndexModel(IEmployeeRespositry employeeRespositry)
        {
            this.employeeRespositry = employeeRespositry;
        }

        public void OnGet()
        {
            Employees = employeeRespositry.GetAllEmployees();
        }
    }
}
