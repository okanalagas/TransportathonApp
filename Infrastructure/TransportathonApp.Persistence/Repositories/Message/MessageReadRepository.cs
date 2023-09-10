using TransportathonApp.Application.Repositories;
using TransportathonApp.Domain.Entities;
using TransportathonApp.Persistence.Contexts;

namespace TransportathonApp.Persistence.Repositories;
public class MessageReadRepository : ReadRepository<Message>, IMessageReadRepository
{
    public MessageReadRepository(TransportathonAppDbContext context) : base(context)
    {
    }
}
