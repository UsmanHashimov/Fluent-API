using AutoMapper;
using TicketingSystem.Domain.Entities.DTOs;
using TicketingSystem.Domain.Entities.Models;
using TicketingSystem.Domain.Entities.ViewModels;

namespace TicketingSystem.Application.Mappers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<UserDTO, User>().ReverseMap();
            CreateMap<User, UserViewModel>().ReverseMap();
            CreateMap<IEnumerable<User>, IEnumerable<UserViewModel>>().ReverseMap();
            CreateMap<TicketDTO, Ticket>().ReverseMap();
        }
    }
}
