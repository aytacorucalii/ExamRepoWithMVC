using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Pr.BL.DTOs.DoctorDTOs
{
    public class DoctorCreateDTO
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public int DepartmentId { get; set; }
        public IFormFile Image { get; set; }

    }

    public class DoctorUpdateDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public int DepartmentId { get; set; }
        public IFormFile Image { get; set; }
    }
}
