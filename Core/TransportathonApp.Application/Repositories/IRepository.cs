using Microsoft.EntityFrameworkCore;
using TransportathonApp.Domain.Entities.Common;

namespace TransportathonApp.Application.Repositories;

public interface IRepository<T> where T : BaseEntity
{
    DbSet<T> Table { get; }
}
