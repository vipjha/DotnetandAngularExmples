using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vroom.AddDbContext;
using vroom.Models;

namespace vroom.Controllers
{
    public class MakeController : Controller
    {
        private readonly VroomDBContext _db;

        public MakeController(VroomDBContext db)
        {
            _db = db;
        }

       public IActionResult Index()
        {
           return View(_db.Makes.ToList());
        }
         
        //http Get Method
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Make make)
        {
            if(ModelState.IsValid)
            {
                _db.Add(make);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(make);
        }

        //Delete function through the Post Method
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var make = _db.Makes.Find(id);
            if(make==null)
            {
                return NotFound(); 
            }

            _db.Makes.Remove(make);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));

        }

        /// <summary>
        /// Get method for edit functionality
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult Edit(int id)
        {
            var make = _db.Makes.Find(id);
            if (make == null)
            {
                return NotFound();
            }
            return View(make);
        }
        /// <summary>
        /// Post medhod for edit functionality
        /// </summary>
        /// <param name="make"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Edit(Make make)
        {
            if (ModelState.IsValid)
            {
                _db.Update(make);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(make);
        }
    }
}
