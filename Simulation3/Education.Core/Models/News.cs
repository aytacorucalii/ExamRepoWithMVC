using Education.Core.Models.Base;

namespace Education.Core.Models
{
    public class News: BaseAuditable
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImgUrl { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
