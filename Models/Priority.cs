namespace Deskbug.Models;

public class Priority
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int Grade { get; set; }

    public Priority(string name, int grade)
    {
        Name = name;
        Grade = grade;
    }

    public Priority(int id, string name, int grade)
    {
        Id = id;
        Name = name;
        Grade = grade;
    }

}