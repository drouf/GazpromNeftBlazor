using AutoMapper;
using GazpromNeftBlazor.DTO;
using GazpromNeftBlazor.ViewModels;

namespace GazpromNeftBlazorWebApp
{
    public class AppMappingProfile : Profile
    {
        public AppMappingProfile()
        {
            CreateMap<UserDto, IndexUserModel> ();
        }
    }
}
