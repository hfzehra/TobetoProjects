using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;

namespace ReCapProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            CarManager cars = new CarManager(new EfCarDal());
            //foreach (var c in cars.GetAll())
            //{
            //    Console.WriteLine(c.Description);
            //}

            //foreach (var car in cars.GetCarDetails())
            //{
            //    Console.WriteLine(car.CarName +"  -  "+car.BrandName);
            //}


            //Car araba = new Car() {id=5, BrandId=4,ColorId=6,DailyPrice=3500000}; 
            //cars.Update(araba);

        }
    }
}