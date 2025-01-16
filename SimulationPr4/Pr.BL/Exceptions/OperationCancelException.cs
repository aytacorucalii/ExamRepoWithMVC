using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr.BL.Exceptions
{
    public class OperationCancelException: Exception
    {
        public OperationCancelException(string message): base(message) { }
       
    }
}
