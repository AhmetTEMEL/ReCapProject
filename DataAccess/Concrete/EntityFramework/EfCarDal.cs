using Core.Entities;
using Core.EntityFrameWork;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, NorthwindContext>, ICarDal
    {
        
        public List<Dto> GetListOfCarDetails()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.Id equals b.Id
                             join r in context.Colors
                             on c.Id equals r.Id
                             join Ci in context.CarImages
                             on c.Id equals Ci.CarId
                             select new Dto {
                                CarId= c.Id,BrandName=b.Name,CarName=c.Description,ColorNamme=r.Name,DailyPrice=c.DailyPrice,
                                ImagePath = Ci.ImagePath,Date=Ci.Date
                             };
                return result.ToList();
            }
        }
       
        
       
    }
  
}
