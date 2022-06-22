using System;

namespace SelfHostedServer.Models.Entities
{
    public class Refund
    {
        public String Operation_type { get; set; }
        public DateTimeOffset Operation_time { get; set; }
        public String Operation_place { get; set; }
        public UInt64 Ticket_number { get; set; }
    }
}
