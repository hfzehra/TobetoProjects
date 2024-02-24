using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public IResult Add(Brand car)
        {
            _brandDal.Add(car);
            return new SuccessResult();
        }

        public IResult Delete(Brand car)
        {
            var deletedBrand = _brandDal.Get(b=>b.BrandId == car.BrandId);
            _brandDal.Delete(deletedBrand);
            return new SuccessResult();
        }

        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>( _brandDal.GetAll(),"Tüm markalar listelendi");
        }

        public IDataResult<Brand> GetByIdBrand(int id)
        {
            return new SuccessDataResult<Brand>( _brandDal.Get(b=>id == b.BrandId));
        }

        public IResult Update(Brand car)
        {
            _brandDal.Update(car);
            return new SuccessResult();
        }
    }
}
