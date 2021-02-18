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
            // CarTest();
            //AddUser();
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            customerManager.Add(new Customer { Id=1,UserId=1,CompanyName="Anadolu Sigorta"});

        }

        private static void AddUser()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            userManager.Add(new User { Id = 1, Email = "ahmetemel@hotmail.com", FirstName = "Ahmet", LastName = "Temel", Password = "1234" });
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var item in carManager.GetCarDetails().Data)
            {
                Console.WriteLine(item.CarId + " " + item.BrandName + " " + item.CarName + " " + item.ColorNamme
                    + " " + item.DailyPrice);
            }
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Delete(new Brand { Id = 10 });
        }
    }
}
