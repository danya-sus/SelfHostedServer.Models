using System;
using System.Collections.Generic;

namespace SelfHostedServer.Models.Entities
{
    public class Ticket
    {
        public String OperationType { get; set; }
        public DateTimeOffset OperationTime { get; set; }
        public String OperationPlace { get; set; }
        public Passenger Passenger { get; set; }
        public IEnumerable<Route> Routes { get; set; }
    }
}
