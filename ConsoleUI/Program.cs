using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;


CarManager carManager = new CarManager(new EfCarDal());

carManager.GetAll().ForEach(c => Console.WriteLine(c.Description));
Console.WriteLine();
Car car = new Car(2, 5, 4, 2018, -5, "Yeni Mercedes");
carManager.Add(car);
Console.WriteLine();
carManager.GetAll().ForEach(c => Console.WriteLine(c.Description));

