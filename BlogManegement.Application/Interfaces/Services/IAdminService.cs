using System;
using System.Collections.Generic;
using System.Text;
using BlogManagement.Domain.Entities;

namespace BlogManagement.Application.Interfaces.Services;

public interface IAdminService : IService<Admin>
{
    Task<Admin?> GetByUserNameAsync(string userName);

    Task<Admin?> GetByEmailAsync(string email);
}
