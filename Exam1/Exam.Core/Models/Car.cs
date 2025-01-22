namespace Exam.Core.Models
{
    public class Car: BaseEntity
    {
        public string Name { get; set; }
        public decimal Price {  get; set; }
        public float RountCount { get; set; }
        public string ImgUrl { get; set; }
        public int Personİd {  get; set; }
        public Person Person { get; set; }
    }
}
