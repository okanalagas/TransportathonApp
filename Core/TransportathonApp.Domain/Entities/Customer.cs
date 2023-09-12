using TransportathonApp.Domain.Entities.Common;
using TransportathonApp.Domain.Entities.Identity;

namespace TransportathonApp.Domain.Entities;

public class Customer : BaseEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public long IdentityNo { get; set; }
    public string Address { get; set; }
    public virtual AppUser User { get; set; }
    public ICollection<Review> Reviews { get; set; }
    public ICollection<TransportationRequest> TransportationRequests { get; set; }
    public ICollection<Reservation> Reservations { get; set; }
}
