using Event.Domain.Comman;

namespace Event.Domain.Entities
{
    public class User : BaseEntity
    {
        public  string FirstName { get; set; }
        public  string LastName { get; set; }
        public  string? PhoneNumber { get; set; }
        public  string? IdentificationNumber { get; set; }
        public  int? Gender { get; set; }
        public ICollection<Activity>? Events { get; set; }
    }
}
