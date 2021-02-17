using ImageGalleryProject.Data;
using ImageGalleryProject.Infrastructure;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ImageGalleryProject.Services
{
    public class UnitOfWork : IUnitOfWork
    { 
        private readonly ProjectDbContext _projectDbContext;
        private ICategoryRepo _categoryRepo;
        private IMediaRepo _mediaRepo;
        private IHostingEnvironment hostingEnvironment;

        public UnitOfWork(ProjectDbContext projectDbContext, IHostingEnvironment hostingEnvironment)
        {
            _projectDbContext = projectDbContext;
            this.hostingEnvironment = hostingEnvironment;
        }

        public ICategoryRepo CategoryRepo
        {
            get
            {
                return _categoryRepo = _categoryRepo ?? new CategoryRepo(_projectDbContext);
            }
        }

        public IMediaRepo MediaRepo
        {
            get
            {
                return _mediaRepo = _mediaRepo ?? new MediaRepo(_projectDbContext);
            }
        }

        public void save()
        {
            _projectDbContext.SaveChanges();
           // throw new NotImplementedException();
        }

        public async void UploaFile(List<IFormFile> files)
        {
            foreach(IFormFile item in files)
            {
                long totalBytes = files.Sum(f => f.Length);
                string filename = item.FileName.Trim('"');
                filename = EnsureFileName(filename);
                byte[] buffer = new byte[16 * 1024];
                using (FileStream output = File.Create(GetpathAndFileName(filename)))
                {
                    using(Stream input = item.OpenReadStream())
                    {
                        int readBytes;
                        while((readBytes = input.Read(buffer,0,buffer.Length))>0)
                        {
                            await output.WriteAsync(buffer, 0, readBytes);
                            totalBytes += readBytes;
                        }
                    }
                }
            }
        }

        private string EnsureFileName(string filename)
        {
            if (filename.Contains("\\"))
                filename = filename.Substring(filename.LastIndexOf("\\") + 1);
            return filename;
        }

        private string GetpathAndFileName(string filename)
        {
            string path = hostingEnvironment.WebRootPath + "\\uploads\\";
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
            return path + filename;
        }
    }
}
