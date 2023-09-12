using Microsoft.AspNetCore.Identity;
using TransportathonApp.Domain.Entities.Common;

namespace TransportathonApp.Domain.Entities.Identity
{
    public class AppUserRole : IdentityRole<int>, IEntity
    {
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
