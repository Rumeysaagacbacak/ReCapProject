using System;
using System.Dynamic;
using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
          //  CarDtoTest();
           // ColorTest();
            //BrandTest();

            //RentalTest(); bakılacak.........

        }

        private static void RentalTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            Console.WriteLine(rentalManager.Add(new Rental { RentalId = 1, CustomerId = 2, RentDate = DateTime.Now }).Message);
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine("  Brand Id:{1} \t Brand Name:{0} ", brand.BrandName,  brand.BrandId);
            }
        }


        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var color in colorManager.GetAll().Data)
            {
                Console.WriteLine(" Color Id:{1}\tColor Name:{0} ", color.ColorName, color.ColorId);
            }
        }

        private static void CarDtoTest()
        {
           // Console.WriteLine("ID\tBrandId\tGünlük Kirası\tAçıklama\n");
            Console.WriteLine("Id\t BrandId\t ColorId\t DailyPrice\t Description");
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var carDetail in carManager.GetCarDetailDto().Data)
            {
                Console.WriteLine("Araç Adı: " + carDetail.Id + "\t" + " Marka: " + carDetail.BrandName + "\t" + "Renk: " +
                                  carDetail.ColorName + "\t" + "Günlük Ücret: " + carDetail.DailyPrice + "\t" + "Açıklama:" + carDetail.Description);
            }
        }


    }
}
