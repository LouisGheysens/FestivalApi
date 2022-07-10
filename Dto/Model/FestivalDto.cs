using Data.Model;

namespace Dto.Model;
public class FestivalDto
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public string Location { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public List<TicketDto> Tickets { get; set; } = null!;
}
