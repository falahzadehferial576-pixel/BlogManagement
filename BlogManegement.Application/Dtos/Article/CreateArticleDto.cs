using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Http;
namespace BlogManagement.Application.DTOs.Article;

public class CreateArticleDto
{
    public string Title { get; set; } = string.Empty;

    public string Slug { get; set; } = string.Empty;

    public string Summary { get; set; } = string.Empty;

    public string Content { get; set; } = string.Empty;

    public string? ImageName { get; set; }
    public IFormFile? ImageFile { get; set; }

    public int CategoryId { get; set; }
}
