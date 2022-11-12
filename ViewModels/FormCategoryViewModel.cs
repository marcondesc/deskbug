namespace Deskbug.ViewModels;

public class FormCategoryViewModel
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int DisplayOrder { get; set; }
    public int CategoryLevel { get; set; }
    public int CategoryReference { get; set; }
    public DateTime CreatedDate { get; set; }
    public int CategoryStatus { get; set; }
}