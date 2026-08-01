using System;
using System.Collections.Generic;
using System.Text;
using BlogManagement.Application.Interfaces.Repositories;
using BlogManagement.Application.Interfaces.Services;
using BlogManagement.Domain.Entities;

namespace BlogManagement.Application.Services.Implementations;

public class ArticleService
    : Service<Article>, IArticleService
{
    private readonly IArticleRepository _articleRepository;

    public ArticleService(IArticleRepository articleRepository)
        : base(articleRepository)
    {
        _articleRepository = articleRepository;
    }
    public async Task<List<Article>> GetByCategoryIdAsync(int categoryId)

    {

        return await _articleRepository.GetByCategoryIdAsync(categoryId);

    }
    public async Task UpdateAsync(Article article)
    {
        _repository.Update(article);

        await _repository.SaveChangesAsync();
    }
    public async Task<List<Article>> GetAllWithCategoryAsync()
    {
        return await _articleRepository.GetAllWithCategoryAsync();
    }

    public async Task<Article?> GetByIdWithCategoryAsync(int id)
    {
        return await _articleRepository.GetByIdWithCategoryAsync(id);
    }


}
