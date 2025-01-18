using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using S.Core.Models;

namespace S.BL.DTOs.CategoryDTOs
{
    public class CategoryCreateDTO
    {
        public bool IsDeleted { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public IFormFile Img { get; set; }
        public ICollection<Atraction>? Atractions { get; set; }
    }
}
