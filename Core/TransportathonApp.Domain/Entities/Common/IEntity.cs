namespace TransportathonApp.Domain.Entities.Common;

public interface IEntity
{
    public int Id { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? UpdatedDate { get; set; }
}
