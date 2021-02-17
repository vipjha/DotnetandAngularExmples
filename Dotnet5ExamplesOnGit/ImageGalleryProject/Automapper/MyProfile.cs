using AutoMapper;
using ImageGalleryProject.Models;
using ImageGalleryProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImageGalleryProject.Automapper
{
    public class MyProfile : Profile
    {
        public MyProfile()
        {
            //Category
            CreateMap<Category, CategoryViewModel>().ReverseMap();
            CreateMap<Category, EditCategoryViewMdel>().ReverseMap();
            CreateMap<Category, CreateCategoryViewModel>().ReverseMap();


            //Media
            CreateMap<Media, MediaEditViewModel >().ReverseMap();
            CreateMap<Media, MediaViewModel>().ForMember(dest => dest.CategoryTitle, opt => opt.MapFrom(src => src.Category.Title));
            
        }
    }
}
