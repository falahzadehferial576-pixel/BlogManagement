using System;
using System.Collections.Generic;
using System.Text;

namespace BlogManegement.Application.ViewModels.Category
{
    public class CreateCategoryVm
    {
        public string Title { get; set; } = string.Empty;

        public string? Description { get; set; }
    }
}
