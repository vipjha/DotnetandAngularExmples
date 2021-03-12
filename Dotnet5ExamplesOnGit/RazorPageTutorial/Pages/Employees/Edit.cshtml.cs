using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPageTutorial.Models;
using RezorPageTutotial.Services;

namespace RazorPageTutorial.Pages.Employees
{
    public class EditModel : PageModel
    {
        private readonly IEmployeeRespositry employeeRespository;
        private readonly IWebHostEnvironment webHostEnvernoment;

        public EditModel(IEmployeeRespositry employeeRespository, IWebHostEnvironment webHostEnvernoment)
        {
            this.employeeRespository = employeeRespository;
            this.webHostEnvernoment = webHostEnvernoment;
        }

        [BindProperty]
        public Employee Employee { get; set; }

        [BindProperty]
        public IFormFile Photo { get; set; }
        [BindProperty]
        public bool Notify { get; set; }
        public string Message { get; set; }


        public IActionResult OnGet(int id)
        {
            Employee = employeeRespository.GetEmployee(id);
            if (Employee == null)
            {
                return RedirectToPage("/NotFound");
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid) { 
            if (Photo != null)
            {
                if(Employee.PhotoPath!=null)
                {
                    string filePath = Path.Combine(webHostEnvernoment.WebRootPath, "images", Employee.PhotoPath);
                    System.IO.File.Delete(filePath);
                }

                Employee.PhotoPath = ProcessUploadFile();
            }

            Employee = employeeRespository.Update(Employee);
            return RedirectToPage("Index");
            }
            return Page();
        }

        public IActionResult OnPostUpdateNotificationPrefrences(int id)
        {

            if(Notify)
            {
                Message = "Thanks of turning on the notification";
            }
            else
            {
                Message = "You have turn off email notifiaction";
            }
            //Employee = employeeRespository.GetEmployee(id);

            TempData["message"] = Message;

            return RedirectToPage("Details", new { id = id});
        }

        private string ProcessUploadFile()
        {
            string uniqueFilename = null;
            if (Photo != null)
            {
                string uploadFolder = Path.Combine(webHostEnvernoment.WebRootPath, "images");
                uniqueFilename = Guid.NewGuid().ToString() + "_" + Photo.FileName;
                string filePath = Path.Combine(uploadFolder, uniqueFilename);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    Photo.CopyTo(fileStream);
                }
            }

            return uniqueFilename;
        }
    }

} 