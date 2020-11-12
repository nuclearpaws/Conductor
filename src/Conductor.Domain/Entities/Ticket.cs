using System;
using System.Collections.Generic;

namespace Conductor.Domain.Entities
{
    public class Ticket
    {
        public Guid Id { get; set; }
        
        public ICollection<CompanyUserMessage> CompanyUserMessages { get; set; }
        public ICollection<ModeratorUserMessage> ModeratorUserMessages { get; set; }
        public ICollection<InternalModeratorUserMessage> InternalModeratorUserMessages { get; set; }
        public ICollection<TicketUpdate> TicketUpdates { get; set; }

        public ICollection<AssignedTicketModeratorUser> AssignedTicketModeratorUsers { get; set; }
        public ICollection<AssignedTicketModeratorGroup> AssignedTicketModeratorGroups { get; set; }

        public Ticket()
        {
            CompanyUserMessages = new List<CompanyUserMessage>();
            ModeratorUserMessages = new List<ModeratorUserMessage>();
            InternalModeratorUserMessages = new List<InternalModeratorUserMessage>();
            TicketUpdates = new List<TicketUpdate>();
            
            AssignedTicketModeratorUsers = new List<AssignedTicketModeratorUser>();
            AssignedTicketModeratorGroups = new List<AssignedTicketModeratorGroup>();
        }
    }
}