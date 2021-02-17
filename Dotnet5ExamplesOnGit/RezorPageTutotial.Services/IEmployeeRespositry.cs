using RazorPageTutorial.Models;
using System;
using System.Collections.Generic;

namespace RezorPageTutotial.Services
{
    public interface IEmployeeRespositry
    {
        IEnumerable<Employee> GetAllEmployees();
    }
}
