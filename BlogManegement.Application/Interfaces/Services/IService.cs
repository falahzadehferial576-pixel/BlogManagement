using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Generic;
using BlogManagement.Domain.Common;

namespace BlogManagement.Application.Interfaces.Services;

public interface IService<TEntity> where TEntity : BaseEntity
{
    Task<List<TEntity>> GetAllAsync();

    Task<TEntity?> GetByIdAsync(int id);

    Task AddAsync(TEntity entity);

    Task UpdateAsync(TEntity entity);

    Task DeleteAsync(int id);
}