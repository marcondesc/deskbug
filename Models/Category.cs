namespace Deskbug.Models;

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int DisplayOrder { get; set; }
    public DateTime CreatedDate { get; set; }
    public int CategoryStatus { get; set; }

    public Category(string name, int displayOrder, DateTime createdDate, int categoryStatus)
    {
        Name = name;
        DisplayOrder = displayOrder;
        CreatedDate = createdDate;
        CategoryStatus = categoryStatus;
    }

    public Category(int id, string name, int displayOrder, DateTime createdDate, int categoryStatus)
    {
        Id = id;
        Name = name;
        DisplayOrder = displayOrder;
        CreatedDate = createdDate;
        CategoryStatus = categoryStatus;
    }

}