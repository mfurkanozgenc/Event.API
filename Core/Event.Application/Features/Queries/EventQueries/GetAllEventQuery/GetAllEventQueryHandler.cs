using Event.Application.UnitOfWorks;
using Event.Domain.Entities;
using MediatR;

namespace Event.Application.Features.Queries.EventQueries.GetAllEventQuery
{
    public class GetAllEventQueryHandler : IRequestHandler<GetAllEventQueryRequest, List<GetAllEventQueryResponse>>
    {
        private readonly IUnitOfWork unitOfWork;

        public GetAllEventQueryHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<List<GetAllEventQueryResponse>> Handle(GetAllEventQueryRequest request, CancellationToken cancellationToken)
        {
            var events = await unitOfWork.GetReadRepository<Activity>().GetAllAsync();
            List<GetAllEventQueryResponse> response = new List<GetAllEventQueryResponse>();

            foreach (var item in events)
            {
                GetAllEventQueryResponse data = new()
                {
                    Desctription = item.Desctription,
                    EventDate = item.EventDate,
                    FinishTime = item.FinishTime,
                    StartTime = item.StartTime,
                    Id = item.Id,
                    IsFree = item.IsFree,
                    Price = item.Price,
                    UserId = item.UserId
                };
                response.Add(data);
            }
            return response;
        }
    }
}
