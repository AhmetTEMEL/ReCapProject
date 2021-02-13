using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
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
        public void Add(Brand brand)
        {
            brandDal.Add(brand);
        }

        public void Delete(Brand brand)
        {
            brandDal.Delete(brand);
        }

        public void Update(Brand brand)
        {
            brandDal.Update(brand);
        }

        List<Brand> IBrandService.Get()
        {
            return brandDal.GetAll();
        }
    }
}
