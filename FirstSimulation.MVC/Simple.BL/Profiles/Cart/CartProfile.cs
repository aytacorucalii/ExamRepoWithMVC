using AutoMapper;
using Simple.BL.DTOs.Cart;
using Simple.Core.Models;

namespace Simple.BL.Profiles.Cart;

public class CartProfile : Profile
{
    public CartProfile()
    {
        CreateMap<CartItem,CartDTO>().ReverseMap();
    }
}
