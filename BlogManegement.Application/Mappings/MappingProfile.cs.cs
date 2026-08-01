using AutoMapper;
using BlogManagement.Application.DTOs.Admin;
using BlogManagement.Application.DTOs.Article;
using BlogManagement.Application.DTOs.Category;
using BlogManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BlogManagement.Application.Mappings;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        // Category
        CreateMap<Category, CategoryDto>().ReverseMap();
        CreateMap<Category, CreateCategoryDto>().ReverseMap();
        CreateMap<Category, UpdateCategoryDto>().ReverseMap();

        // Article
        CreateMap<Article, ArticleDto>().ReverseMap();
        CreateMap<Article, CreateArticleDto>().ReverseMap();
        CreateMap<Article, UpdateArticleDto>().ReverseMap();

        // Admin
        CreateMap<Admin, AdminDto>().ReverseMap();
    }
}
