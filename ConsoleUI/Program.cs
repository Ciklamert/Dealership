using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

List<Car> cars = new List<Car>
{
    new Car(1,1,1,2019,100,"BMW"),
    new Car(2,2,2,2020,200,"Mercedes"),
    new Car(3,3,1,2022,500,"Bugatti"),
    new Car(4,4,2,2015,75,"Audi"),
    new Car(5,5,1,2021,350,"Lamborghini")
};
CarDal carDal = new CarDal(cars);
CarManager carManager = new CarManager(carDal);

Car carToAdd = new Car(6, 6, 2, 2018, 250, "Nissan");
Car carToDelete = new Car(4, 4, 2, 2015, 75, "Audi");
Car carToUpdate = new Car(5, 5, 1, 2021, 400, "Lamborghini");

carManager.Add(carToAdd);
carManager.Delete(carToDelete);
carManager.Update(carToUpdate);
carManager.GetAll().ForEach(c => Console.WriteLine(c.Description));

Console.WriteLine("\nGetById");
Console.WriteLine(carManager.GetById(2).Description);
Console.WriteLine(carManager.GetById(5).DailyPrice);
