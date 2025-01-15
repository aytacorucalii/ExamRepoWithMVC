using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Simple.BL.DTOs.Cart;
using Simple.BL.Services.Abstractions;
using Simple.Core.Models;
using Simple.DAL.Repositories.Abstractions;

namespace Simple.BL.Services.Concretes;
//https://www.free-css.com/free-css-templates/page292/plumberz
public class CartItemService : ICartItemService
{
    private readonly ICartItemWriteReository _cartItemWriteReository;
    private readonly ICartItemReadReository _cartReadRepository;
    private readonly IMapper _mapper;
    private readonly IWebHostEnvironment _webHostEnvironment;
    public CartItemService(ICartItemWriteReository cartItemWriteReository, IMapper mapper, ICartItemReadReository cartReadRepository)
    {
        _cartItemWriteReository = cartItemWriteReository;
        _mapper = mapper;
        _cartReadRepository = cartReadRepository;
    }

    public async Task<CartItem> CreateAsync(CartDTO entityDTO)
    {
        CartItem cartItem = _mapper.Map<CartItem>(entityDTO);
        string root = _webHostEnvironment.WebRootPath;
        string fileName = entityDTO.Image.FileName;
        string filePath = root + "/uploads/carditem/" + fileName;

        using (FileStream stream = new FileStream(filePath.Replace("\\", "/"), FileMode.Create))
        {
            await entityDTO.Image.CopyToAsync(stream);
        }
        entityDTO.ImageURL = fileName;
        var entity = await _cartItemWriteReository.CreateAsync(cartItem);
        await _cartItemWriteReository.SaveChangesAsync();
        return entity;
    }

    public async Task<bool> SoftDeleteAsync(int id)
    {
        var entity = await _cartReadRepository.GetByIdAsync(id);
        _cartItemWriteReository.SoftDelete(entity);
        await _cartItemWriteReository.SaveChangesAsync();
        return true;
    }

    public async Task<bool> Update(int id, CartDTO entityDTO)
    {
        var entity = await _cartReadRepository.GetByIdAsync(id);
        CartItem cartItem = _mapper.Map<CartItem>(entityDTO);
        entity.Id = id;
        _cartItemWriteReository.Update(entity);
        await _cartItemWriteReository.SaveChangesAsync();
        return true;
        
    }
}
