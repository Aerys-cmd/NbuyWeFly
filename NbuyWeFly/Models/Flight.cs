using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NbuyWeFly.Models
{
    public class Flight
    {
        public Flight(Airport fromAirport, Airport toAirport, DateTime departureTime, DateTime estimatedArrivalTime, bool isConnectingFlight, Airline airLine)
        {
            FromAirport = fromAirport;
            ToAirport = toAirport;
            DepartureTime = departureTime;
            EstimatedArrivalTime = estimatedArrivalTime;
            IsConnectingFlight = isConnectingFlight;
            AirLine = airLine;
        }

        public Airport FromAirport { get; private set; }
        public Airport ToAirport { get; private set; }
        public DateTime DepartureTime { get; private set; }
        public DateTime EstimatedArrivalTime { get; private set; }
        public bool IsConnectingFlight { get; private set; }
        public Airline AirLine { get; private set; }
        public IReadOnlyList<Flight> Flights => flights;
        private List<Flight> flights = new();
        public IReadOnlyList<FlightTypeDetail> FlightTypeDetails => flightTypeDetails;
        private List<FlightTypeDetail> flightTypeDetails = new();

        public void AddConnectingFlight(Flight flight)
        {
            if (IsConnectingFlight)
            {
                flights.Add(flight);
                //Not that important 
                var firstFlightsDate= flights.Select(x=>x.DepartureTime).First();
                DepartureTime = firstFlightsDate;
            }
        }
        public void AddFlightTypeDetail(FlightType flightType,decimal price)
        {
            var flightTypeDetail = new FlightTypeDetail(flightType, price);
            //Validation steps
            flightTypeDetails.Add(flightTypeDetail);

        }


    }
}
