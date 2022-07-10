global using System.ComponentModel.DataAnnotations;
global using Data.Enum;
global using Data.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Data;
public class FestivalContext: DbContext
{

    protected readonly IConfiguration Configuration;

    public FestivalContext(IConfiguration configuration)
    {
        Configuration = configuration;
    }


    public FestivalContext(DbContextOptions<FestivalContext> options)
       : base(options)
    {
    }

    public DbSet<Festival>? Festivals { get; set; }
    public DbSet<Ticket>? Tickets { get; set; }
    public DbSet<Person>? Persons { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(Configuration.GetConnectionString("FestivalDB"));
    }

}
