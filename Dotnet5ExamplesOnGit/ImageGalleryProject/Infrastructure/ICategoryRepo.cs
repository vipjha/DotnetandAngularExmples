using ImageGalleryProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImageGalleryProject.Infrastructure
{
    public interface ICategoryRepo
    {
        List<Category> GetAll();
        Category GetById( int Id);
        void Insert(Category category);
        void Update(Category category);
        void Delete(int Id);
    }
}
