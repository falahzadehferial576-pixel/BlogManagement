using System;
using System.Collections.Generic;
using System.Text;
using BlogManagement.Domain.Common;
using BlogManagement.Domain.Entities;

namespace BlogManagement.Domain.Entities
{
    public class Admin : BaseEntity
    {
        public string FullName { get; set; } = null!;
        public string UserName { get; set; } = null!;
        public string Email {  get; set; } = null!;
        public string PasswordHash { get; set; } = null!;
        public bool IsActive { get; set; } = true;
        public string? ResetPasswordToken {  get; set; } 
        public DateTime? ResetPasswordTokenExpireDate {  get; set; }



    }
    
    
}
