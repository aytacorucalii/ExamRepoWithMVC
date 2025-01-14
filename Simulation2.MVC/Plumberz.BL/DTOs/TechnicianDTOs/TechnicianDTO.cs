using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Plumberz.BL.DTOs.TechnicianDTOs;

public class TechnicianDTO
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Position { get; set; }
    public IFormFile Image { get; set; }
    public int ServiceId { get; set; }

}
