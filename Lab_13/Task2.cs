using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Lab_13
{
    public class Car
    {
        public string Vendor { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public void Show()
        {
            Console.WriteLine("\nCar characteristics:");
            Console.WriteLine($"Vendor: {Vendor}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Year: {Year}");
        }
    }

    public class Garage<T> : Car
    {
        public List<T> Cars { get; set; }

        public Garage()
        {
            Cars = new List<T>();
        }
    }
}
