using TransportathonApp.Domain.Entities.Common;
using TransportathonApp.Domain.Entities.Identity;

namespace TransportathonApp.Domain.Entities;

public class Message : BaseEntity
{
    public string Title { get; set; }
    public string Content { get; set; }
    public DateTime SentDate { get; set; } = DateTime.Now;
    public DateTime? ReadDate { get; set; }
    public bool HasSeen { get; set; } = false;
    public int SenderUserId { get; set; }
    public virtual AppUser SenderUser { get; set; }
    public int ReceiverUserId { get; set; }
    public virtual AppUser ReceiverUser { get; set; }
    public int ReservationId { get; set; }
    public virtual Reservation Reservation { get; set; }
}
