using BlogApp.Domain.Entities.Common;

namespace BlogApp.Domain.Entities;

public class Blog : BaseEntity, IBaseAudiTable
{
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime CreateTime {  get; set; }
    public DateTime? ModifyTime {  get; set; }
    public string? ModifiedBy {  get; set; }
}
