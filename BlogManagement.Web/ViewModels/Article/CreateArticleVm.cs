using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace BlogManegement.Application.ViewModels.Article
{
    public class CreateArticleVm
    {
        public string Title { get; set; } = string.Empty;

        public string Slug { get; set; } = string.Empty;
        public string Summary { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;

        public string? ImageName { get; set; }
        public int CategoryId { get; set; }

    }
}
