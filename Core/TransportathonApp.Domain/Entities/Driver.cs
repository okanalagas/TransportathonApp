﻿using TransportathonApp.Domain.Entities.Common;

namespace TransportathonApp.Domain.Entities;

public class Driver : BaseEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string LicenseNumber { get; set; }
    public DateTime EmploymentStartDate { get; set; }
    public int CompanyId { get; set; }
    public virtual Company Company { get; set; }
    public virtual ICollection<TransportationOffer> TransportationOffers { get; set; }
}
