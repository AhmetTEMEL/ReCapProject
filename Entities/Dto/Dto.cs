﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dto
{
   public class Dto : IDto
    {
        public int CarId { get; set; }
        public string CarName { get; set; }
        public string BrandName { get; set; }
        public string ColorNamme { get; set; }
        public double DailyPrice { get; set; }
        public string ImagePath { get; set; }
        public DateTime Date { get; set; }
    }
}
