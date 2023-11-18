using AutoMapper;
using Lab1.Contracts.Data.Entities;
using Lab1.Contracts.DTO.Authentications;
namespace LabWebAPI.Services.Mapper
{
    public class ApplicationProfile : Profile
    {
        public ApplicationProfile()
        {
            CreateMap<UserRegistrationDTO, User>();
        }
    }
}