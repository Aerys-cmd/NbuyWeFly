using NbuyWeFly.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NbuyWeFly.Repositories
{
    public class PassengerTypeRepository : IRepository<PassengerType>
    {
        private List<PassengerType> _passengerTypes = new();
        public List<PassengerType> GetData()
        {
            var pT = new PassengerType(passenger:Passenger.Adult,0F);
            var pT1 = new PassengerType(passenger: Passenger.Child, 0.3F);
            var pT2 = new PassengerType(passenger: Passenger.Elderly, 0.50F);
            var pT3 = new PassengerType(passenger: Passenger.Student, 0.50F);

            _passengerTypes.Add(pT);
            _passengerTypes.Add(pT1);
            _passengerTypes.Add(pT2);
            _passengerTypes.Add(pT3);


            return _passengerTypes;
        }
    }
}
