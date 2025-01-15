using Education.Core.Models.Base;

namespace Education.Core.Models
{
    public class Category : BaseAuditable
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public ICollection<News>? News { get; set; }

    }
}
