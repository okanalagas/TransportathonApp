using Microsoft.AspNetCore.Identity;

namespace TransportathonApp.Domain.Entities.Identity;

public class AppUser : IdentityUser<string>
{
    public ICollection<TransportationRequest> TransportationRequests { get; set; }
    public ICollection<Review> Reviews { get; set; }
}
