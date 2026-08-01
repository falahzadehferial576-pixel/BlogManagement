using System;
using System.Collections.Generic;
using System.Text;

namespace BlogManegement.Application.ViewModels.Article
{
    public class ArticleListItemVm
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Slug { get; set; } = string.Empty;

        public string? ImageName { get; set; }

        public string CategoryTitle { get; set; } = string.Empty;
    }
}
