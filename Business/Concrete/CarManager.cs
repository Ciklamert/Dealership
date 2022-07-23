using Business.Abstract;
using Business.Validators;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        CarValidator carValidator = new CarValidator();
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        public void Add(Car item)
        {
            var result = carValidator.Validate(item);
            if (result.IsValid)
            {
                _carDal.Add(item);
            }
            else
            {
                foreach(var error in result.Errors)
                {
                    throw new Exception(error.ErrorMessage);
                }
            }
            
        }

        public void Delete(Car item)
        {
            _carDal.Delete(item);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public Car GetById(int id)
        {
            return _carDal.Get(c => c.Id == id);
        }
        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(c => c.BrandId == id);
        }
        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(c => c.BrandId == id);
        }

        public void Update(Car item)
        {
            var result = carValidator.Validate(item);
            if (result.IsValid)
            {
                _carDal.Update(item);
            }
            else
            {
                foreach (var error in result.Errors)
                {
                    throw new Exception(error.ErrorMessage);
                }
            }
        }
    }
}
