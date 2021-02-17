using ImageGalleryProject.Data;
using ImageGalleryProject.Infrastructure;
using ImageGalleryProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImageGalleryProject.Services
{
    public class CategoryRepo : ICategoryRepo
    {
        private readonly ProjectDbContext _projectDbContext;

        public CategoryRepo(ProjectDbContext projectDbContext)
        {
            _projectDbContext = projectDbContext;
        }

        public void Delete(int Id)
        {
            var catgory = GetById(Id);
            _projectDbContext.Categories.Remove(catgory);
            //throw new NotImplementedException();
        }

        public List<Category> GetAll()
        {
            return _projectDbContext.Categories.ToList();
            //throw new NotImplementedException();
        }

        public Category GetById(int Id)
        {
            return _projectDbContext.Categories.Where(x => x.Id == Id).FirstOrDefault();
            //throw new NotImplementedException();
        }

        public void Insert(Category category)
        {
            _projectDbContext.Categories.Add(category);
            //throw new NotImplementedException();
        }

        public void Update(Category category)
        {
            _projectDbContext.Categories.Update(category);
            //throw new NotImplementedException();
        }
    }
}
