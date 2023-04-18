using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Static.Models
{
    public class Galery
    {

        Car[] cars = new Car[0];
        public int Id { get; set; }
        public Galery() { }
        public Galery(int id)
        {
            this.Id = id;
        }
        public void AddCar(Car car)
        {
            Array.Resize(ref cars, cars.Length + 1);
            cars[cars.Length - 1] = car;
        }
        public void ShowAllCars()
        {
            foreach (Car car in cars)
            {
                Console.WriteLine($"{car.ID}{car.Name} {car.Color} {car.Speed}");
            }
        }

        public Car[] GetAllCars()
        {
            
            for (int i = 0; i < cars.Length; i++)
            {
                Car car = cars[i];
            }
            return cars;
        }

        public void FindCarsBySpeedInterval(int min, int max)
        {
            foreach(Car car in cars)
            {
                if (min<car.Speed && max>car.Speed)
                {
                    Console.WriteLine(car.Name);
                }
            }
        }

        public void FindCarById()
        {
            foreach (Car car in cars)
            {
                if (Id==car.ID)
                {
                    Console.WriteLine(car.Name);
                }
            }
        }

    }
}
