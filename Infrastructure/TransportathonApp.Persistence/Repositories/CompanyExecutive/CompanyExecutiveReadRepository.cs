using TransportathonApp.Application.Repositories;
using TransportathonApp.Domain.Entities;
using TransportathonApp.Persistence.Contexts;

namespace TransportathonApp.Persistence.Repositories;

public class CompanyExecutiveReadRepository : ReadRepository<CompanyExecutive>, ICompanyExecutiveReadRepository
{
    public CompanyExecutiveReadRepository(TransportathonAppDbContext context) : base(context)
    {
    }
}
