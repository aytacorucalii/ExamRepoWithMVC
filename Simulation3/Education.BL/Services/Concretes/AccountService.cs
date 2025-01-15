using Education.BL.DTOs.AccountDTOs;
using Education.BL.Services.Abstractions;

namespace Education.BL.Services.Concretes
{
    public class AccountService : IAccountService
    {
        private readonly IAccountService _accountService;

        public AccountService(IAccountService accountService)
        {
            _accountService = accountService;
        }

        public Task LoginAsync(LoginDTO user)
        {
            throw new NotImplementedException();
        }


        public Task LogoutAsync()
        {
            throw new NotImplementedException();
        }

        public Task RegisterAsync(RegisterDTO user)
        {
            throw new NotImplementedException();
        }
    }
}
