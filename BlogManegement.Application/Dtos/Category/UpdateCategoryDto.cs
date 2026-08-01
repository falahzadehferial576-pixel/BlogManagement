using System;
using System.Collections.Generic;
using System.Text;

namespace BlogManagement.Application.DTOs.Category;

public class UpdateCategoryDto
{
    public int Id { get; set; }

    public string Title { get; set; } = string.Empty;

    public string Slug { get; set; } = string.Empty;

    public string? Description { get; set; }
}