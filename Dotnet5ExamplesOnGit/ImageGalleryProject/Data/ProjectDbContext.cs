using ImageGalleryProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ImageGalleryProject.ViewModels;

namespace ImageGalleryProject.Data
{
    public class ProjectDbContext: DbContext
    {
        public ProjectDbContext(DbContextOptions<ProjectDbContext> options) : base(options)
        {
                
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Media> Medias { get; set; }
        //public DbSet<ImageGalleryProject.ViewModels.CategoryViewModel> CategoryViewModel { get; set; }
        //public DbSet<ImageGalleryProject.ViewModels.CreateCategoryViewModel> CreateCategoryViewModel { get; set; }
        //public DbSet<ImageGalleryProject.ViewModels.MediaViewModel> MediaViewModel { get; set; }
        //public DbSet<ImageGalleryProject.ViewModels.MediaViewModel> MediaViewModel { get; set; }
    }
}
