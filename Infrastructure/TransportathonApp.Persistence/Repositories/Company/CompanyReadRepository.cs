using TransportathonApp.Application.Repositories;
using TransportathonApp.Domain.Entities;
using TransportathonApp.Persistence.Contexts;

namespace TransportathonApp.Persistence.Repositories;
public class CompanyReadRepository : ReadRepository<Company>, ICompanyReadRepository
{
    public CompanyReadRepository(TransportathonAppDbContext context) : base(context)
    {
    }
}
