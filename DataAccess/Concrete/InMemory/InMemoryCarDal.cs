using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal:ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1,BrandId=1,ColorId=1, DailyPrice=100, ModelYear=2010, Description="Station Wagon"},
                new Car{Id=2,BrandId=4,ColorId=4, DailyPrice=200, ModelYear=2020, Description="Sedan"},
                new Car{Id=3,BrandId=3,ColorId=1, DailyPrice=300, ModelYear=2012, Description="Coupe"},
                new Car{Id=4,BrandId=4,ColorId=3, DailyPrice=200, ModelYear=2010, Description="Station Wagon"},
                new Car{Id=5,BrandId=5,ColorId=7, DailyPrice=500, ModelYear=2030, Description="Hybrid"}
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carDeleted = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carDeleted);

        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();
        }

        public void Update(Car car)
        {
            Car carUpdated = _cars.SingleOrDefault(c => c.Id == car.Id);
            carUpdated.BrandId = car.BrandId;
            carUpdated.ColorId = car.ColorId;
            carUpdated.DailyPrice = car.DailyPrice;
            carUpdated.ModelYear = car.ModelYear;
            carUpdated.Description = car.Description;
        }
    }
}
