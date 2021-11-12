using NbuyWeFly.Models;
using NbuyWeFly.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NbuyWeFly.Managers
{
    public class FindFlightManager
    {
        private FlightFilter _flightFilter;
        public FindFlightManager(FlightFilter flightFilter)
        {
            _flightFilter = flightFilter;
        }
        /// <summary>
        /// Class Instance'ı alınırken verilen filtrelere göre Gidiş uçaklarınının listesini FlightCard listesi cinsinden döndürür.
        /// </summary>
        /// <returns>List of FlightCard</returns>
        public List<FlightCard> GetDepartureFlights()
        {
            return getFlights(_flightFilter.departureDate, _flightFilter.IsConnectingFlight, _flightFilter.From, _flightFilter.To, _flightFilter.FlightType, _flightFilter.passengerType);

        }
        public List<FlightCard> GetReturnFlights()
        {
            if (!_flightFilter.returnDate.Equals(default(DateTime)))
            {
                return getFlights(date:_flightFilter.returnDate,isConnectingFlight: _flightFilter.IsConnectingFlight,from: _flightFilter.To,to: _flightFilter.From,flightType: _flightFilter.FlightType,passengerType: _flightFilter.passengerType);
            }
            else
            {
                throw new Exception("Dönüş uçuşu seçebilmeniz için gidiş dönüş seçeneğini seçip tarih girmeniz gerekmektektedir.");
            }
        }

        private List<FlightCard> getFlights(DateTime date, bool isConnectingFlight, Airport from, Airport to,FlightType flightType,PassengerType passengerType)
        {
            var flightRepo = new FlightRepository();
            var flights = flightRepo.GetData();
            List<Flight> filteredFlights;
            if (!isConnectingFlight)
            {
                filteredFlights = flights.Where(flight =>
                flight.IsConnectingFlight != true
                &&
                flight.Flights.Count == 0
                &&
                flight.DepartureTime.Date == date.Date
                &&
                flight.FromAirport.Code == from.Code
                &&
                flight.ToAirport.Code == to.Code).ToList();
            }
            else
            {
                filteredFlights = flights.Where(flight => flight.DepartureTime.Date == date.Date
                &&
                flight.FromAirport.Code == from.Code
                &&
                flight.ToAirport.Code == to.Code).ToList();

            }
            List<FlightCard> flightCards = new();
            foreach (var flight in filteredFlights)
            {
                var findDetail = flight.FlightTypeDetails.Where(flight => flight.FlightType.FlightClass == flightType.FlightClass).First();
                decimal price = findDetail.UnitPrice * (decimal)(1 - passengerType.DiscountRate);
                flightCards.Add(new FlightCard(flight, price, findDetail.FlightType));

            }
           
            return flightCards;
        }
    }
}

