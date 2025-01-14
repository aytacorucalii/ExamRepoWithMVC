using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plumberz.Core.Models.Base;

namespace Plumberz.Core.Models
{
    public class Technician: BaseAuditable
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string ImgUrl { get; set; }
        public string Position { get; set; }
        public int ServiceId { get; set; }
        public Service? Service { get; set; }
    }
}
