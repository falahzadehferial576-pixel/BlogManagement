using System;
using System.Collections.Generic;
using System.Text;
using BlogManagement.Domain.Entities;

namespace BlogManagement.Application.Interfaces.Services;

public interface IArticleService : IService<Article>
{
    Task<List<Article>> GetAllWithCategoryAsync();

    Task<Article?> GetByIdWithCategoryAsync(int id);
}
