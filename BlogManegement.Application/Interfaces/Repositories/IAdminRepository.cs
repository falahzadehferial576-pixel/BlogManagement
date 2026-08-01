using BlogManagement.Domain.Entities;
using BlogManegement.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogManagement.Application.Interfaces.Repositories;

public interface IAdminRepository : IRepository<Admin>
{
    Task<Admin?> GetByUserNameAsync(string userName);

    Task<Admin?> GetByEmailAsync(string email);
}
