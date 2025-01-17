namespace S.Core.Models
{
    public class Category: BaseEntity
    {
       public string Title { get; set; }
       public string Description { get; set; }
       public string ImgUrl { get; set; }
       public ICollection<Atraction>? Atractions { get; set; }

    }
}
