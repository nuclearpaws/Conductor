using System;

namespace Conductor.Domain.Entities
{
    public class AssignedTicketModeratorUser
    {
        public Guid TicketId { get; set; }
        public Ticket Ticket { get; set; }

        public Guid ModeratorUserId { get; set; }
        public ModeratorUser ModeratorUser { get; set; }
    }
}