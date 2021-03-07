using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Business.Constants;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _branService;

         public BrandManager(IBrandDal brandDal)
         {
            _branService = brandDal;
         }
       
        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>(_branService.GetAll(),Messages.BrandsListed);
        }

      
        public IResult Add(Brand brand)
        {

            _branService.Add(brand);
            return new SuccessResult(Messages.BrandAdded);
        }

        public IResult Delete(Brand brand)
        {
            _branService.Delete(brand);
            return new SuccessResult(Messages.BrandDeleted);
        }

        public IResult Update(Brand brand)
        {
            _branService.Update(brand);
            return new SuccessResult(Messages.BrandUpdated);
        }

        public IDataResult<Brand> GetById(int brandId)
        {

            return new SuccessDataResult<Brand>(_branService.Get(b => b.BrandId == brandId));

        }
    }
   
}

