using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SelfHostedServer.Models.Entities
{
    public class Segment
    {
        public Segment() { }
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
            this.OperationType = operation_type;
            this.OperationTime = operation_time;
            this.OperationPlace = operation_place;
            this.Name = name;
            this.Surname = surname;
            this.Patronymic = patronymic;
            this.DocType = doc_type;
            this.DocNumber = doc_number;
            this.Birthdate = birthdate;
            this.Gender = gender;
            this.PassengerType = passenger_type;
            this.TicketNumber = ticket_number;
            this.TicketType = ticket_type;
            this.SerialNumber = serial_number;
            this.AirlineCode = airline_code;
            this.FlightNum = flight_num;
            this.DepartPlace = depart_place;
            this.DepartDatetime = depart_datetime;
            this.ArrivePlace = arrive_place;
            this.ArriveDatetime = arrive_datetime;
            this.PnrID = pnr_id;
            this.Refund = false;
        }

        public Segment(String operation_type, DateTimeOffset operation_time,
                       String operation_place, Passenger passenger,
                       Route route, int serial_number)
        {
            this.OperationType = operation_type;
            this.OperationTime = operation_time;
            this.OperationPlace = operation_place;
            this.Name = passenger.Name;
            this.Surname = passenger.Surname;
            this.Patronymic = passenger.Patronymic;
            this.DocType = passenger.DocType;
            this.DocNumber = passenger.DocNumber;
            this.Birthdate = passenger.Birthdate;
            this.Gender = passenger.Gender;
            this.PassengerType = passenger.PassengerType;
            this.TicketNumber = passenger.TicketNumber;
            this.TicketType = passenger.TicketType;
            this.SerialNumber = serial_number;
            this.AirlineCode = route.AirlineCode;
            this.FlightNum = route.FlightNum;
            this.DepartPlace = route.DepartPlace;
            this.DepartDatetime = route.DepartDatetime;
            this.ArrivePlace = route.ArrivePlace;
            this.ArriveDatetime = route.ArriveDatetime;
            this.PnrID = route.PnrID;
            this.Refund = false;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public String OperationType { get; set; }
        public DateTimeOffset OperationTime { get; set; }
        public String OperationPlace { get; set; }
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
        public int SerialNumber { get; set; }
        public String AirlineCode { get; set; }
        public int FlightNum { get; set; }
        public String DepartPlace { get; set; }
        public DateTimeOffset DepartDatetime { get; set; }
        public String ArrivePlace { get; set; }
        public DateTimeOffset ArriveDatetime { get; set; }
        public String PnrID { get; set; }
        public bool Refund { get; set; }
    }
}
