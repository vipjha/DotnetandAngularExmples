using ImageGalleryProject.Data;
using ImageGalleryProject.Infrastructure;
using ImageGalleryProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImageGalleryProject.Services
{
    public class MediaRepo : IMediaRepo
    {
        private readonly ProjectDbContext _projectDbContext;

        public MediaRepo(ProjectDbContext projectDbContext )
        {
            _projectDbContext = projectDbContext;
        }

        public void AddRange(List<Media> model)
        {
            _projectDbContext.Medias.AddRange(model);
            //throw new NotImplementedException();
        }

        public void Delete(int Id)
        {
            var mediaManager = GetById(Id);
            _projectDbContext.Medias.Remove(mediaManager);
            //throw new NotImplementedException();
        }

        public List<Media> GetAll()
        {
            var data = _projectDbContext.Medias
                .Include(x => x.Category).ToList();
            return data;

            //throw new NotImplementedExce9x=>xption();
        }

        public Media GetById(int Id)
        {
           return _projectDbContext.Medias.Where(x => x.Id == Id).Include(x=>x.Category).FirstOrDefault();
            //throw new NotImplementedException();
        }

        public void Insert(Media mediaManger)
        {
            _projectDbContext.Medias.Add(mediaManger);
            //throw new NotImplementedException();
        }

        public void Update(Media mediaManger)
        {
            _projectDbContext.Medias.Update(mediaManger);   
            //throw new NotImplementedException();
        }
    }
}
