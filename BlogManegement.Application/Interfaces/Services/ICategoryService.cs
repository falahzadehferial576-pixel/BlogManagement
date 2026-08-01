using System;
using System.Collections.Generic;
using System.Text;
using System;
using System.Collections.Generic;
using System.Text;
using BlogManagement.Domain.Entities;

namespace BlogManagement.Application.Interfaces.Services;

public interface ICategoryService : IService<Category>
{
    Task<bool> IsTitleExistAsync(string title);
}

