using System;
using System.Collections.Generic;
using System.Text;
using BlogManagement.Domain.Common;

namespace BlogManagement.Domain.Entities
{
    public class Category : BaseEntity
    {
        public string Title {  get; set; }
        public string Slug {  get; set; }
        public string? Description {  get; set; }
        public ICollection<Article> Articles { get; set; } = new List<Article>();
    }
}
