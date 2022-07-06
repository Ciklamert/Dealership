using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{

    public class CarDal:ICarDal
    {
        List<Car> _cars;
        public CarDal(List<Car> cars)
        {
            _cars = cars;
        }

        public void Add(Car item)
        {
            _cars.Add(item);
        }

        public void Delete(Car item)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == item.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars.ToList();
        }

        public Car GetById(int id)
        {
            return _cars.SingleOrDefault(c => c.Id == id);
        }

        public void Update(Car item)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == item.Id);
            carToUpdate.ColorId = item.ColorId;
            carToUpdate.DailyPrice = item.DailyPrice;
            carToUpdate.Description = item.Description;
            carToUpdate.ModelYear = item.ModelYear;
        }
    }
}
