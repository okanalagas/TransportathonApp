using Microsoft.AspNetCore.Identity;
using TransportathonApp.Domain.Entities.Common;

namespace TransportathonApp.Domain.Entities.Identity;

public class AppUser : IdentityUser<int>, IEntity
{
    public DateTime CreatedDate { get; set; } = DateTime.Now;
    public DateTime? UpdatedDate { get; set; }
    public virtual Customer Customer { get; set; }
    public virtual CompanyExecutive CompanyExecutive { get; set; }
    //public virtual TransportationTeamLeader? TransportationTeamLeader { get; set; }
}
