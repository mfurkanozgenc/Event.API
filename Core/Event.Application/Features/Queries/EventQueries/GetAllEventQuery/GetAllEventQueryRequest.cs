using MediatR;

namespace Event.Application.Features.Queries.EventQueries.GetAllEventQuery
{
    public class GetAllEventQueryRequest : IRequest<List<GetAllEventQueryResponse>>
    {
    }
}
