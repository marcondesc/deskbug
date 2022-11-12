namespace Deskbug.Models;

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int DisplayOrder { get; set; }
    public int CategoryLevel { get; set; }
    public int CategoryReference { get; set; }
    public DateTime CreatedDate { get; set; }
    public int CategoryStatus { get; set; }

    public Category(string name, int displayOrder, int categoryLevel, int categoryReference, DateTime createdDate, int categoryStatus)
    {
        Name = name;
        DisplayOrder = displayOrder;
        CategoryLevel = categoryLevel;
        CategoryReference = categoryReference;
        CreatedDate = createdDate;
        CategoryStatus = categoryStatus;
    }

    public Category(int id, string name, int displayOrder, int categoryLevel, int categoryReference, DateTime createdDate, int categoryStatus)
    {
        Id = id;
        Name = name;
        DisplayOrder = displayOrder;
        CategoryLevel = categoryLevel;
        CategoryReference = categoryReference;
        CreatedDate = createdDate;
        CategoryStatus = categoryStatus;
    }

}