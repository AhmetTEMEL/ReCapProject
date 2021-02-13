﻿
using Entities.Concrete;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> Get();
        void Add(Car car);
        void Delete(Car car);
        void Update(Car car);
        List<Dto> GetCarDetails();
    }
}
