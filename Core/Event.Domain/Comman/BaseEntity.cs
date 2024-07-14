namespace Event.Domain.Comman
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime CanceledDate { get; set; }
        public BaseEntity()
        {
            Id = Guid.NewGuid();
        }
    }
}
