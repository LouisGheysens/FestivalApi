namespace Data.Model;
public class Person
{
    [Key]
    public Guid Id { get; set; }

    public string FullName { get; set; } = null!;
    public bool IsDeleted { get; set; } = false;

    public virtual ICollection<Ticket> Tickets { get; set; } = null!;
}
