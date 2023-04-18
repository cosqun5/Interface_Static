using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Static.Models
{
    public class Car
    {
        static Car()
        {
            Console.WriteLine("First Car created");
        }
        public Car()
        {
            count++;
            ID = count;
        }
        public static int count;
        public int ID { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public int Speed { get; set; }

    }
}
