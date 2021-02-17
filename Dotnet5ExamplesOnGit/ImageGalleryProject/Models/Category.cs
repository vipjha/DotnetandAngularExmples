using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImageGalleryProject.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<Media> Medias { get; set; } = new List<Media>();
    }
}
