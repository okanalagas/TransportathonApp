using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using TransportathonApp.Domain.Entities;
using TransportathonApp.Domain.Entities.Common;
using TransportathonApp.Domain.Entities.Identity;

namespace TransportathonApp.Persistence.Contexts;

public class TransportathonAppDbContext : IdentityDbContext<AppUser, AppUserRole, int>
{
    public TransportathonAppDbContext(DbContextOptions options) : base(options)
    {

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<AppUser>().HasOne(x => x.Customer).WithOne(x => x.User).HasForeignKey<Customer>(x => x.Id).IsRequired();
        modelBuilder.Entity<AppUser>().HasOne(x => x.CompanyExecutive).WithOne(x => x.User).HasForeignKey<CompanyExecutive>(x => x.Id).IsRequired();
        //modelBuilder.Entity<AppUser>().HasOne(x => x.TransportationTeamLeader).WithOne(x => x.User).HasForeignKey<TransportationTeamLeader>(x => x.Id).IsRequired();
        modelBuilder.Entity<CompanyExecutive>().HasOne(x => x.Company).WithOne(x => x.CompanyExecutive).HasForeignKey<Company>(x => x.Id).IsRequired();
        modelBuilder.Entity<Review>().HasOne(x => x.Reservation).WithOne(x => x.Review).HasForeignKey<Reservation>(x => x.Id).IsRequired();
        modelBuilder.Entity<TransportationRequestOffers>().Ignore(x => x.Id).HasKey(x => new { x.TransportationOfferId, x.TransportationRequestId });
        modelBuilder.Entity<TransportationOffer>().HasOne(x => x.Driver).WithMany(d => d.TransportationOffers).HasForeignKey(x => x.DriverId).OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<TransportationOffer>().HasOne(x => x.TransportationTeam).WithMany(t => t.TransportationOffers).HasForeignKey(x => x.TransportationTeamId).OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<TransportationOffer>().HasOne(x => x.Vehicle).WithMany(v => v.TransportationOffers).HasForeignKey(x => x.VehicleId).OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<Reservation>().HasOne(r => r.TransportationRequest).WithMany().HasForeignKey(r => r.TransportationRequestId).OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<Reservation>().HasOne(r => r.TransportationOffer).WithMany().HasForeignKey(r => r.TransportationOfferId).OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<TransportationRequestOffers>().HasOne(to => to.Request).WithMany().HasForeignKey(to => to.TransportationRequestId).OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<TransportationRequestOffers>().HasOne(to => to.TransportationOffer).WithMany().HasForeignKey(to => to.TransportationOfferId).OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<Message>().HasOne(m => m.SenderUser).WithMany().HasForeignKey(m => m.SenderUserId).OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<Message>().HasOne(m => m.ReceiverUser).WithMany().HasForeignKey(m => m.ReceiverUserId).OnDelete(DeleteBehavior.Restrict);

    }

    public DbSet<Company> Companies { get; set; }
    public DbSet<CompanyExecutive> CompanyExecutives { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Driver> Drivers { get; set; }
    public DbSet<Message> Messages { get; set; }
    public DbSet<Reservation> Reservations { get; set; }
    public DbSet<Review> Reviews { get; set; }
    public DbSet<TransportationOffer> TransportationOffers { get; set; }
    public DbSet<TransportationRequest> TransportationRequests { get; set; }
    public DbSet<TransportationRequestOffers> TransportationRequestOffers { get; set; }
    public DbSet<TransportationTeam> TransportationTeams { get; set; }
    //public DbSet<TransportationTeamLeader> TransportationTeamLeaders { get; set; }
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
