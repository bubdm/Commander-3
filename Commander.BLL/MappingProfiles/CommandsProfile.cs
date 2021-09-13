using AutoMapper;
using Commander.BLL.ModelsDTO;
using Commander.DAL.Models;

namespace Commander.BLL.MappingProfiles
{
    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {
            CreateMap<Command, CommandReadDTO>();
        }
    }
}