using System;

namespace Conductor.Domain.Entities
{
    public class ModeratorUserMessage : Message
    {
        public Guid ModeratorUserId { get; set; }
        public ModeratorUser ModeratorUser { get; set; }
    }
}