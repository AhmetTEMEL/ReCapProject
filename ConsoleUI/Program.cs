using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
           // BrandTest();

            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var item in carManager.GetCarDetails())
            {
                Console.WriteLine(item.CarId + " "+ item.BrandName + " "+item.CarName+" "+item.ColorNamme
                    +" "+item.DailyPrice);
            }
           
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Delete(new Brand { Id = 10 });
        }
    }
}
