using System;

namespace Conductor.Domain.Entities
{
    public class InternalModeratorUserMessage : Message
    {
        public Guid ModeratorUserId { get; set; }
        public ModeratorUser ModeratorUser { get; set; }
    }
}