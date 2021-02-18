using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal rentalDal;
        public RentalManager(IRentalDal rentalDal)
        {
            this.rentalDal = rentalDal;
        }
        public IResult Add(Rental rental)
        {
            if (rental.ReturnDate!=null) {
                rentalDal.Add(rental);
                return new SuccessResult(Messages.RentalAdded);
            }
            return ErrorResult(Messages.RentalAdditonRejected);
        }

        private IResult ErrorResult(object rentalAdditonRejected)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Rental rental)
        {
            rentalDal.Delete(rental);
            return new SuccessResult(Messages.RentalDeleted);
        }

        public IDataResult<List<Rental>> Get()
        {
            return new SuccessDataResult<List<Rental>>(Messages.Rentallisted);
        }

        public IResult Update(Rental rental)
        {
            rentalDal.Update(rental);
            return new SuccessResult(Messages.RentalUpdated);
        }
    }
}
