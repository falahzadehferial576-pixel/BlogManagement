using System;
using System.Collections.Generic;
using System.Text;

namespace BlogManegement.Application.ViewModels.Article
{
    public class ArticleVm
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Slug { get; set; } = string.Empty;

        public string Summary { get; set; } = string.Empty;

        public string Content { get; set; } = string.Empty;

        public string? ImageName { get; set; }

        public int CategoryId { get; set; }

        public string CategoryTitle { get; set; } = string.Empty;
    }
}
