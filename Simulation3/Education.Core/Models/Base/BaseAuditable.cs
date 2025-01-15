namespace Education.Core.Models.Base;

public class BaseAuditable: BaseEntity
{
    public string CreatedBy {  get; set; }
    public string? UpdatedBy { get; set; }
    public string? DeletedBy { get; set; }
    public DateTime? CreatedDate { get; set; }
    public DateTime? UpdatedDate { get; set; }
    public DateTime? DeleteDate { get; set; }
}
