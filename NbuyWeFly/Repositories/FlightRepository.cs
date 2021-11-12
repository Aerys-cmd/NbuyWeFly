using NbuyWeFly.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NbuyWeFly.Repositories
{
    public class FlightRepository : IRepository<Flight>
    {
        private List<Flight> _flights = new();
        public List<Flight> GetData()
        {
            var airlineRepo = new AirlineRepository();
            var airlines = airlineRepo.GetData();
            var airportRepo = new AirportRepository();
            var airports = airportRepo.GetData();
            var flightTypeRepo = new FlightTypeRepository();
            var flightTypes = flightTypeRepo.GetData();
            DateTime dt = DateTime.Now;



            //DİREKT UÇUŞ
            var flight = new Flight(fromAirport: airports.Where(x => x.Code == "SAW").First(),
                toAirport: airports.Where(x => x.Code == "JFK").First(),
                dt.AddDays(3), dt.AddDays(3).AddHours(8)
                , false, airLine: airlines.Where(x => x.Code == "THY").First());
            flight.AddFlightTypeDetail(
                new FlightType(flightTypes.Where(x => x.FlightClass.Equals(FlightClass.Business)).First().FlightClass), 300M);
            flight.AddFlightTypeDetail(
               new FlightType(flightTypes.Where(x => x.FlightClass.Equals(FlightClass.Economy)).First().FlightClass), 150M);





            //DİREKT UÇUŞ ANCAK AKTARMALI OLARAK HTY DAN JFK OLARAK AYRI BİR INSTANCE ICERISINDE TUTULACAK.
            var flight1 = new Flight(fromAirport: airports.Where(x => x.Code == "HTY").First(),
               toAirport: airports.Where(x => x.Code == "SAW").First(),
               dt.AddDays(3), dt.AddDays(3).AddHours(2)
               , false, airLine: airlines.Where(x => x.Code == "AJET").First());
            flight1.AddFlightTypeDetail(
              new FlightType(flightTypes.Where(x => x.FlightClass.Equals(FlightClass.Business)).First().FlightClass), 250M);
            flight1.AddFlightTypeDetail(
               new FlightType(flightTypes.Where(x => x.FlightClass.Equals(FlightClass.Economy)).First().FlightClass), 130M);

            //DİREKT UÇUŞ ANCAK AKTARMALI OLARAK HTY DAN JFK OLARAK AYRI BİR INSTANCE ICERISINDE TUTULACAK.
            var flight2 = new Flight(fromAirport: airports.Where(x => x.Code == "SAW").First(),
               toAirport: airports.Where(x => x.Code == "JFK").First(),
               dt.AddDays(3).AddHours(3), dt.AddDays(3).AddHours(8)
               , false, airLine: airlines.Where(x => x.Code == "SUN").First());
            flight2.AddFlightTypeDetail(
            new FlightType(flightTypes.Where(x => x.FlightClass.Equals(FlightClass.Business)).First().FlightClass), 250M);
            flight2.AddFlightTypeDetail(
               new FlightType(flightTypes.Where(x => x.FlightClass.Equals(FlightClass.Economy)).First().FlightClass), 170M);

            // AKTARMALI UÇUŞ ANCAK İÇİNDEKİ HER BİR UÇUŞ AYNI ZAMANDA KENDİ GUZERGAHLARINDA BİR DİREKT UÇUŞ
            var flight4 = new Flight(fromAirport: airports.Where(x => x.Code == "HTY").First(),
              toAirport: airports.Where(x => x.Code == "JFK").First(),
              dt.AddDays(3), dt.AddDays(2).AddHours(8)
              , true, airLine: airlines.Where(x => x.Code == "THY").First());
            flight4.AddConnectingFlight(flight1);
            flight4.AddConnectingFlight(flight2);
            flight4.AddFlightTypeDetail(
          new FlightType(flightTypes.Where(x => x.FlightClass.Equals(FlightClass.Business)).First().FlightClass), 600M);
            flight4.AddFlightTypeDetail(
               new FlightType(flightTypes.Where(x => x.FlightClass.Equals(FlightClass.Economy)).First().FlightClass), 350M);




            //DİREKT UÇUŞ
            var flight3 = new Flight(fromAirport: airports.Where(x => x.Code == "IGA").First(),
               toAirport: airports.Where(x => x.Code == "HTY").First(),
               dt.AddDays(2), dt.AddDays(2).AddHours(8)
               , false, airLine: airlines.Where(x => x.Code == "THY").First());
            flight3.AddFlightTypeDetail(
         new FlightType(flightTypes.Where(x => x.FlightClass.Equals(FlightClass.Business)).First().FlightClass), 500M);
            flight3.AddFlightTypeDetail(
               new FlightType(flightTypes.Where(x => x.FlightClass.Equals(FlightClass.Economy)).First().FlightClass), 270M);

            _flights.Add(flight);
            _flights.Add(flight1);
            _flights.Add(flight2);
            _flights.Add(flight3);
            _flights.Add(flight4);

            return _flights;



        }
    }
}
