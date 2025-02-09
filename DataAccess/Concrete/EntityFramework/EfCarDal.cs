﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //NuGet
    public class EfCarDal : EfEntityRepositoryBase<Car, RentContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetailDto()
        {
            using (RentContext context=new RentContext())
            {
                var result =
                            from c in context.Cars
                            join b in context.Brands
                            on c.BrandId equals b.BrandId
                            join clr in context.Colors
                            on c.ColorId equals clr.ColorId
                            select new CarDetailDto
                            {
                                Id = c.Id,
                                BrandName = b.BrandName,
                                ColorName = clr.ColorName,
                                DailyPrice = c.DailyPrice,
                                Description=c.Description,
                                ModelYear=c.ModelYear

                            };
                return result.ToList();
            }      
        }

    }
}
