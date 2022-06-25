using System;

namespace SelfHostedServer.Models.Entities
{
    public class Passenger
    {
        public String Name { get; set; }
        public String Surname { get; set; }
        public String Patronymic { get; set; }
        public String DocType { get; set; }
        public UInt64 DocNumber { get; set; }
        public DateTime Birthdate { get; set; }
        public String Gender { get; set; }
        public String PassengerType { get; set; }
        public UInt64 TicketNumber { get; set; }
        public int TicketType { get; set; }
    }
}
