using Business.Abstract;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using Core.Utilities.Results;
using Business.Constants;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal colorDal;
        public ColorManager(IColorDal colorDal)
        {
            this.colorDal = colorDal;
        }

        public IResult Add(Colour colour)
        {
            colorDal.Add(colour);
            return new SuccessResult(Messages.ColorAdded);
        }

        public IResult Delete(Colour colour)
        {
            colorDal.Delete(colour);
            return new SuccessResult(Messages.ColorDeleted);
        }

        public IDataResult<List<Colour>> Get()
        {
           return new SuccessDataResult<List<Colour>>(colorDal.GetAll(),Messages.ColorsListed);
        }

        public IResult Update(Colour colour)
        {
            colorDal.Update(colour);
            return new SuccessResult(Messages.ColorUpdated);
        }

    }
}
