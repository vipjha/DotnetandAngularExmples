using ImageGalleryProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImageGalleryProject.Infrastructure
{
   public interface IMediaRepo
    {
        List<Media> GetAll();
        Media GetById(int Id);
        void Insert(Media mediaManger);
        void Update(Media mediaManger);
        void Delete(int Id);

        void AddRange(List<Media> model);
    }
}
