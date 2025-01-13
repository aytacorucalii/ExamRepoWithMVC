using Simple.Core.Models.Base;

namespace Simple.Core.Models;

public class CartItem:BaseEntity
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string ImgPath {  get; set; }     
}
