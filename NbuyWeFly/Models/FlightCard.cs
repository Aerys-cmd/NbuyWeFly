using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NbuyWeFly.Models
{
    public class FlightCard
    {
        public FlightCard(Flight flight, decimal listPrice,FlightType flightType)
        {
            this.Flight = flight;
            this.ListPrice = listPrice;
            this.FlightType = flightType;
        }

        public Flight Flight { get; private set; }
        public FlightType FlightType { get; private set; }
        public decimal ListPrice { get; private set; }

        
    }
}
