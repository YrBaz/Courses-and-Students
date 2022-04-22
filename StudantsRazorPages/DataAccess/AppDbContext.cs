﻿using Microsoft.EntityFrameworkCore;
using StudantsRazorPages.Models;

namespace StudantsRazorPages.DataAccess
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}
