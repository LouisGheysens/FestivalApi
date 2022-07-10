namespace Dto.Model;
public class PersonDto
{
    public Guid Id { get; set; }

    public string FullName { get; set; } = null!;

    public List<TicketDto> Tickets { get; set; } = null!;
}
