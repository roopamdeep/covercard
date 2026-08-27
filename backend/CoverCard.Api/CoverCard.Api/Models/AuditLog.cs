namespace CoverCard.Api.Models
{
    public class AuditLog
    {
        public int Id { get; set; }

        public int PolicyId { get; set; }
        public Policy Policy { get; set; }

        public string Action { get; set; }
        public DateTime Timestamp { get; set; }
        public string PerformedBy { get; set; }
    }
}