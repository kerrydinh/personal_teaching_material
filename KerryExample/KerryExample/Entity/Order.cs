using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KerryExample.Entity
{
    public class Order
    {
        public Guid Id { get; set; }
        public string OrderNumber { get; set; }

        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}
