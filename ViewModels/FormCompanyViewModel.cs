namespace Deskbug.ViewModels;

public class FormCompanyViewModel
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string ShortName { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTime CreatedDate { get; set; }
    public int CompanyStatus { get; set; }
}