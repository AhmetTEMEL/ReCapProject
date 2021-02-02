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
        List<Car> carList;
        public InMemoryCarDal()
        {
            carList = new List<Car> { new Car { Id=1,BrandId=1,ColorId=1,DailyPrice=17999,ModelYear=2020,Description="SportsCar"},
                                       new Car{Id=2,BrandId=2,ColorId=2,DailyPrice=15000,ModelYear=2020,Description="FamilyCar" },
                                        new Car{Id=3,BrandId=3,ColorId=3,DailyPrice=20000,ModelYear=2020,Description="VintageCar" }};
        }
        public void Add(Car car)
        {
            carList.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete=carList.SingleOrDefault(c=>c.Id==car.Id);
            carList.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return carList;
        }

        public List<Car> GetById(int Id)
        {
            return carList.Where(c=>c.Id==Id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = carList.SingleOrDefault(c=>c.Id==car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
