namespace Exam.Core.Models
{
    public class Person: BaseEntity
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Position { get; set; }
                                              
        public ICollection<Car> Cars { get; set; }
    }
}
