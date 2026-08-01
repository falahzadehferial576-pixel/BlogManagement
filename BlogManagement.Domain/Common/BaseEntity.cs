using System;
using System.Collections.Generic;
using System.Text;

namespace BlogManagement.Domain.Common
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; } = new DateTime(2026, 1, 1);
        public DateTime? UpdatedAt { get; set; }
        public bool IsDeleted { get; set; }
    }
}
