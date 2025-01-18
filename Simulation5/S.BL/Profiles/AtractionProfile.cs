using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using S.BL.DTOs.AtractionDTOs;
using S.Core.Models;

namespace S.BL.Profiles
{
    public class AtractionProfile : Profile
    {
        public AtractionProfile()
        {
            CreateMap<Atraction, AtractionCreateDTO>().ReverseMap();
            CreateMap<Atraction, AtractionUpdateDTO>().ReverseMap();
        }
    }
}
