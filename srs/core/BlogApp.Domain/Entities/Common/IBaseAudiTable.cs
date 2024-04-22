namespace BlogApp.Domain.Entities.Common
{
    public interface IBaseAudiTable
    {
        public DateTime CreateTime { get; set; }
        public DateTime? ModifyTime { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
