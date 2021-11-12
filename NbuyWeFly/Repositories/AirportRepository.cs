using NbuyWeFly.Models;
using System;
using System.Collections.Generic;

namespace NbuyWeFly.Repositories
{
    public class AirportRepository : IRepository<Airport>
    {
        private List<Airport> _airports = new();
        public List<Airport> GetData()
        {
            var airport = new Airport(name: "İstanbul Havaalanı", code: "IGA");
            var airport1 = new Airport(name: "İstanbul Sabiha Gökçen Havaalanı", code: "SAW");
            var airport2 = new Airport(name: "John F. Kennedy Airport", code: "JFK");
            var airport3 = new Airport(name: "Hatay Havaalanı", code: "HTY");
            _airports.Add(airport);
            _airports.Add(airport1);
            _airports.Add(airport2);
            _airports.Add(airport3);
            return _airports;
        }
    }
}
