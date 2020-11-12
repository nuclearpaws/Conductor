using System;

namespace Conductor.Domain.Entities
{
    public class AssignedTicketModeratorGroup
    {
        public Guid TicketId { get; set; }
        public Ticket Ticket { get; set; }

        public Guid ModeratorGroupId { get; set; }
        public ModeratorGroup ModeratorGroup { get; set; }
    }
}