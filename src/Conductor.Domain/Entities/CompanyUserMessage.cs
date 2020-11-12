using System;

namespace Conductor.Domain.Entities
{
    public class CompanyUserMessage : Message
    {
        public Guid CompanyUserId { get; set; }
        public CompanyUser CompanyUser { get; set; }
    }
}