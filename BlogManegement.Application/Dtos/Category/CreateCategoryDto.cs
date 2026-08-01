using System;
using System.Collections.Generic;
using System.Text;

namespace BlogManagement.Application.DTOs.Category;

public class CreateCategoryDto
{
    public string Title { get; set; } = string.Empty;

    public string Slug { get; set; } = string.Empty;

    public string? Description { get; set; }
}
