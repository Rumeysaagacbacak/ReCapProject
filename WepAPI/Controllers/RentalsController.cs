﻿using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WepAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalsController : ControllerBase
    {
        
            IRentalService _rentalService;

            public RentalsController(IRentalService rentalService)
            {
                _rentalService = rentalService;
            }

            [HttpGet("getall")]
            public IActionResult GetAll()
            {
                //Dependency chain ----bağımlılık servisi
                var result = _rentalService.GetAll();
                if (result.Success)
                {
                    return Ok(result);
                }
                return BadRequest(result);
            }


            [HttpGet("")]
            public IActionResult GetByCarId(int carId)
            {
                var result = _rentalService.GetByCarId(carId);
                if (result.Success)
                {
                    return Ok(result);
                }
                return BadRequest(result);
            }


            [HttpPost("add")]
            public IActionResult Add(Rental rental)
            {
                var result = _rentalService.Add(rental);
                if (result.Success)
                {
                    return Ok(result);
                }
                return BadRequest(result);

            }
            [HttpPost("delete")]
            public IActionResult Delete(Rental rental)
            {
                var result = _rentalService.Delete(rental);
                if (result.Success)
                {
                    return Ok(result);
                }
                return BadRequest(result);
            }

            [HttpPost("update")]
            public IActionResult Update(Rental rental)
            {
                var result = _rentalService.Update(rental);
                if (result.Success)
                {
                    return Ok(result);
                }
                return BadRequest(result);
            }
        
    }
}
