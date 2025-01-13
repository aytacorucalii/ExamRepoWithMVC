using Simple.Core.Models.Base;

namespace Simple.Core.Models;

public class ContactUs:BaseEntity
{
    public string  Name { get; set; }
    public string Email { get; set; }
    public string Subject { get; set; }
    public string Message { get; set; }
}
