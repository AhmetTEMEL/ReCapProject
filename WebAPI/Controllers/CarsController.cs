using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        ICarService carService;

        public CarsController(ICarService carService)
        {
            this.carService = carService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result= carService.Get();
            if (result.Success) 
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("addcar")]

        public IActionResult AddCar(Car car)
        {
           var result = carService.Add(car);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("deletecar")]

        public IActionResult DeleteCar(Car car)
        {
            var result = carService.Delete(car);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("updatecar")]

        public IActionResult UpdateCar(Car car)
        {
            var result = carService.Update(car);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("getcardetails")]

        public IActionResult GetCarDetails()
        {
            var result = carService.GetCarDetails();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }


    }
}
