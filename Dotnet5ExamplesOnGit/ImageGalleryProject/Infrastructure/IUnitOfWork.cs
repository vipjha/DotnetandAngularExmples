using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImageGalleryProject.Infrastructure
{
    public interface IUnitOfWork
    {
        ICategoryRepo CategoryRepo { get; }
        IMediaRepo MediaRepo { get; }
        void save();
        void UploaFile(List<IFormFile> files);

    }
}
