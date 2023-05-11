using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_13
{
    public class Apartment
    {
        public int People { get; set; }
        public int Number { get; set; }
    }

    public class House<T> : Apartment
    {
        public List<T> Apartments { get; set; }

        public House()
        {
            Apartments = new List<T>();
        }
    }
}