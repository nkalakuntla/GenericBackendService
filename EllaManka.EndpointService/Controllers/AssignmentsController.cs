using EllaManka.Contracts.Requests;
using EllaManka.Contracts.Responses;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace EllaManka.EndpointService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AssignmentsController : ControllerBase
    {
        private readonly IAssignmentsService _assignmentsService;

        public AssignmentsController(IAssignmentsService assignmentsService)
        {
            _assignmentsService = assignmentsService;
        }

        // GET /assignments?userId=...&day=...&month=...&year=...
        [HttpGet]
        public async Task<ActionResult<GetAssignmentsResponse>> GetAssignments(
            [FromQuery] Guid userId,
            [FromQuery] DateTime? day,
            [FromQuery] int? month,
            [FromQuery] int? year)
        {
            var request = new GetAssignmentsRequest
            {
                UserId = userId,
                Day = day,
                Month = month,
                Year = year
            };

            var response = await _assignmentsService.GetAssignmentsAsync(request);

            return Ok(response);
        }
    }

    // The following interface should be implemented in the application/infrastructure layer.
    public interface IAssignmentsService
    {
        Task<GetAssignmentsResponse> GetAssignmentsAsync(GetAssignmentsRequest request);
    }
}