namespace Deskbug.Models;

public class Severity
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int Grade { get; set; }

    public Severity(string name, int grade)
    {
        Name = name;
        Grade = grade;
    }

    public Severity(int id, string name, int grade)
    {
        Id = id;
        Name = name;
        Grade = grade;
    }
}