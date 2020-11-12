using System;

namespace Conductor.Domain.Entities
{
    public class ModeratorGroupModeratorUser
    {
        public Guid ModeratorUserId { get; set; }
        public ModeratorUser ModeratorUser { get; set; }

        public Guid ModeratorGroupId { get; set; }
        public ModeratorGroup ModeratorGroup { get; set; }
    }
}