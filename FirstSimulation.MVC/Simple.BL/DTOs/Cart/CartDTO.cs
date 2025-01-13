using Microsoft.AspNetCore.Http;

namespace Simple.BL.DTOs.Cart;

public class CartDTO
{
    public string Title { get; set; }
    public string Description { get; set; }
    public  IFormFile Image {  get; set; }

}
