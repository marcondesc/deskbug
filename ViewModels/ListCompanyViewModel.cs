using Deskbug.Models;

namespace Deskbug.ViewModels;

public class ListCompanyViewModel
{
    public ICollection<Company> Companies { get; set; } = new List<Company>();
}