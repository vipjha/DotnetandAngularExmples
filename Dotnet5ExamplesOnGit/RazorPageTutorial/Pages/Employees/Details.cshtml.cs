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
    public class DetailsModel : PageModel
    {
        private readonly IEmployeeRespositry employeeRespository;

        public DetailsModel(IEmployeeRespositry employeeRespository)
        {
            this.employeeRespository = employeeRespository;
        }

        [BindProperty(SupportsGet =true)]
        public string Message { get; set; }

        public Employee Employee { get; private set; }

        public IActionResult OnGet(int id)
        {
            Employee = employeeRespository.GetEmployee(id);
            if(Employee == null)
            {
                return RedirectToPage("/NotFound");
            }
            return Page();
        }
    }
}
