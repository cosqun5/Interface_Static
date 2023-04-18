using Interface_Static.Models;

Car car = new Car();
car.Name = "BMV";
car.Color = "red";
car.Speed = 300;


Car car1 = new Car();
car1.Name = "Mercedec";
car1.Color = "black";
car1.Speed = 450;

Car car2 = new Car();
car2.Name = "Auidi";
car2.Color = "black";
car2.Speed = 400;

Galery galery = new Galery();
galery.AddCar(car);
galery.AddCar(car1);
galery.AddCar(car2);

galery.ShowAllCars();
//Console.WriteLine(galery.GetAllCars());
//galery.FindCarsBySpeedInterval(300, 500);
//galery.Id = 1;
//galery.FindCarById();
