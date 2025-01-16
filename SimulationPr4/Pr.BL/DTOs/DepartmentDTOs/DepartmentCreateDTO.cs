using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Pr.Core.Models;

namespace Pr.BL.DTOs.DepartmentDTOs
{
    public class DepartmentCreateDTO
    {
        public string Name { get; set; }
        public string ImgURL { get; set; }
        public IFormFile Image { get; set; }
        public ICollection<Doctor>? Doctors { get; set; }
    }
    public class DepartmentUpdateDTO
    {
        public int id { get; set; }
        public string Name { get; set; }
        public IFormFile Image { get; set; }
        public ICollection<Doctor>? Doctors { get; set; }
    }
}
