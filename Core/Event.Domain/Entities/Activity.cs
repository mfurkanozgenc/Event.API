using Event.Domain.Comman;

namespace Event.Domain.Entities
{
    public class Activity : BaseEntity
    {
        public Guid UserId { get; set; }
        public User CreatUser { get; set; }
        public string Desctription { get; set; }
        public bool IsFree { get; set; }
        public decimal Price { get; set; }
        public DateOnly EventDate { get; set; } // Etkilnlik Günü
        public TimeOnly StartTime { get; set; } // Başlangıç Saati
        public TimeOnly FinishTime { get; set; } // Bitiş Saati
    }
}
