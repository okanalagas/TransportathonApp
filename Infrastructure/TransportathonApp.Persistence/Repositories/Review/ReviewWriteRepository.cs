using TransportathonApp.Application.Repositories;
using TransportathonApp.Domain.Entities;
using TransportathonApp.Persistence.Contexts;

namespace TransportathonApp.Persistence.Repositories;
public class ReviewWriteRepository : WriteRepository<Review>, IReviewWriteRepository
{
    public ReviewWriteRepository(TransportathonAppDbContext context) : base(context)
    {
    }
}
