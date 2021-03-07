using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBrandDal : EfEntityRepositoryBase<Brand, RentContext>, IBrandDal
    {
        public List<Brand> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Brand> GetById(int BrandId)
        {
            throw new NotImplementedException();
        }
    }
}
