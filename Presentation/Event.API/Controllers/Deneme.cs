using Event.Application.Features.Queries.EventQueries.GetAllEventQuery;
using Event.Application.UnitOfWorks;
using Event.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Event.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class Deneme : ControllerBase
    {
        private readonly IMediator _mediator;

        public Deneme(IMediator mediator)
        {
            _mediator = mediator;
        }

        //[HttpPost]
        //public async Task<IActionResult> CreateUser(string firstName,string lastName)
        //{
        //    User newUser = new()
        //    {
        //        FirstName = firstName,
        //        LastName = lastName
        //    };
        //    await unitOfWork.GetWriteRepository<User>().AddAsync(newUser);
        //    await unitOfWork.SaveAsync();
        //    return Ok();
        //}

        [HttpGet]
        public async Task<IActionResult> GetAllUser()
        {
            var result = await _mediator.Send(new GetAllEventQueryRequest());
            return Ok(result);
        }
    }
}
