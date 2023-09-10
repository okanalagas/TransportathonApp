using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using TransportathonApp.Domain.Entities;
using TransportathonApp.Domain.Entities.Common;
using TransportathonApp.Domain.Entities.Identity;

namespace TransportathonApp.Persistence.Contexts;

public class TransportathonAppDbContext : IdentityDbContext<AppUser, AppUserRole, string>
{
    public TransportathonAppDbContext(DbContextOptions options) : base(options)
    {

    }

    public DbSet<Company> Companies { get; set; }
    public DbSet<Driver> Drivers { get; set; }
    public DbSet<Message> Messages { get; set; }
    public DbSet<Reservation> Reservations { get; set; }
    public DbSet<Review> Reviews { get; set; }
    public DbSet<TransportationRequest> TransportationRequests { get; set; }
    public DbSet<Vehicle> Vehicles { get; set; }

    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        var entityEntries = ChangeTracker.Entries<BaseEntity>();

        foreach (var entityEntry in entityEntries)
        {
            _ = entityEntry.State switch
            {
                EntityState.Added => entityEntry.Entity.CreatedDate = DateTime.Now,
                EntityState.Modified => entityEntry.Entity.UpdatedDate = DateTime.Now,
                _ => DateTime.Now
            };
        }
        return await base.SaveChangesAsync(cancellationToken);
    }
}
