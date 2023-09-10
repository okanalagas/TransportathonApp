using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportathonApp.Domain.Entities.Common;

namespace TransportathonApp.Domain.Entities;

public class Driver: BaseEntity
{
    [Required]
    public string FirstName { get; set; }

    [Required]
    public string LastName { get; set; }

    public string LicenseNumber { get; set; }

    public Guid CompanyId { get; set; }
    public Company Company { get; set; }
}
