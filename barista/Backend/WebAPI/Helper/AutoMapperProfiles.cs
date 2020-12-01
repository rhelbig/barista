using AutoMapper;
using WebAPI.Models;
using WebAPI.Dtos;
using WebAPI.Dtos.User;
using WebAPI.Drinks;

namespace WebAPI.Helper
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles(){
            CreateMap<UserModel, RegisterUserDto>().ReverseMap();
            CreateMap<UserModel, UserDto>().ReverseMap();
            CreateMap<UserModel, UserLoginDto>().ReverseMap();
            CreateMap<DrinkModel, DrinkDto>().ReverseMap();
        }
    }
}