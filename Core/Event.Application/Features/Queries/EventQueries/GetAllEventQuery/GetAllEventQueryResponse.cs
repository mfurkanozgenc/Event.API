namespace Event.Application.Features.Queries.EventQueries.GetAllEventQuery
{
    public class GetAllEventQueryResponse
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string Desctription { get; set; }
        public bool IsFree { get; set; }
        public decimal Price { get; set; }
        public DateOnly EventDate { get; set; }
        public TimeOnly StartTime { get; set; } 
        public TimeOnly FinishTime { get; set; }
    }
}
