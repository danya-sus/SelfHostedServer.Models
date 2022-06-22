using System;

namespace SelfHostedServer.Models.Entities
{
    public class Passenger
    {
        public String Name { get; set; }
        public String Surname { get; set; }
        public String Patronymic { get; set; }
        public String Doc_type { get; set; }
        public UInt64 Doc_number { get; set; }
        public DateTime Birthdate { get; set; }
        public String Gender { get; set; }
        public String Passenger_type { get; set; }
        public UInt64 Ticket_number { get; set; }
        public int Ticket_type { get; set; }
    }
}
