using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SelfHostedServer.Models.Entities
{
    public class Segment
    {
        public Segment(String operation_type, DateTimeOffset operation_time,
                       String operation_place, String name,
                       String surname, String patronymic,
                       String doc_type, UInt64 doc_number,
                       DateTime birthdate, String gender,
                       String passenger_type, UInt64 ticket_number,
                       int ticket_type, int serial_number,
                       String airline_code, int flight_num,
                       String depart_place, DateTimeOffset depart_datetime,
                       String arrive_place, DateTimeOffset arrive_datetime,
                       String pnr_id)
        {
            this.Operation_type = operation_type;
            this.Operation_time = operation_time;
            this.Operation_place = operation_place;
            this.Name = name;
            this.Surname = surname;
            this.Patronymic = patronymic;
            this.Doc_type = doc_type;
            this.Doc_number = doc_number;
            this.Birthdate = birthdate;
            this.Gender = gender;
            this.Passenger_type = passenger_type;
            this.Ticket_number = ticket_number;
            this.Ticket_type = ticket_type;
            this.Serial_number = serial_number;
            this.Airline_code = airline_code;
            this.Flight_num = flight_num;
            this.Depart_place = depart_place;
            this.Depart_datetime = depart_datetime;
            this.Arrive_place = arrive_place;
            this.Arrive_datetime = arrive_datetime;
            this.Pnr_id = pnr_id;
            this.Refund = false;
        }

        public Segment(String operation_type, DateTimeOffset operation_time,
                       String operation_place, Passenger passenger,
                       Route route, int serial_number)
        {
            this.Operation_type = operation_type;
            this.Operation_time = operation_time;
            this.Operation_place = operation_place;
            this.Name = passenger.Name;
            this.Surname = passenger.Surname;
            this.Patronymic = passenger.Patronymic;
            this.Doc_type = passenger.Doc_type;
            this.Doc_number = passenger.Doc_number;
            this.Birthdate = passenger.Birthdate;
            this.Gender = passenger.Gender;
            this.Passenger_type = passenger.Passenger_type;
            this.Ticket_number = passenger.Ticket_number;
            this.Ticket_type = passenger.Ticket_type;
            this.Serial_number = serial_number;
            this.Airline_code = route.Airline_code;
            this.Flight_num = route.Flight_num;
            this.Depart_place = route.Depart_place;
            this.Depart_datetime = route.Depart_datetime;
            this.Arrive_place = route.Arrive_place;
            this.Arrive_datetime = route.Arrive_datetime;
            this.Pnr_id = route.Pnr_id;
            this.Refund = false;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public String Operation_type { get; set; }
        public DateTimeOffset Operation_time { get; set; }
        public String Operation_place { get; set; }
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
        public int Serial_number { get; set; }
        public String Airline_code { get; set; }
        public int Flight_num { get; set; }
        public String Depart_place { get; set; }
        public DateTimeOffset Depart_datetime { get; set; }
        public String Arrive_place { get; set; }
        public DateTimeOffset Arrive_datetime { get; set; }
        public String Pnr_id { get; set; }
        public bool Refund { get; set; }
    }
}
