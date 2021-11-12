using NbuyWeFly.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NbuyWeFly.Repositories
{
    public class FlightTypeRepository : IRepository<FlightType>
    {
        private List<FlightType> _flightTypes = new();
        public List<FlightType> GetData()
        {
            var flightType = new FlightType(flightClass: FlightClass.Business);
            var flightType1 = new FlightType(flightClass: FlightClass.Economy);
            _flightTypes.Add(flightType);
            _flightTypes.Add(flightType1);
            return _flightTypes;
        }
    }
}
