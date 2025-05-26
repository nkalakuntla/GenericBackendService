using System;

namespace EllaManka.Contracts.Responses
{
    public class AssignmentDto
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime AssignedDate { get; set; }
        public DateTime? DueDate { get; set; }
        // Add other relevant properties from your Assignment model as needed
    }
}