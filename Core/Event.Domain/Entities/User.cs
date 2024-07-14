using Event.Domain.Comman;

namespace Event.Domain.Entities
{
    public class User : BaseEntity
    {
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string PhoneNumber { get; set; }
        public required string IdentificationNumber { get; set; }
        public required int Gender { get; set; }
        public ICollection<Activity>? Events { get; set; }
    }
}
