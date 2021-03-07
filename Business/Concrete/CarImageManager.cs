using Business.Abstract;
using Business.Constants;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Business.Concrete
{
    class CarImageManager : ICarImageService

    {
        ICarImageDal _carImageDal;
        public CarImageManager(ICarImageDal carImageDal)
        {
            _carImageDal = carImageDal;
        }
        public IResult Add(CarImage carImage,int CarId)
        {
            IResult result = BusinessRules.Run(CheckCarImageCount(CarId));
            if (result != null)
            {

                return new ErrorResult("Bir araca ait 5 maksimum adet fotoğraf olabilir.");
            }
            _carImageDal.Add(carImage);
            return new SuccessResult(Messages.CarAdded);
        }

        public IResult Delete(CarImage carImage)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CarImage>> Get()
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(), Messages.CarsListed);
        }

        public IResult Update(CarImage carImage)
        {
            throw new NotImplementedException();
        }

        public IResult CheckCarImageCount(int carId)
        {
            var result = _carImageDal.GetAll(p => p.CarId == carId).Count;
            if (result >= 5)
            {
                return new ErrorResult("eklenemez");
            }
            return new SuccessResult("Eklenebilir");
        }
    }
}
