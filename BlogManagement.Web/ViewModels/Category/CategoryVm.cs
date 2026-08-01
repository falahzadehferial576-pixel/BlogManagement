using System;
using System.Collections.Generic;
using System.Text;

namespace BlogManagement.Application.ViewModels.Category;

public class CategoryViewModel
{
    public int Id { get; set; }

    public string Title { get; set; } = string.Empty;

    public string? Description { get; set; }
    public string Slug { get; set; } = string.Empty;

   
}
