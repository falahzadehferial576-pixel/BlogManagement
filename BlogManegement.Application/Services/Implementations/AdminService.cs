using System;
using System.Collections.Generic;
using System.Text;
using BlogManagement.Application.Interfaces.Repositories;
using BlogManagement.Application.Interfaces.Services;
using BlogManagement.Domain.Entities;

namespace BlogManagement.Application.Services.Implementations;

public class AdminService : Service<Admin>, IAdminService
{
    private readonly IAdminRepository _adminRepository;

    public AdminService(IAdminRepository adminRepository)
        : base(adminRepository)
    {
        _adminRepository = adminRepository;
    }

    public async Task<Admin?> GetByUserNameAsync(string userName)
    {
        return await _adminRepository.GetByUserNameAsync(userName);
    }

    public async Task<Admin?> GetByEmailAsync(string email)
    {
        return await _adminRepository.GetByEmailAsync(email);
    }
    public async Task UpdateAsync(Admin admin)

    {

        _repository.Update(admin);

        await _repository.SaveChangesAsync();

    }


}
