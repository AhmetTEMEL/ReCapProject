using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
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

        public IResult Add(Car car)
        {           
            carDal.Add(car);
            return new SuccessResult(Messages.CarAdded);
        }

        public IResult Delete(Car car)
        {
            carDal.Delete(car);
            return new SuccessResult(Messages.CarDeleted);
        }

        public IDataResult<List<Car>> Get()
        {
            return new SuccessDataResult<List<Car>>(carDal.GetAll(),Messages.CarsListed);
        }

        public IDataResult<List<Dto>> GetCarDetails()
        {
            return new SuccessDataResult<List<Dto>>(carDal.GetListOfCarDetails(),Messages.CarDetailsListed);
        }

        public IResult Update(Car car)
        {
            carDal.Update(car);
            return new SuccessResult(Messages.CarUpdated);
        }

    }
}
