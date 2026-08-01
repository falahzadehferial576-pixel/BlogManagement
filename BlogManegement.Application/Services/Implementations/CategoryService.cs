using System;
using System.Collections.Generic;
using System.Text;
using BlogManagement.Application.Interfaces.Repositories;
using BlogManagement.Application.Interfaces.Services;
using BlogManagement.Domain.Entities;

namespace BlogManagement.Application.Services.Implementations;

public class CategoryService
    : Service<Category>, ICategoryService
{
    private readonly ICategoryRepository _categoryRepository;

    public CategoryService(ICategoryRepository categoryRepository)
        : base(categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }
    public async Task<bool> IsTitleExistAsync(string title)

    {

        return await _categoryRepository.IsTitleExistAsync(title);

    }


}
