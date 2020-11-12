using System;
using System.Collections.Generic;

namespace Conductor.Domain.Entities
{
    public class Company
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public ICollection<CompanyUserCompany> CompanyUserCompanies { get; set; }

        public Company()
        {
            CompanyUserCompanies = new List<CompanyUserCompany>();
        }
    }
}