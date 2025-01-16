using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pr.Core.Models.Base;

namespace Pr.Core.Models;

public class Department: BaseAuditable
{
    public string Name { get; set; }
    public string ImgURL { get; set; }
    public ICollection<Doctor>? Doctors { get; set; }

}
