using Simple.Core.Models;
using Simple.DAL.Contexts;
using Simple.DAL.Repositories.Abstractions;

namespace Simple.DAL.Repositories.Concretes;

public class CartItemWriteRepository : WriteRepository<CartItem>, ICartItemWriteReository
{
    public CartItemWriteRepository(AppDbContext appDbContext) : base(appDbContext)
    {
    }
}