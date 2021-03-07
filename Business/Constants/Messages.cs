using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {

        public static string CarAdded = "Araba eklendi.";
        public static string CarDeleted = "Araba silindi.";
        public static string CarUpdated = "Araba güncellendi.";
        public static string CarsListed = "Arabalar listelendi.";

        public static string BrandAdded = "Marka eklendi.";
        public static string BrandsListed = "Markalar listelendi.";
        public static string BrandDeleted = "Marka silindi!";
        public static string BrandUpdated = "Marka güncellendi.";
        public static string BrandNameValid = "Marka ismi en az 2 karakter olmalıdır.";

        public static string RentalInvalid = "Araba teslim edilmediği için araba kiralanamaz !";
        public static string RentalAdded = "İşlem başarılı, araba kiralandı.";
        public static string RentalDeleted = "Kiralama işlemi silindi.";
        public static string RentalListed = "Kiralamalar listelendi.";
        public static string RentalUpdated = "Kiralama işlemi güncellendi.";
        

        public static string UserNameInvalid = "Kullanıcı ismi geçersiz! Kullanıcı ismi en az 2 karakter olmalıdır.";
        public static string UserNameAdded = "Kullanıcı eklendi.";
        public static string UserDeleted = "Kullanıcı silindi.";
        public static string UserListed = "Kullanıcılar listelendi.";
        public static string UserUpdated = "Kullanıcı güncellendi.";


        public static string ColorAdded = "Renk eklendi.";
        public static string ColorDeleted = "Renk silindi.";
        public static string ColorsListed = "Renkler listelendi.";
        public static string ColorUpdated = "Renk güncellendi.";

        public static string MaintenanceTime = "Sistem bakımda";

        public static string CustomerAdded="Müşteri eklendi.";
        public static string CustomerDeleted = "Müşteri silindi.";
        public static string CustomerUpdated = "Müşteri güncellendi.";
        public static string CustomerListed = "Müşteriler listelendi.";
       
    }
}

