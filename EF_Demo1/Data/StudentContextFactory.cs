using System;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;

namespace EF_Demo1.Data;

public class StudentContextFactory : IDesignTimeDbContextFactory<StudentDbContext>
{
    public StudentDbContext CreateDbContext(string[] args){
        var optionsBuilder = new DbContextOptionsBuilder<StudentDbContext>();
        optionsBuilder.UseSqlite("Data Source=StudentDb.db");
        return new StudentDbContext(optionsBuilder.Options);
    }
}
