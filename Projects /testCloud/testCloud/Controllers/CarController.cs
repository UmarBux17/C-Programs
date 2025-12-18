using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using testCloud.Models;
using testCloud.Models;
using testCloud.Services;

namespace YourAppName.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarController : ControllerBase
    {
        private readonly ICarService _carService;

        public CarController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Car>> GetCars()
        {
            var cars = _carService.GetCars();
            return Ok(cars);
        }

        [HttpGet("{id}")]
        public ActionResult<Car> GetCarById(int id)
        {
            var car = _carService.GetCarById(id);
            if (car == null)
            {
                return NotFound();
            }
            return Ok(car);
        }

        [HttpPost]
        public ActionResult<Car> CreateCar(Car car)
        {
            var createdCar = _carService.CreateCar(car);
            return CreatedAtAction(nameof(GetCarById), new { id = createdCar.CarId }, createdCar);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateCar(int id, Car car)
        {
            if (id != car.CarId)
            {
                return BadRequest();
            }

            var existingCar = _carService.GetCarById(id);
            if (existingCar == null)
            {
                return NotFound();
            }

            _carService.UpdateCar(car);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCar(int id)
        {
            var car = _carService.GetCarById(id);
            if (car == null)
            {
                return NotFound();
            }

            _carService.DeleteCar(car);

            return NoContent();
        }
    }
}



