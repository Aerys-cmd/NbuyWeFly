using NbuyWeFly.Managers;
using NbuyWeFly.Models;
using NbuyWeFly.Repositories;
using System;
using System.Linq;
namespace NbuyWeFly
{
    class Program
    {
        static void Main(string[] args)
        {

            var pt = new PassengerTypeRepository();
            var pts = pt.GetData();

            var flightFilter = new FlightFilter(passengerType: pts.Where(x => x.Name == Passenger.Student).First(), flightType: new FlightType(FlightClass.Business), new Airport("AASDASD", "HTY"), new Airport("asd", "JFK"), DateTime.Now.AddDays(3), default(DateTime), true);
            var findFlight = new FindFlightManager(flightFilter);

            var flightsDetais =
            findFlight.GetDepartureFlights();

            foreach (var flightdetail in flightsDetais)
            {
                Console.WriteLine(flightdetail.ListPrice+ "Bu fiyatı");
                Console.WriteLine(flightdetail.FlightType+"Uçuş tipi");
                Console.WriteLine($"Uçuş Kart detayları {flightdetail.Flight.AirLine.Name} Airline {flightdetail.Flight.DepartureTime.ToString()} Kalkış zamanı " +
                    $"{flightdetail.Flight.EstimatedArrivalTime.ToString()} tarihinde inecek {flightdetail.Flight.FromAirport.Code}  {flightdetail.Flight.ToAirport.Code} ");
                foreach (var item in flightdetail.Flight.Flights)
                {
                    Console.WriteLine(item.FromAirport);
                    Console.WriteLine(item.ToAirport);
                    Console.WriteLine(item.DepartureTime);
                }

            }
        }
    }
}
