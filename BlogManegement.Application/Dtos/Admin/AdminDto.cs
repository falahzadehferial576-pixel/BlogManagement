using System;
using System.Collections.Generic;
using System.Text;

namespace BlogManagement.Application.DTOs.Admin;

public class AdminDto
{
    public int Id { get; set; }

    public string UserName { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;
}
