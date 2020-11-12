using System.Collections.Generic;

namespace Conductor.Domain.Entities
{
    public class ModeratorUser : CompanyUser
    {
        public ICollection<ModeratorUserMessage> ModeratorUserMessages { get; set; }
        public ICollection<InternalModeratorUserMessage> InternalModeratorUserMessages { get; set; }

        public ICollection<AssignedTicketModeratorUser> AssignedTicketModeratorUsers { get; set; }
        public ICollection<ModeratorGroupModeratorUser> ModeratorGroupModeratorUsers { get; set; }

        public ModeratorUser()
        {
            ModeratorUserMessages = new List<ModeratorUserMessage>();
            InternalModeratorUserMessages = new List<InternalModeratorUserMessage>();

            AssignedTicketModeratorUsers = new List<AssignedTicketModeratorUser>();
            ModeratorGroupModeratorUsers = new List<ModeratorGroupModeratorUser>();
        }
    }
}