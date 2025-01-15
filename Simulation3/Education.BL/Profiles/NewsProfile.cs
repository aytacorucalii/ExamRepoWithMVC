using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Education.BL.DTOs.NewsDTOs;
using Education.Core.Models;

namespace Education.BL.Profiles
{
    public class NewsProfile:Profile
    {
        public NewsProfile()
        {
            CreateMap<News, NewsCreateDTO>().ReverseMap();
        }
        
    }
}
