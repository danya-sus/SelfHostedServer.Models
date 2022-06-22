using System;

namespace SelfHostedServer.Models.Entities
{
    public class Route
    {
        public String Airline_code { get; set; }
        public int Flight_num { get; set; }
        public String Depart_place { get; set; }
        public DateTimeOffset Depart_datetime { get; set; }
        public String Arrive_place { get; set; }
        public DateTimeOffset Arrive_datetime { get; set; }
        public String Pnr_id { get; set; }
    }
}
