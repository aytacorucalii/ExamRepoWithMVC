using AutoMapper;
using Plumberz.BL.DTOs.TechnicianDTOs;
using Plumberz.Core.Models;

namespace Plumberz.BL.Profiles;

public class TechnicianProfile :Profile
{
    public TechnicianProfile()
    {
        CreateMap<Technician, TechnicianDTO>().ReverseMap();
    }
}
