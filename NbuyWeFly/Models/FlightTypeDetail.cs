using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NbuyWeFly.Models
{
    public class FlightTypeDetail
    {
        public FlightTypeDetail(FlightType flightType, decimal unitPrice)
        {
            this.FlightType = flightType;
            this.UnitPrice = unitPrice;
        }
        
        public FlightType FlightType { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
