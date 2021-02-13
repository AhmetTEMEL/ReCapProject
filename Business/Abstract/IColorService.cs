using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IColorService
    {
        List<Colour> Get();
        void Add(Colour colour);
        void Delete(Colour colour);
        void Update(Colour colour);
    }
}
