using TransportathonApp.Application.Repositories;
using TransportathonApp.Domain.Entities;
using TransportathonApp.Persistence.Contexts;

namespace TransportathonApp.Persistence.Repositories;

public class CompanyExecutiveWriteRepository : WriteRepository<CompanyExecutive>, ICompanyExecutiveWriteRepository
{
    public CompanyExecutiveWriteRepository(TransportathonAppDbContext context) : base(context)
    {
    }
}
