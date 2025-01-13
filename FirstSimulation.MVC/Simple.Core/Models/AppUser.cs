using Microsoft.AspNetCore.Identity;

namespace Simple.Core.Models;

public class AppUser: IdentityUser
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    
}
