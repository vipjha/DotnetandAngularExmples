﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImageGalleryProject.ViewModels
{
    public class MediaViewModel
    {
        public int Id { get; set; }
        public string ImagePath { get; set; }
        public string CategoryTitle { get; set; }
    }

    public class MediaEditViewModel
    {
        public int Id { get; set; }
        public string ImagePath { get; set; }
        public IFormFile File { get; set; }
        public int CategoryId { get; set; }
    }

    public class MediaCrateViewModel
    {
        public List<IFormFile> Files { get; set; }
        public int CategoryId { get; set; }
    }
}
