using System;

namespace EllaManka.Contracts.Requests
{
    public class GetAssignmentsRequest
    {
        public Guid UserId { get; set; }
        public DateTime? Day { get; set; }
        public int? Month { get; set; } // 1-12
        public int? Year { get; set; }
    }
}