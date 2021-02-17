using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImageGalleryProject.ViewModels
{
    public class CategoryViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }

    public class EditCategoryViewMdel
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }

    public class CreateCategoryViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }

}
