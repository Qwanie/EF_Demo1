using System;
using EF_Demo1.Models;

namespace EF_Demo1;

public class Course
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int Year { get; set; }
    public int SchoolId { get; set; }
    public School School { get; set; } = null!;
}
