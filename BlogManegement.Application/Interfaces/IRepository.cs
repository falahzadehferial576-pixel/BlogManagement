using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Generic;
using BlogManagement.Domain.Common;

namespace BlogManegement.Application.Interfaces;

public interface IRepository<TEntity>
    where TEntity : BaseEntity
{
    Task<List<TEntity>> GetAllAsync();

    Task<TEntity?> GetByIdAsync(int id);

    Task AddAsync(TEntity entity);

    void Update(TEntity entity);

    void Delete(TEntity entity);

    Task SaveChangesAsync();
}
