using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Education.BL.DTOs.NewsDTOs
{
    public class NewsCreateDTO
    {
       
        public string Title { get; set; }
        public string Description { get; set; }
        public IFormFile Img { get; set; }
        public int CategoryId { get; set; }
    }
}
