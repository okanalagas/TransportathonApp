using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
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

        services.AddIdentity<AppUser, AppUserRole>(options =>
        {
            options.Lockout.MaxFailedAccessAttempts = 3;
            options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
            options.Password.RequiredUniqueChars = 0;
            options.Password.RequireNonAlphanumeric = false;
            options.Password.RequireDigit = false;
            options.Password.RequireLowercase = false;
            options.Password.RequireUppercase = false;
            options.Password.RequiredLength = 3;
        }).AddEntityFrameworkStores<TransportathonAppDbContext>().AddDefaultTokenProviders();

        services.ConfigureApplicationCookie(options =>
        {
            options.LoginPath = "/Login";
            options.AccessDeniedPath = "/AccessDenied";
            options.SlidingExpiration = true;
            options.ExpireTimeSpan = TimeSpan.FromMinutes(15);
            options.Cookie = new CookieBuilder
            {
                HttpOnly = false,
                SameSite = SameSiteMode.Lax,
                SecurePolicy = CookieSecurePolicy.Always
            };
        });

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
        services.AddScoped<ITransportationOfferReadRepository, TransportationOfferReadRepository>();
        services.AddScoped<ITransportationOfferWriteRepository, TransportationOfferWriteRepository>();
        services.AddScoped<IVehicleReadRepository, VehicleReadRepository>();
        services.AddScoped<IVehicleWriteRepository, VehicleWriteRepository>();
    }
}
