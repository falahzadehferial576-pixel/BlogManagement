using BlogManagement.Domain.Entities;
using BlogManegement.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogManagement.Application.Interfaces.Repositories;

public interface IArticleRepository : IRepository<Article>
{
    Task<List<Article>> GetByCategoryIdAsync(int categoryId);
    Task<List<Article>> GetAllWithCategoryAsync();

    Task<Article?> GetByIdWithCategoryAsync(int id);
}