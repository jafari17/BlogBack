using AutoMapper;
using BlogBack.Application.ViewModels;
using BlogBack.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogBack.Application.AutoMapperProfile
{
    public class DtoProfile : Profile
    {
        public DtoProfile()
        {
            //CreateMap<Post, PostDto>();
            CreateMap<PostDto, Post>();

            CreateMap<Category, CategoryDto>();
            CreateMap<CategoryDto, Category>();

            CreateMap<Post, PostDto>()
                //.ForMember(dest => dest.CategoryId, opt => opt.MapFrom(src => src.Category.CategoryId))
                //.ForMember(dest => dest.CategoryTitle, opt => opt.MapFrom(src => src.Category.TitleCategory))
                .ForMember(dest => dest.Labels, opt => opt.MapFrom(src => src.Labels));

            CreateMap<CategoryDto, CategoryDto>();

            CreateMap<LabelDto, LabelDto>();
            CreateMap<Label , LabelDto>();
            CreateMap<LabelDto, Label >();

 
        }
    }
}
