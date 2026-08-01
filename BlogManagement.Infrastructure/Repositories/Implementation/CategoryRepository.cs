using BlogManagement.Application.Interfaces.Repositories;
using BlogManagement.Domain.Entities;
using BlogManagement.Infrastructure.Persistence.Context;
using BlogManagement.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogManagement.Infrastructure.Persistence.Repositories;

public class CategoryRepository : Repository<Category>, ICategoryRepository
{
    public CategoryRepository(BlogManagementDbContext context)
        : base(context)
    {
    }

    public async Task<bool> IsTitleExistAsync(string title)
    {
        return await _context.Categories
            .AnyAsync(c => c.Title == title);
    }
}