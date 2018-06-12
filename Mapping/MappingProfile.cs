using AutoMapper;
using PeopleSearch.Controllers.Resources;
using PeopleSearch.Models;

namespace PeopleSearch.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Domain to API resource
            CreateMap<Person, PersonResource>();
            CreateMap<Interest, InterestResource>();
            CreateMap<Picture, PictureResource>();
        }
    }
}