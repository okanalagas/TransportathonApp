using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TransportathonApp.Application.Repositories;
using TransportathonApp.Domain.Entities.Identity;
using TransportathonApp.Persistence.Contexts;
using TransportathonApp.Persistence.Repositories;

namespace TransportathonApp.Persistence;

public static class ServiceRegistration
{
    public static void AddPersistenceServices(this IServiceCollection services)
    {
        services.AddDbContext<TransportathonAppDbContext>(options => options.UseSqlServer(Configuration.ConnectionString));

        services.AddIdentity<AppUser, AppUserRole>().AddEntityFrameworkStores<TransportathonAppDbContext>();

        services.AddScoped<ICompanyReadRepository, CompanyReadRepository>();
        services.AddScoped<ICompanyWriteRepository, CompanyWriteRepository>();
        services.AddScoped<ICustomerReadRepository, CustomerReadRepository>();
        services.AddScoped<ICustomerWriteRepository, CustomerWriteRepository>();
        services.AddScoped<ICompanyExecutiveReadRepository, CompanyExecutiveReadRepository>();
        services.AddScoped<ICompanyExecutiveWriteRepository, CompanyExecutiveWriteRepository>();
        services.AddScoped<IDriverReadRepository, DriverReadRepository>();
        services.AddScoped<IDriverWriteRepository, DriverWriteRepository>();
        services.AddScoped<IMessageReadRepository, MessageReadRepository>();
        services.AddScoped<IMessageWriteRepository, MessageWriteRepository>();
        services.AddScoped<IReservationReadRepository, ReservationReadRepository>();
        services.AddScoped<IReservationWriteRepository, ReservationWriteRepository>();
        services.AddScoped<IReviewReadRepository, ReviewReadRepository>();
        services.AddScoped<IReviewWriteRepository, ReviewWriteRepository>();
        services.AddScoped<ITransportationRequestReadRepository, TransportationRequestReadRepository>();
        services.AddScoped<ITransportationRequestWriteRepository, TransportationRequestWriteRepository>();
        services.AddScoped<IVehicleReadRepository, VehicleReadRepository>();
        services.AddScoped<IVehicleWriteRepository, VehicleWriteRepository>();
    }
}
