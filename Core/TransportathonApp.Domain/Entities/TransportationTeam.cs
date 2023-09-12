using TransportathonApp.Domain.Entities.Common;

namespace TransportathonApp.Domain.Entities;

public class TransportationTeam : BaseEntity
{
    public string TeamName { get; set; }
    //public int TransportationTeamLeaderId { get; set; } 
    //public TransportationTeamLeader TransportationTeamLeader { get; set; }
    public int StaffCount { get; set; }
    public DateTime EmploymentStartDate { get; set; }
    //public int? ReviewId { get; set; }
    //public Review Review { get; set; }
    public int CompanyId { get; set; }
    public virtual Company Company { get; set; }
    public virtual ICollection<TransportationOffer> TransportationOffers { get; set; }

}
