using System;
using System.Collections.Generic;

namespace Conductor.Domain.Entities
{
    public abstract class Message
    {
        public Guid Id { get; set; }
        public DateTime DateCreated { get; set; }
        public Guid TicketId { get; set; }
        public Ticket Ticket { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }

        public ICollection<MessageAttachment> MessageAttachments { get; set; }

        public Message()
        {
            MessageAttachments = new List<MessageAttachment>();
        }
    }
}