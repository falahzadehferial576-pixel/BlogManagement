using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using BlogManagement.Application.Interfaces.Repositories;
using BlogManagement.Domain.Entities;
using BlogManagement.Infrastructure.Persistence.Context;

namespace BlogManagement.Infrastructure.Repositories.Implementations;

public class ArticleRepository
    : Repository<Article>, IArticleRepository
{
    public ArticleRepository(BlogManagementDbContext context)
        : base(context)
    {
    }
    public async Task<List<Article>> GetByCategoryIdAsync(int categoryId)
    {

        return await _context.Articles

            .Where(a => a.CategoryId == categoryId)

            .ToListAsync();

    }
    public async Task<List<Article>> GetAllWithCategoryAsync()
    {
        return await _context.Articles
            .Include(x => x.Category)
            .ToListAsync();
    }

    public async Task<Article?> GetByIdWithCategoryAsync(int id)
    {
        return await _context.Articles
            .Include(x => x.Category)
            .FirstOrDefaultAsync(x => x.Id == id);
    }

}
