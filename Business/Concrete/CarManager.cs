using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
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

        public void Add()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
          return  carDal.GetAll();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
