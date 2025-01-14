using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plumberz.BL.Exceptions;

public class EntityNotFoundExcepion : Exception
{
    public EntityNotFoundExcepion(string message) : base(message) { }
    public EntityNotFoundExcepion() : base("Entity not found") { }
}
