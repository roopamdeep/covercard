namespace CoverCard.Api.Models
{
    public class Policy
    {
        public int Id { get; set; }
        public string PolicyNumber { get; set; }
        public string InsurerName { get; set; }
        public string VehicleInfo { get; set; }
        public DateTime CoverageStartDate { get; set; }
        public DateTime CoverageEndDate { get; set; }
        public string DocumentUrl { get; set; }
        public string Status { get; set; }

        public string BrokerId { get; set; }
        public Broker Owner { get; set; }

        public int CustomerId { get; set; }
        public Customer Recipient { get; set; }
    }
}