using System;
using System.Collections.Generic;
using System.Text;
using BlogManagement.Domain.Common;

namespace BlogManagement.Domain.Entities
{
    public class Article : BaseEntity
    {
        public string Title { get; set; } = null!;
        public string Slug { get; set; } = null!;
        public string Summary { get; set; } = null!;
        public string Content { get; set; } = null!;
        public string? ImageName {  get; set; }
        public int CategoryId {  get; set; }
        public Category Category { get; set; } = null!;
    }
}
