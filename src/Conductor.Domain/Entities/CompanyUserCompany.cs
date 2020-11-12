using System;

namespace Conductor.Domain.Entities
{
    public class CompanyUserCompany
    {
        public Guid CompanyId { get; set; }
        public Company Company { get; set; }

        public Guid CompanyUserId { get; set; }
        public CompanyUser CompanyUser { get; set; }
    }
}