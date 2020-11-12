using System;
using System.Collections.Generic;

namespace Conductor.Domain.Entities
{
    public class ModeratorGroup
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public ICollection<ModeratorGroupModeratorUser> ModeratorGroupModeratorUsers { get; set; }
        public ICollection<AssignedTicketModeratorGroup> AssignedTicketModeratorGroups { get; set; }

        public ModeratorGroup()
        {
            ModeratorGroupModeratorUsers = new List<ModeratorGroupModeratorUser>();
            AssignedTicketModeratorGroups = new List<AssignedTicketModeratorGroup>();
        }
    }
}