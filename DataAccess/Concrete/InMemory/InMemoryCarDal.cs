using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1,BrandId=5,ColorId=12,ModelYear=2020,DailyPrice=10000,Description="Ford fiesta"},
                new Car{Id=2,BrandId=2,ColorId=15,ModelYear=2019,DailyPrice=20000,Description="volswagen Polo"},
                new Car{Id=3,BrandId=1,ColorId=142,ModelYear=2021,DailyPrice=3000,Description="Mercedes-AMG"},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {

            Car carToDelete = null;
            carToDelete = _cars.SingleOrDefault(c=>c.Id==car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }


        public List<Car> GetAllById(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();
        }


        public void Update(Car car)
        {
            //Gönderdiğim ürün Id sine sahip olan listediki ürün bul
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
