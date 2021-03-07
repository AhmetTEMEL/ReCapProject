using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public class Messages
    {
        public static string BrandAdded = "Brand Ekleme başarılı";
        public static string BrandDeleted = "Brand Silme başarılı";
        public static string BrandUpdated = "Brand günceleme başarılı";
        public static string ColorAdded = "Renk Ekleme başarılı";
        public static string ColorDeleted = "Renk Silme başarılı";
        public static string ColorUpdated = "Renk günceleme başarılı";
        public static string CarAdded = "araba Ekleme başarılı";
        public static string CarDeleted = "araba Silme başarılı";
        public static string CarUpdated = "araba günceleme başarılı";

        public static string CarsListed = "Arabalar listelendi";

        public static string CarDetailsListed = "Araç detayları listelendi";

        public static string ColorsListed = "Renkler Listelendi";

        public static string CustomerAdded { get; internal set; }
        public static string CustomerDeleted { get; internal set; }
        public static string CustomerUpdated { get; internal set; }
        public static List<Customer> CustomersListed { get; internal set; }
        public static string RentalAdded { get; internal set; }
        public static string RentalDeleted { get; internal set; }
        public static string RentalUpdated { get; internal set; }
        public static List<Rental> Rentallisted { get; internal set; }
        public static string UserAdded { get; internal set; }
        public static string UserDeleted { get; internal set; }
        public static string UserUpdated { get; internal set; }
        public static List<User> UsersListed { get; internal set; }
        public static object RentalAdditonRejected { get; internal set; }
        public static string CarImageAdded = "Araba resmi yüklendi";
    }
}
