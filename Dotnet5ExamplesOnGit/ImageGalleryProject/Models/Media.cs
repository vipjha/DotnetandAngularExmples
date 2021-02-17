using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImageGalleryProject.Models
{
    public class Media
    {
        public int Id { get; set; }
        public string ImagPath { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; } = new Category();
    }
}
