using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Microsoft.Identity.Client;
using Pr.Core.Models;

namespace Pr.BL.Validations.Departments
{
    public class DepartmentValidation : AbstractValidator<Department>
    {
        public DepartmentValidation()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("please enter a Name");
          
        }
    }
}
