using AutoMapper;
using Exam.BL.DTOs;
using Exam.BL.DTOs;
using Exam.Core.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.BL.Profiles
{
    public class CarProfile : Profile
    {
        public CarProfile()
        {
            CreateMap<CarCreateDTO, Car>().ReverseMap();  
            CreateMap<CarUpdateDTO, Car>().ReverseMap();
            CreateMap<CarViewItemDTO, Car>().ReverseMap()
                .ForMember(x=>x.PersonName, c=>c.MapFrom(s=>s.Person.Name));
            CreateMap<CarListItemDTO, Car>().ReverseMap()
              .ForMember(x => x.PersonName, c => c.MapFrom(s => s.Person.Name));
        }
    }
    public class PersonProfile : Profile
    {
        public PersonProfile()
        {
            CreateMap<PersonCreateDTO, Person>().ReverseMap();
            CreateMap<PersonUpdateDTO, Person>().ReverseMap();
            CreateMap<PersonViewItemDTO, Person>().ReverseMap();
            CreateMap<PersonListItemDTO, Person>().ReverseMap();
        }
    }
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<IdentityUser, LoginDTO>().ReverseMap();
            CreateMap<IdentityUser, RegisterDTO>().ReverseMap();
        }
    }
}
