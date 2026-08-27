namespace CoverCard.Api.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }

        public string BrokerId { get; set; }
        public Broker Agent { get; set; }
    }
}