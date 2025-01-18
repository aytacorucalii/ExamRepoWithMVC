namespace S.Core.Models
{
    public class Atraction: BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImgUrl { get; set; }
        public float Reiting {  get; set; }
        public int ReitingCounts { get; set; }
        public decimal MinPrice { get; set; }
        public decimal MaxPrice { get; set; }
        public bool IsActive { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; }

    }
}
