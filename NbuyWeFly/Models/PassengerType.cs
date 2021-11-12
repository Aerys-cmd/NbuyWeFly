using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NbuyWeFly.Models
{
    public enum Passenger
    {
        Student=0,
        Adult=1,
        Elderly=2,
        Child=3
    }
    public class PassengerType
    {
        public PassengerType(Passenger passenger, float discountRate)
        {
            Name = passenger;
            DiscountRate = discountRate;
        }

        public Passenger Name { get; private set; } 
        public float DiscountRate { get; private set; }
    }
}
