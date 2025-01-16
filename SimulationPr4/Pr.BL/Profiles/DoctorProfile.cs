using AutoMapper;
using Pr.BL.DTOs.DoctorDTOs;
using Pr.Core.Models;

namespace Pr.BL.Profiles
{
    public class DoctorProfile: Profile
    {
        public DoctorProfile()
        {
            CreateMap<Doctor, DoctorCreateDTO>().ReverseMap();
            CreateMap<Doctor, DoctorUpdateDTO>().ReverseMap();
        }
    }
}
