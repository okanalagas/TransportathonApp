﻿namespace TransportathonApp.Domain.Entities.Common;

public abstract class BaseEntity : IEntity
{
    public int Id { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? UpdatedDate { get; set; }
}
