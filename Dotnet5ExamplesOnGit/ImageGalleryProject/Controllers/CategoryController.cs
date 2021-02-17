using AutoMapper;
using ImageGalleryProject.Infrastructure;
using ImageGalleryProject.Models;
using ImageGalleryProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImageGalleryProject.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ILogger<CategoryController> _logger;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CategoryController(ILogger<CategoryController> logger, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        //Get list of category on the Indexpage
        public IActionResult Index()
        {
            var category = _unitOfWork.CategoryRepo.GetAll();
            var mappedCategory = _mapper.Map<List<CategoryViewModel>>(category);
            return View(mappedCategory);
        }

        //Get: Categor details
        public ActionResult Details(int id)
        {
            var category = _unitOfWork.CategoryRepo.GetById(id);
            var mappedCategory = _mapper.Map<List<CategoryViewModel>>(category);
            return View(mappedCategory);
        }

        //Get:View to create category
        public ActionResult Create()
        {
            return View();
        }

        //Post: Cretea category through the Post methods
        public ActionResult Create(CreateCategoryViewModel categoryViewModel)
        {
            try
            {
                //var category = _unitOfWork.CategoryRepo.GetAll();
                var mappedCategory = _mapper.Map<Category>(categoryViewModel);
                _unitOfWork.CategoryRepo.Insert(mappedCategory);
                _unitOfWork.save();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        //GET: Get view to edit category with Id/5
        public ActionResult Edit(int id)
        {
            var category = _unitOfWork.CategoryRepo.GetById(id);
            var mappedCategory = _mapper.Map<EditCategoryViewMdel>(category);
            return View(mappedCategory);
        }

        //Post: Edit category through the Post methods
        public ActionResult Edit(EditCategoryViewMdel editCategoryViewMdel)
        {
            try
            {
                //var category = _unitOfWork.CategoryRepo.GetAll();
                var category = _mapper.Map<Category>(editCategoryViewMdel);
                _unitOfWork.CategoryRepo.Update(category);
                _unitOfWork.save();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        //Delete: Get view for delete methods
        public ActionResult Delete(int id)
        {
            var category = _unitOfWork.CategoryRepo.GetById(id);
            var mappedCategory = _mapper.Map<CategoryViewModel>(category);
            return View(mappedCategory);
        }

        //Post: Delete category by the id:
        public ActionResult Delete(int Id, CategoryViewModel categoryViewModel)
        {
            try
            {
                _unitOfWork.CategoryRepo.Delete(Id);
                _unitOfWork.save();

                return RedirectToAction(nameof(Index));
            }
            catch (Exception)
            {

                return View();
            }
        }
    }
}
