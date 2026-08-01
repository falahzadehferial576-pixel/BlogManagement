using BlogManagement.Domain.Entities;
using BlogManegement.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogManagement.Application.Interfaces.Repositories;

public interface ICategoryRepository : IRepository<Category>
{
    Task<bool> IsTitleExistAsync(string title);
}