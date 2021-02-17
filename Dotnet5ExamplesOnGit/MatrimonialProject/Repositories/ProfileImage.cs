﻿using MatrimonialProject.Infrastructure;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MatrimonialProject.Repositories
{
    public class ProfileImage : IProfileImage
    {
        private IHostingEnvironment _hostingEnvirnoment;

        public ProfileImage(IHostingEnvironment hostingEnvirnoment)
        {
            _hostingEnvirnoment = hostingEnvirnoment;
        }

        public async void UploadImage(IFormFile file)
        {
            long totalBytes = file.Length;
            string filename = file.FileName.Trim('"');
            filename = EnsureFileName(filename);
            byte[] buffer = new byte[16 * 1024];

            using(FileStream output = System.IO.File.Create(GetpathAndFileName(filename)))
            {
                using(Stream input = file.OpenReadStream())
                {
                    int readBytes;
                    while((readBytes=input.Read(buffer,0, buffer.Length))>0)
                    {
                        await output.WriteAsync(buffer, 0, readBytes);
                        totalBytes += readBytes;
                    }
                }
            }
        }

        private string GetpathAndFileName(string filename)
        {
            string path = _hostingEnvirnoment.WebRootPath + "\\uploads\\";
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
            return path + filename;
        }

        private string EnsureFileName(string filename)
        {
            if (filename.Contains("\\"))
                filename = filename.Substring(filename.LastIndexOf("\\") + 1);
            return filename;
        }
    }
}
