using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Entities.Concrete;
using Core.EntityFrameWork;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfColorDal : EfEntityRepositoryBase<Colour,NorthwindContext>,IColorDal
    {
      
    }
}
