namespace Dto.Model;
public class TicketDto
{
    public Guid Id { get; set; }
    public int TicketNumber { get; set; }

    public decimal Price { get; set; }
    public int PersonId { get; set; }

    public int FestivalId { get; set; }

    public string? PersonName { get; set; }

    public string? FestivalName { get; set; }
}
