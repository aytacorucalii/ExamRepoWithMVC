using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.BL.Exceptions
{
    public class BaseException: Exception
    {
        public BaseException( string Message): base(Message) { }
        public BaseException(): base("Something went wrong!"){}
        
    }
}
