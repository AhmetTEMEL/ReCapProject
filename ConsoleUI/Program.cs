using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            BrandManager carManager = new BrandManager(new EfBrandDal());
            foreach (var Car in carManager.GetCarsByBrandId()) {
                Console.WriteLine(Car.Name);
            }
        }
    }
}
