using Business.Abstract;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal colorDal;
        public ColorManager(IColorDal colorDal)
        {
            this.colorDal = colorDal;
        }

        public void Add(Colour colour)
        {
            colorDal.Add(colour);
        }

        public void Delete(Colour colour)
        {
            colorDal.Delete(colour);
        }

        public List<Colour> Get()
        {
           return colorDal.GetAll();
        }

        public void Update(Colour colour)
        {
            colorDal.Update(colour);
        }

    }
}
