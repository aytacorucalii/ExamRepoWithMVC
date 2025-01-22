using Exam.BL.DTOs;

namespace Exam1.MVC.ViewModel
{
    public class HomeVM
    {
       public ICollection<PersonViewItemDTO> Persons { get; set; }
        public ICollection<CarViewItemDTO> Cars { get; set; }

    }
}
