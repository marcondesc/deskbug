using Deskbug.Models;

namespace Deskbug.ViewModels;

public class ListPriorityViewModel
{
    public ICollection<Priority> Priorities { get; set; } = new List<Priority>();
}