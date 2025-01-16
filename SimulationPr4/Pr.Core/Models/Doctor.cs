using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pr.Core.Models.Base;

namespace Pr.Core.Models
{
    public class Doctor : BaseAuditable
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public string ImgURL { get; set; }
    }
}
