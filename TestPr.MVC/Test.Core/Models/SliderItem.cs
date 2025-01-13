using Test.Core.Entities.Base;

namespace Test.Core.Entities;

public class SliderItem : BaseEntity
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string Button {  get; set; }
    public string ImagUrl { get; set; }
}
