using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal carDal;
        public CarManager(ICarDal carDal)
        {
            this.carDal = carDal;
        }

        public void Add(Car car)
        {
            carDal.Add(car);
        }

        public void Delete(Car car)
        {
            carDal.Delete(car);
        }

        public List<Car> Get()
        {
            return carDal.GetAll();
        }

        public List<Dto> GetCarDetails()
        {
            return carDal.GetListOfCarDetails();
        }

        public void Update(Car car)
        {
            throw new NotImplementedException();
        }
    }
}
