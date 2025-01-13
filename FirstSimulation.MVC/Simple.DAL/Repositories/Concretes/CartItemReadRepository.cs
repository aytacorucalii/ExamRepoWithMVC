
using Microsoft.EntityFrameworkCore;
using Simple.Core.Models;
using Simple.DAL.Contexts;
using Simple.DAL.Repositories.Abstractions;

namespace Simple.DAL.Repositories.Concretes;

public class CartItemReadRepository : ReadRepository<CartItem>, ICartItemReadReository
{
    public CartItemReadRepository(AppDbContext appDbContext) : base(appDbContext)
    {
    }
}
