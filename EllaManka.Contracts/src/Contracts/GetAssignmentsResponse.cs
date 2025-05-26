using System.Collections.Generic;

namespace EllaManka.Contracts.Responses
{
    public class GetAssignmentsResponse
    {
        public List<AssignmentDto> Assignments { get; set; }
    }
}