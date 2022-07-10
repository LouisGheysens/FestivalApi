namespace Data.Model;
public class Festival
{
    [Key]
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public string Location { get; set; } = null!;

    public DateTime Created { get; set; }

    public DateTime Updated { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public bool IsDeleted { get; set; } = false;

    public virtual ICollection<Ticket> Tickets { get; set; } = null!;

}
