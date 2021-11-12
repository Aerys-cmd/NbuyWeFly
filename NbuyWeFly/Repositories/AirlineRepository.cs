using NbuyWeFly.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NbuyWeFly.Repositories
{
    public class AirlineRepository : IRepository<Airline>
    {
        private List<Airline> _airlines = new();
        public List<Airline> GetData()
        {
            var airline = new Airline(name:"Türk Hava Yolları",code:"THY");
            var airline1 = new Airline(name: "Pegasus", code: "FLYPGS");
            var airline2 = new Airline(name: "AnadoluJet", code: "AJET");
            var airline3 = new Airline(name: "SUN Express", code: "SUN");
            _airlines.Add(airline);
            _airlines.Add(airline1);
            _airlines.Add(airline2);
            _airlines.Add(airline3);
            return _airlines;
        }
    }
}
