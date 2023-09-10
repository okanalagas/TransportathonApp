using TransportathonApp.Application.Repositories;
using TransportathonApp.Domain.Entities;
using TransportathonApp.Persistence.Contexts;

namespace TransportathonApp.Persistence.Repositories;
public class ReviewReadRepository : ReadRepository<Review>, IReviewReadRepository
{
    public ReviewReadRepository(TransportathonAppDbContext context) : base(context)
    {
    }
}
