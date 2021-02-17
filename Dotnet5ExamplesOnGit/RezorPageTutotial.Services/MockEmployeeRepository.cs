using RazorPageTutorial.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RezorPageTutotial.Services
{
    public class MockEmployeeRepository : IEmployeeRespositry
    {
        private List<Employee> _employeesList;
        public MockEmployeeRepository()
        {
            _employeesList = new List<Employee>()
            {
                new Employee(){Id = 1, Name="Sachin", Department=Dept.HR, Email="jhasac@gmail.com",PhotoPath="marry.png"},
                new Employee(){Id = 1, Name="Vipin", Department=Dept.IT, Email="jhavip@gmail.com",PhotoPath="marry.png"},
                new Employee(){Id = 1, Name="Puja", Department=Dept.Payroll, Email="jhavip@gmail.com",PhotoPath="marry.png"},
 
            };
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeesList;  
           // throw new NotImplementedException();
        }
    }
}
