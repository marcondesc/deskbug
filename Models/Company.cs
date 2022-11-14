namespace Deskbug.Models;

public class Company
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string ShortName { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTime CreatedDate { get; set; }
    public int CompanyStatus { get; set; }

    public Company(string name, string shortName, string description, DateTime createdDate, int companyStatus)
    {
        Name = name;
        ShortName = shortName;
        Description = description;
        CreatedDate = createdDate;
        CompanyStatus = companyStatus;
    }

    public Company(int id, string name, string shortName, string description, DateTime createdDate, int companyStatus)
    {
        Id = id;
        Name = name;
        ShortName = shortName;
        Description = description;
        CreatedDate = createdDate;
        CompanyStatus = companyStatus;
    }
}