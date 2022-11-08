namespace Deskbug.Models;

public class Project
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string ShortName { get; set; } = string.Empty;
    public string ProjectColor { get; set; } = string.Empty;
    public DateTime CreatedDate { get; set; }
    public int ProjectStatus { get; set; }

    public Project(string name, string shortName, string projectColor, DateTime createdDate, int projectStatus)
    {
        Name = name;
        ShortName = shortName;
        ProjectColor = projectColor;
        CreatedDate = createdDate;
        ProjectStatus = projectStatus;
    }

    public Project(int id, string name, string shortName, string projectColor, DateTime createdDate, int projectStatus)
    {
        Id = id;
        Name = name;
        ShortName = shortName;
        ProjectColor = projectColor;
        CreatedDate = createdDate;
        ProjectStatus = projectStatus;
    }

}