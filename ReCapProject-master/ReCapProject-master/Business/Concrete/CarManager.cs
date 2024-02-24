using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        //Dependecy injection 
        ICarDal _carDal;
        public CarManager(ICarDal carService)
        {
            _carDal = carService;
        }

        public IResult Add(Car car)
        {
            if (car.DailyPrice > 0 || car.CarName.Length > 2)
            {
                _carDal.Add(car);
                return  new SuccessResult("Ürününüz eklendi");
            }
            return new ErrorResult("Ürününüz eklenemedi");
        }

        public IResult Delete(Car car)
        {
            var deletedCar = _carDal.Get(c=>c.id == car.id);
            _carDal.Delete(deletedCar);
            return new SuccessResult();
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.CarGettAll);
        }

        public IDataResult<Car> GetByIdCar(int id)
        {
            return new SuccessDataResult<Car>(_carDal.Get(c=>c.id==id));
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>( _carDal.GetCarDetails());
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.BrandId == id).OrderBy(c => c.DailyPrice).ToList());
        }

        public IDataResult<List<Car>> GetCarsByColorId(int id)
        {
            return new SuccessDataResult<List<Car>>( _carDal.GetAll(c=>c.ColorId==id));
        }

        public IResult Update(Car car)
        {
            Car car1 = _carDal.Get(c=> c.id == car.id);
            car1.DailyPrice = car.DailyPrice;
            car1.ColorId = car.ColorId;
            car1.BrandId = car.BrandId;
            _carDal.Update(car1);
            return new SuccessResult();
        }
    }
}
