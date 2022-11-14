using Deskbug.Models;

namespace Deskbug.ViewModels;

public class ListTicketTypeViewModel
{
    public ICollection<TicketType> TicketTypes { get; set; } = new List<TicketType>();
}