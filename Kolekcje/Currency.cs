using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolekcje
{
    public class Currency
    {
        public string Name { get; set; }
        public string FullName { get; set; }
        public double Rate { get; set; }
        public Currency(string name, string fullName, double rate)
        {
            Name= name;
            FullName= fullName;
            Rate= rate;
        }
    }
}
