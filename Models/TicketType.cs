namespace Deskbug.Models;

public class TicketType
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int TicketTypeStatus { get; set; }

    public TicketType(string name, int ticketTypeStatus)
    {
        Name = name;
        TicketTypeStatus = ticketTypeStatus;
    }

    public TicketType(int id, string name, int ticketTypeStatus)
    {
        Id = id;
        Name = name;
        TicketTypeStatus = ticketTypeStatus;
    }

}