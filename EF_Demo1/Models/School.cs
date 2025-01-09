using System;

namespace EF_Demo1.Models;

public class School
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Adress { get; set; }
    public ICollection<Student>? Students { get; set; }
}
