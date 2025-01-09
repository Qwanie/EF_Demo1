using EF_Demo1.Data;
using EF_Demo1.Models;
using Microsoft.EntityFrameworkCore;

var options = new DbContextOptionsBuilder<StudentDbContext>()
.UseSqlite("Data Source=StudentDb.db")
.Options;

using var context = new StudentDbContext(options);

if (!context.Students.Any()){
    context.Students.Add(new Student { Name = "Frank", Email = "Frank@Email.com" });
    context.Students.Add(new Student { Name = "Dilian", Email = "Dilian@Email.com" });
    context.SaveChanges();
    System.Console.WriteLine("Databasen är uppdaterad");
}

Console.WriteLine("Hämtar elever från DB:n \n");
var Students = context.Students.ToList();
foreach (var student in Students){
    Console.WriteLine(student.Name);
    Console.WriteLine(student.Email);
}