using Simple.BL.DTOs.Cart;
using Simple.Core.Models;

namespace Simple.BL.Services.Abstractions;

public interface ICartItemService
{
    Task<CartItem> CreateAsync(CartDTO entityDTO);
    Task<bool> Update(int id,CartDTO entityDTO);
    Task<bool> SoftDeleteAsync(int id);
}
