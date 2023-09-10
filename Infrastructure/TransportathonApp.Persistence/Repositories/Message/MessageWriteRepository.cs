using TransportathonApp.Application.Repositories;
using TransportathonApp.Domain.Entities;
using TransportathonApp.Persistence.Contexts;

namespace TransportathonApp.Persistence.Repositories;
public class MessageWriteRepository : WriteRepository<Message>, IMessageWriteRepository
{
    public MessageWriteRepository(TransportathonAppDbContext context) : base(context)
    {
    }
}
