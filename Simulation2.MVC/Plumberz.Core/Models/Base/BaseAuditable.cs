using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plumberz.Core.Models.Base
{
    public class BaseAuditable : BaseEntity
    {
        public string CreatedBy { get; set; }
        public string? UpdateBy { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}
