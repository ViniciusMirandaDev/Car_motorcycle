using car_motorcyle.Entities;
using car_motorcyle.Models;
using car_motorcyle.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace car_motorcyle.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private ICarEFService _service;

        public CarController(ICarEFService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var cars = _service.GetAll();
            return Ok(cars);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var car = _service.GetById(id);

            if (car == null)
            {
                return NotFound();
            }

            return Ok(car);
        }

        [HttpPost]
        public IActionResult Post(InsertModel car)
        {
            _service.Insert(car);
            return Ok();
        }

        [HttpPut]
        public IActionResult Update(Car car)
        {
            _service.Update(car);
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _service.Delete(id);
            return Ok();
        }
    }
}
