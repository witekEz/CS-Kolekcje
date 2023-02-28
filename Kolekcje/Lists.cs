using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolekcje
{
    public class Lists
    {
        public List<int> list { get; set; }
        public void DisplayList()
        {
            Console.WriteLine("*LIST*");
            foreach(int i in list)
            {
                Console.WriteLine($"{i}, ");
            }
        }
    }
}
