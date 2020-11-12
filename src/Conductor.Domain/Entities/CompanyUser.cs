using System.Collections.Generic;

namespace Conductor.Domain.Entities
{
    public class CompanyUser : User
    {
        public ICollection<CompanyUserCompany> CompanyUserCompanies { get; set; }
        public ICollection<CompanyUserMessage> CompanyUserMessages { get;set; }
        public ICollection<TicketUpdate> TicketUpdates { get; set; }

        public CompanyUser()
        {
            CompanyUserCompanies = new List<CompanyUserCompany>();
            CompanyUserMessages = new List<CompanyUserMessage>();
            TicketUpdates = new List<TicketUpdate>();
        }
    }
}