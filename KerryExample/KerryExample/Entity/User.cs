using KerryExample.Entity.Enum;
using System;
using System.Collections.Generic;

namespace KerryExample.Entity
{
    public class User
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime BirthDay { get; set; }
        public Gender Gender { get; set; }

        public ICollection<Order> Orders { get; set; } = new HashSet<Order>();
    }
}
