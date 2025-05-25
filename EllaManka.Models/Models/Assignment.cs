namespace EllaManka.EndpointService.Models
{
    public class Assignment
    {namespace EllaManka.EndpointService.Models
{
    public class Assignment
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int TaskId { get; set; }
        public double Duration { get; set; }
        public string Currency { get; set; }
        public decimal Total { get; set; }
        public DateTime AssignmentDate { get; set; }
        public DateTime DueDate { get; set; }
        public string Status { get; set; }
    }
}
    }
}