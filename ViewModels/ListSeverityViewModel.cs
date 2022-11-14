using Deskbug.Models;

namespace Deskbug.ViewModels;

public class ListSeverityViewModel
{
    public ICollection<Severity> Severities { get; set; } = new List<Severity>();
}