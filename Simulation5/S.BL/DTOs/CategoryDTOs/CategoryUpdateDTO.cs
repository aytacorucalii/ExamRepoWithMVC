using Microsoft.AspNetCore.Http;
using S.Core.Models;

namespace S.BL.DTOs.CategoryDTOs
{
    public class CategoryUpdateDTO
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public IFormFile Img { get; set; }
        public ICollection<Atraction>? Atractions { get; set; }
    }
}
