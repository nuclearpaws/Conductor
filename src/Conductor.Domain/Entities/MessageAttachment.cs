using System;

namespace Conductor.Domain.Entities
{
    public class MessageAttachment
    {
        public Guid Id { get; set; }
        public Guid MessageId { get; set; }
        public Message Message { get; set; }
    }
}