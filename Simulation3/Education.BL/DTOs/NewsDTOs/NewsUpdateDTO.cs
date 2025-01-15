using Microsoft.AspNetCore.Http;

namespace Education.BL.DTOs.NewsDTOs
{
    public class NewsUpdateDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public IFormFile Img { get; set; }
        public int CategoryId { get; set; }
    }
}
