using TransportathonApp.Domain.Entities.Common;

namespace TransportathonApp.Domain.Entities;

public class Message : BaseEntity
{
    public string Content { get; set; }

    public DateTime SentDate { get; set; }

    //public Guid SenderUserId { get; set; }
    //public AppUser SenderUser { get; set; }

    //public Guid ReceiverUserId { get; set; }
    //public AppUser ReceiverUser { get; set; }
}
