﻿using TransportathonApp.Domain.Entities.Common;

namespace TransportathonApp.Application.Repositories;

public interface IWriteRepository<T> : IRepository<T> where T : BaseEntity
{
    Task<bool> AddAsync(T entity);
    Task<bool> AddRangeAsync(List<T> entities);
    bool Remove(T entity);
    bool RemoveRange(List<T> entities);
    Task<bool> RemoveAsync(int id);
    bool Update(T entity);
    Task<int> SaveAsync();
}
