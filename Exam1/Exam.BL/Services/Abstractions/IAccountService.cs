using Exam.BL.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.BL.Services.Abstractions
{
    public interface IAccountService
    {
        Task RegisterAsync(RegisterDTO dto);
        Task LoginAsync(LoginDTO dto);
        Task Logout();
    }
}
