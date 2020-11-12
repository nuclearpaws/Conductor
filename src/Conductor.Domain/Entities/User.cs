using System;

namespace Conductor.Domain.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public DateTime DateCreated { get; set; }
    }
}