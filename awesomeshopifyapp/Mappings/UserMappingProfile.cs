using AutoMapper;
using awesomeshopifyapp.Model;
using awesomeshopifyapp.Model.FacebookModel;

namespace awesomeshopifyapp.Mappings
{
    public class UserMappingProfile : Profile
    {
        public UserMappingProfile()
        {
            CreateMap<User, FbUser>()
                .ForMember(dst => dst.User, opt => opt
                    .MapFrom(src => src.Name))
                .ForMember(dst => dst.Mail, opt => opt
                    .MapFrom(src => src.Email))
                .ForMember(dst => dst.LastName, opt => opt
                    .MapFrom(src => src.Surname))
                .ReverseMap()
                .ForMember(dst => dst.Name, opt => opt
                    .MapFrom(src => src.User))
                .ForMember(dst => dst.Email, opt => opt
                    .MapFrom(src => src.Mail))
                .ForMember(dst => dst.Surname, opt => opt
                    .MapFrom(src => src.LastName));
        }
    }
}
