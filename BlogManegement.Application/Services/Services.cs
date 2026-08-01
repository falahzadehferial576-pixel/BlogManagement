using BlogManagement.Application.Interfaces;
using BlogManagement.Application.Interfaces.Services;
using BlogManagement.Domain.Common;
using BlogManegement.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogManagement.Application.Services;

public class Service<TEntity> : IService<TEntity>
    where TEntity : BaseEntity
{
    protected readonly IRepository<TEntity> _repository;

    public Service(IRepository<TEntity> repository)
    {
        _repository = repository;
    }

    public async Task<List<TEntity>> GetAllAsync()
    {
        return await _repository.GetAllAsync();
    }

    public async Task<TEntity?> GetByIdAsync(int id)
    {
        return await _repository.GetByIdAsync(id);
    }

    public async Task AddAsync(TEntity entity)
    {
        await _repository.AddAsync(entity);
        await _repository.SaveChangesAsync();
    }

    public async Task UpdateAsync(TEntity entity)
    {
        _repository.Update(entity);
        await _repository.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var entity = await _repository.GetByIdAsync(id);

        if (entity is null)
            return;

        _repository.Delete(entity);
        await _repository.SaveChangesAsync();
    }
}