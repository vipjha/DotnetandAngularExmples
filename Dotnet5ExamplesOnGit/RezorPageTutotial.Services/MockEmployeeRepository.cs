using RazorPageTutorial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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
                new Employee(){Id = 1, Name="Sachin", Department=Dept.HR, Email="jhasac@gmail.com"},
                new Employee(){Id = 1, Name="Vipin", Department=Dept.IT, Email="jhavip@gmail.com",PhotoPath="Img2.jpg"},
                new Employee(){Id = 1, Name="Puja", Department=Dept.Payroll, Email="pujvip@gmail.com",PhotoPath="Img1.jpg"},
 
            };
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeesList;  
           // throw new NotImplementedException();
        }

        /// <summary>
        /// Get Emplyee by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Employee GetEmployee(int id)
        {
            return _employeesList.FirstOrDefault(e => e.Id == id);
        }

        /// <summary>
        /// Update Employee
        /// </summary>
        /// <param name="updateEmployee"></param>
        /// <returns></returns>
        public Employee Update(Employee updateEmployee)
        {
             Employee employee =_employeesList.FirstOrDefault(e => e.Id == updateEmployee.Id);
            if(employee != null)
            {
                employee.Name = updateEmployee.Name;
                employee.Email = updateEmployee.Email;
                employee.Department = updateEmployee.Department;
                employee.PhotoPath = updateEmployee.PhotoPath;
            }
            return employee;
        }
    }
}
