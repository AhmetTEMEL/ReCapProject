using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IColorService
    {
        IDataResult<List<Colour>> Get();
        IResult Add(Colour colour);
        IResult Delete(Colour colour);
        IResult Update(Colour colour);
    }
}
