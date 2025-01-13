using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Simple.Core.Models;

namespace Simple.DAL.Configurations.CartItems;

public class CartItemConfiguration: IEntityTypeConfiguration<CartItem>
{

    public void Configure(EntityTypeBuilder<CartItem> builder)
    {
        builder.HasKey(x => x.Id);
    }
}

