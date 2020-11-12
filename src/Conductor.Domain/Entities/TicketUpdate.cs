using System;

namespace Conductor.Domain.Entities
{
    public class TicketUpdate
    {
        public Guid Id { get; set; }
        public Guid CompanyUserId { get; set; }
        public CompanyUser CompanyUser { get; set; }
        public Guid TicketId { get; set; }
        public Ticket Ticket { get; set; }
    }
}