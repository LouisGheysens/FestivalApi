namespace Data.Model;
public class Ticket
{
    [Key]
    public Guid Id { get; set; }

    public DateTime Created { get; set; }

    public DateTime Updated { get; set; }

    public int TicketNumber { get; set; }

    public decimal Price { get; set; }
    public int PersonId { get; set; }

    public int FestivalId { get; set; }
    public bool IsDeleted { get; set; } = false;

    public TicketType TicketType { get; set; } = TicketType.Standard;

    public virtual Person Person { get; set; } = null!;
    public virtual Festival Festival { get; set; } = null!;
}
