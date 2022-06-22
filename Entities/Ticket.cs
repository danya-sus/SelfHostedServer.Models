using System;
using System.Collections.Generic;

namespace SelfHostedServer.Models.Entities
{
    public class Ticket
    {
        public String Operation_type { get; set; }
        public DateTimeOffset Operation_time { get; set; }
        public String Operation_place { get; set; }
        public Passenger Passenger { get; set; }
        public IEnumerable<Route> Routes { get; set; }
    }
}
