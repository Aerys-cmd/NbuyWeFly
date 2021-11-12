using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NbuyWeFly.Models
{
    public class FlightType
    {
        public FlightType(FlightClass flightClass)
        {
            this.FlightClass = flightClass;
        }
        public FlightClass FlightClass { get; private set; }
    }
    public enum FlightClass
    {
        Economy = 0,
        Business = 1
    }
    
    }

