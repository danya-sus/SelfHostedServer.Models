using System;

namespace SelfHostedServer.Models.Entities
{
    public class Route
    {
        public String AirlineCode { get; set; }
        public int FlightNum { get; set; }
        public String DepartPlace { get; set; }
        public DateTimeOffset DepartDatetime { get; set; }
        public String ArrivePlace { get; set; }
        public DateTimeOffset ArriveDatetime { get; set; }
        public String PnrID { get; set; }
    }
}
