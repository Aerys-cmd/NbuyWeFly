using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NbuyWeFly.Models
{
    public class Airport
    {
        public Airport(string name, string code)
        {
            Name = name;
            Code = code;
        }

        public string Name { get; private set; }
        public string Code { get; private set; }
    }
}
