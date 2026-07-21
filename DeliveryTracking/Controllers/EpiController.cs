using DeliveryTracking.Models;
using DeliveryTracking.Service;
using Microsoft.AspNetCore.Mvc;

namespace DeliveryTracking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EpiController(IEpiService service) : ControllerBase
    {
        private readonly IEpiService _service = service;

        [HttpGet]
        public ActionResult GetAllEpi()
        {
            return Ok(_service.FindAll());
        }

        [HttpGet("{id}")]
        public ActionResult GetEpiById(int id)
        {
            return Ok(_service.FindById(id));
        }

        [HttpPost]
        public IActionResult CreateEpi([FromBody] Epi epi)
        {
            return Ok(_service.Create(epi));
        }

        [HttpPut]
        public IActionResult UpdateEpi([FromBody] Epi epi)
        {
            return Ok(_service.Update(epi));
        }

        [HttpDelete]
        public IActionResult DeleteEpi(long Id)
        {
            _service.Delete(Id);
            return NoContent();
        }
    }
}
