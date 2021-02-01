using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
             new Car{Id=1,BrandId=101,ColorId=222,ModelYear=2018,DailyPrice=200000,Description="Mercedes"},
             new Car{Id=2,BrandId=102,ColorId=333,ModelYear=2015,DailyPrice=160000,Description="Audi"},
             new Car{Id=3,BrandId=103,ColorId=444,ModelYear=2019,DailyPrice=125000,Description="Opel"},
             new Car{Id=4,BrandId=104,ColorId=555,ModelYear=2011,DailyPrice=100000,Description="Nissan"},
             new Car{Id=5,BrandId=105,ColorId=666,ModelYear=2016,DailyPrice=126500,Description="Ford"}

            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(s=>s.Id==car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }


        public List<Car> GetById()
        {
            return _cars;
        }

        public List<Car> GetById(int getById)
        {
            throw new NotImplementedException();
        }

        //public List<Car> GetById(int getById)
        //{
        //    _cars.Where(s => s.Id == getById).ToList();
        //}

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(s => s.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
