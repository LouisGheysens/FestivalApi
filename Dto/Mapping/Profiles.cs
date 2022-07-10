using AutoMapper;
using Dto.Model;
using Data.Model;

namespace Dto.Mapping;
public class Profiles: Profile
{
    public Profiles()
    {
        CreateMap<Festival, FestivalDto>().ForMember(x => x.Tickets,
            x => x.MapFrom(x => x.Tickets
            .Select(x => x.TicketNumber)))
            .ReverseMap();
        CreateMap<Person, PersonDto>().
            ForMember(x => x.Tickets, 
            x => x.MapFrom(x => x.Tickets
            .Select(x => x.TicketNumber)))
            .ReverseMap();
        CreateMap<Ticket, TicketDto>().ForMember
            (x => x.PersonName, x => x.MapFrom(x => x
            .Person.FullName))
            .ForMember(x => x.FestivalName, x => x.MapFrom
            (x => x.Festival.Name)).ReverseMap();
    }
}
