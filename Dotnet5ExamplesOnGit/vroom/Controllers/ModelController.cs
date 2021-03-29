using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vroom.AddDbContext;
using vroom.Models;
using vroom.Models.ViewModels;

namespace vroom.Controllers
{
    public class ModelController : Controller
    {
        private readonly VroomDBContext _db;

        [BindProperty]
        public ModelViewModel ModelVm { get; set; }

        public ModelController(VroomDBContext db)
        {
            _db = db;
            ModelVm = new ModelViewModel()
            {
                Makes = _db.Makes.ToList(),
                Model = new Models.Model()
            };
        }

        /// <summary>
        /// Indx view listing the data
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            var model = _db.Models.Include(m => m.Make);
            return View(model);
        }

        /// <summary>
        /// Get the view to create method, this is get for Create
        /// </summary>
        /// <returns></returns>
        public IActionResult Create()
        {
            return View(ModelVm);
        }

        /// <summary>
        /// Create method through Post Method
        /// </summary>
        /// <returns></returns>
        [HttpPost, ActionName("Create")]
        public IActionResult CreatePost()
        {
            if(!ModelState.IsValid)
            {
                return View(ModelVm);
            }
            _db.Models.Add(ModelVm.Model);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult Edit(int id)
        {
            ModelVm.Model = _db.Models.Include(m => m.Make).SingleOrDefault(m => m.Id == id);
            if(ModelVm.Model==null)
            {
                return NotFound();
            }
            return View(ModelVm);
        }

        [HttpPost, ActionName("Edit")]
        public IActionResult EditPost()
        {
            if(!ModelState.IsValid)
            {
                return View();
            }

            _db.Update(ModelVm.Model);
            _db.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
        
        [HttpPost]
        public IActionResult Delete(int id)
        {
            Model model = _db.Models.Find(id);
            if(model==null)
            {
                return NotFound();
            }
            _db.Models.Remove(model);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        
    }
}
