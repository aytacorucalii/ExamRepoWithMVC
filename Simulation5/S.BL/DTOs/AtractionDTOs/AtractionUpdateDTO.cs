using Microsoft.AspNetCore.Http;
using S.Core.Models;

namespace S.BL.DTOs.AtractionDTOs
{
    public class AtractionUpdateDTO
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public IFormFile Img { get; set; }
        public float Reiting { get; set; }
        public int ReitingCounts { get; set; }
        public decimal MinPrice { get; set; }
        public decimal MaxPrice { get; set; }
        public bool IsActive { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}
