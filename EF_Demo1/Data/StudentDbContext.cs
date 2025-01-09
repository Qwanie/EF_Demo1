using System;
using EF_Demo1.Models;
using Microsoft.EntityFrameworkCore;

namespace EF_Demo1.Data;

public class StudentDbContext : DbContext
{
    public DbSet<School> Schools { get; set; } = null!;
    public DbSet<Student> Students { get; set; } = null!;
    public DbSet<Course> Courses { get; set; } = null!;

    public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options) {}
    
}
