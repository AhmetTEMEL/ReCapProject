using Business.Abstract;
using Core.Utilities.Business;
using Core.Utilities.Helpers;
using Entities.Concrete;
using Microsoft.AspNetCore.Hosting;
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
        ICarImageService _carImageService;
        IWebHostEnvironment _webHostEnvironment;

        public CarsController(ICarService carService, IWebHostEnvironment webHostEnvironment,
             ICarImageService carImageService)
        {
            this.carService = carService;
            _webHostEnvironment = webHostEnvironment;
            _carImageService = carImageService;
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
        [HttpGet("getdetails")]
        public IActionResult GetDetails()
        {
            var result = carService.GetCarDetails();
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

        [HttpPost("addimage")]

        public IActionResult AddImage([FromForm] FromDataFile objectFile, [FromForm] int CarId, [FromForm] CarImage carImage,
            [FromForm] string ImagePath)
        {
            string path = _webHostEnvironment.WebRootPath;
            UploadFile.FileUpload(objectFile, path);
            carImage.CarId=CarId;
            carImage.Date = DateTime.Now;
            carImage.ImagePath = ImagePath;
         
            var result = _carImageService.Add(carImage,CarId);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }


    }
}
