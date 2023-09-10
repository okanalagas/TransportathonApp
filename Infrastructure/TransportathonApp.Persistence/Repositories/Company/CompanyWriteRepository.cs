using TransportathonApp.Application.Repositories;
using TransportathonApp.Domain.Entities;
using TransportathonApp.Persistence.Contexts;

namespace TransportathonApp.Persistence.Repositories;
public class CompanyWriteRepository : WriteRepository<Company>, ICompanyWriteRepository
{
    public CompanyWriteRepository(TransportathonAppDbContext context) : base(context)
    {
    }
}
