using TransportathonApp.Domain.Entities.Common;
using TransportathonApp.Domain.Entities.Identity;

namespace TransportathonApp.Domain.Entities;

public class CompanyExecutive : BaseEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public virtual AppUser User { get; set; }
    public int CompanyId { get; set; }
    public virtual Company Company { get; set; }
}
