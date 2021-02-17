using AutoMapper;
using ImageGalleryProject.Infrastructure;
using ImageGalleryProject.Models;
using ImageGalleryProject.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImageGalleryProject.Controllers
{
    public class MediaController : Controller
    {
        private readonly ILogger<MediaController> _logger;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public MediaController(ILogger<MediaController> logger, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        //All media file
        public IActionResult Index()
        {
            var media = _unitOfWork.MediaRepo.GetAll();
            var vm = _mapper.Map<List<MediaViewModel>>(media);
            return View(vm);
        }

        //Details of the single media
        public IActionResult Details(int id)
        {
            var media = _unitOfWork.MediaRepo.GetById(id);
            var vm = _mapper.Map<List<MediaViewModel>>(media);
            return View(vm);
        }

        //Get: Get view for creating media
        public ActionResult Create()
        {
            ViewBag.Categories = _unitOfWork.CategoryRepo.GetAll();
            return View();
        }

        //Post: Crate Medianager though postmethod
        public ActionResult Create(MediaCrateViewModel vm)
        {
            try
            {
                var category = _unitOfWork.CategoryRepo.GetById(vm.CategoryId);
                List<Media> media = new List<Media>();
                foreach(var file in vm.Files)
                {
                    media.Add(new Media()
                    {
                        ImagPath = file.FileName,
                        Category = category
                    });
                }

                _unitOfWork.UploaFile(vm.Files);
                _unitOfWork.MediaRepo.AddRange(media);
                _unitOfWork.save();

                return RedirectToAction("Index");
            }
            catch (Exception)
            {

                return View();
            }
        }

        //Get: Get view for edit the media manger
        public ActionResult Edit(int id)
        {
            ViewBag.Categories = _unitOfWork.CategoryRepo.GetAll();
            var media = _unitOfWork.MediaRepo.GetById(id);
            var mappedMedia = _mapper.Map<MediaEditViewModel>(media);
            return View(mappedMedia);
        }

        // POST: MediaManger/Edit/5
        public ActionResult Edit(MediaEditViewModel vm)
        {
            try
            {
                if (vm.File == null && _unitOfWork.MediaRepo.GetById(vm.Id).CategoryId == vm.CategoryId)
                {
                    RedirectToAction(nameof(Index));
                }
                else if(vm.File!=null)
                {
                    List<IFormFile> formFiles = new List<IFormFile>();
                    formFiles.Add(vm.File);
                    var updateMedia = _unitOfWork.MediaRepo.GetById(vm.Id);
                    updateMedia.CategoryId = vm.CategoryId;
                    updateMedia.ImagPath = vm.File.FileName;

                    _unitOfWork.UploaFile(formFiles);
                    _unitOfWork.MediaRepo.Update(updateMedia);
                    _unitOfWork.save();
                    RedirectToAction(nameof(Index));
                }

                else if(_unitOfWork.MediaRepo.GetById(vm.Id).CategoryId!=vm.CategoryId)
                {
                    List<IFormFile> formFiles = new List<IFormFile>();
                    formFiles.Add(vm.File);
                    var updateMedia = _unitOfWork.MediaRepo.GetById(vm.Id);
                    updateMedia.CategoryId = vm.CategoryId;
                    updateMedia.ImagPath = _unitOfWork.MediaRepo.GetById(vm.Id).ImagPath;

                    _unitOfWork.UploaFile(formFiles);
                    _unitOfWork.MediaRepo.Update(updateMedia);
                    _unitOfWork.save();
                    RedirectToAction(nameof(Index));
                }

                return RedirectToAction(nameof(Index));
            }
            catch (Exception)
            {

                return View();
            }
        }


        //Get: Get view to delete 
        public ActionResult Delete(int id)
        {
            var model = _unitOfWork.MediaRepo.GetById(id);
            var vm = _mapper.Map<MediaViewModel>(model);
            return View(vm);
        }

        //Post: Delete and save data through post
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                /// ToDo: Add delete logic here
                /// 

                return RedirectToAction(nameof(Index));
            }
            catch 
            {

                return View();
            }
        }
    }
}
