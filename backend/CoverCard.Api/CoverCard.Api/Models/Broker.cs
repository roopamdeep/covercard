using Microsoft.AspNetCore.Identity;

namespace CoverCard.Api.Models
{
    public class Broker : IdentityUser
    {
        public string FullName { get; set; }
    }
}
