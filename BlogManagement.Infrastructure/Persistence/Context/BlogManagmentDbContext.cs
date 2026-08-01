using System;
using System.Collections.Generic;
using System.Text;
using BlogManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlogManagement.Infrastructure.Persistence.Context;

public class BlogManagementDbContext : DbContext
{
    public BlogManagementDbContext(DbContextOptions<BlogManagementDbContext> options)
        : base(options)
    {
    }

    public DbSet<Admin> Admins => Set<Admin>();

    public DbSet<Category> Categories => Set<Category>();

    public DbSet<Article> Articles => Set<Article>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(BlogManagementDbContext).Assembly);

        modelBuilder.Entity<Admin>().HasData(
     new Admin
     {
         Id = 1,
         FullName = "Administrator",
         UserName = "admin",
         Email = "admin@gmail.com",
         PasswordHash = "123456",
         IsActive = true,
         CreatedAt = DateTime.Now
     });

        base.OnModelCreating(modelBuilder);
    }
}
