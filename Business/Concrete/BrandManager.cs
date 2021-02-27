using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal brandDal;
        public BrandManager(IBrandDal brandDal)
        {
            this.brandDal = brandDal;
        }
        public IResult Add(Brand brand)
        {
            ValidationTool.Validate(new BrandValidator(),brand);
            brandDal.Add(brand);
            return new SuccessResult("Eklendi");
        }

        public IResult Delete(Brand brand)
        {
            brandDal.Delete(brand);
            return new SuccessResult(Messages.BrandDeleted);
        }

        public IResult Update(Brand brand)
        {
            brandDal.Update(brand);
            return new SuccessResult("Güncellendi");
        }

        IDataResult<List<Brand>> IBrandService.Get()
        {
            return new DataResult<List<Brand>>(brandDal.GetAll(),true,"Ürünler Listelendi");
        }
    }
}
