using System;
using System.Collections.Generic;
using System.Text;
using BlogManagement.Application.Interfaces.Repositories;
using BlogManagement.Domain.Entities;
using BlogManagement.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace BlogManagement.Infrastructure.Repositories.Implementations;

public class AdminRepository
    : Repository<Admin>, IAdminRepository
{
    public AdminRepository(BlogManagementDbContext context)
        : base(context)
    {
    }

    public async Task<Admin?> GetByUserNameAsync(string userName)
    {
        return await _context.Admins
            .FirstOrDefaultAsync(x => x.UserName == userName);
    }

    public async Task<Admin?> GetByEmailAsync(string email)
    {
        return await _context.Admins
            .FirstOrDefaultAsync(x => x.Email == email);
    }
}