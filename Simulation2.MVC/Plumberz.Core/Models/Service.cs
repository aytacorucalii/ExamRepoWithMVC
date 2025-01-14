using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plumberz.Core.Models.Base;

namespace Plumberz.Core.Models
{
    public class Service : BaseAuditable
    {
        public string  Title { get; set; }
        public string Description { get; set; }
        public string About { get; set; }
        public ICollection<Technician>? Technicians { get; set; }
    }
}
