using System;

namespace SelfHostedServer.Models.Entities
{
    public class Refund
    {
        public String OperationType { get; set; }
        public DateTimeOffset OperationTime { get; set; }
        public String OperationPlace { get; set; }
        public UInt64 TicketNumber { get; set; }
    }
}
