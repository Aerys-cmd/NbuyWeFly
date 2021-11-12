using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NbuyWeFly.Models
{
    public class FlightFilter
    {
        public FlightFilter(PassengerType passengerType, FlightType flightType, Airport from, Airport to, DateTime departureDate, DateTime returnDate, bool isConnectingFlight)
        {
            if (passengerType.Name==Passenger.Student&&flightType.FlightClass==FlightClass.Business)
            {
                throw new Exception("Öğrenciler sadece Ekonomi bileti alabilir.");
            }
            this.passengerType = passengerType;
            this.FlightType = flightType;
            this.From = from;
            this.To = to;
            this.departureDate = departureDate;
            this.returnDate = returnDate;
            this.IsConnectingFlight = isConnectingFlight;
        }

        public PassengerType passengerType { get; set; }
        public FlightType FlightType { get; set; }
        public Airport From { get; set; }
        public Airport To { get; set; }
        public DateTime departureDate { get; set; }
        public DateTime returnDate { get; set; }
        public bool IsConnectingFlight { get; set; }


    }
}
