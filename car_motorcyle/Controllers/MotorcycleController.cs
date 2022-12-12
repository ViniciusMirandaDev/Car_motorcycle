using car_motorcyle.Entities;
using car_motorcyle.Models;
using car_motorcyle.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace car_motorcyle.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MotorcycleController : ControllerBase
    {
        private IMotorcycleDapperService _service;

        public MotorcycleController(IMotorcycleDapperService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var motorcycles = _service.GetAll();
            return Ok(motorcycles);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var motorcycle = _service.GetById(id);

            if (motorcycle == null)
            {
                return NotFound();
            }

            return Ok(motorcycle);
        }

        [HttpPost]
        public IActionResult Post(InsertModel motorcycle)
        {
            _service.Insert(motorcycle);
            return Ok();
        }

        [HttpPut]
        public IActionResult Update(Motorcycle motorcycle)
        {
            _service.Update(motorcycle);
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
