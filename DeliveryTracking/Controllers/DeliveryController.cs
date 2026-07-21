using DeliveryTracking.Models;
using DeliveryTracking.Service;
using Microsoft.AspNetCore.Mvc;

namespace DeliveryTracking.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DeliveryController(IDeliveryService service) : ControllerBase
    {
        private readonly IDeliveryService _service = service;

        [HttpGet]
        public ActionResult GetAllDelivery()
        {
            return Ok(_service.FindAll());
        }
        [HttpGet("{id}")]
        public ActionResult GetDeliveryById(int id)
        {
            return Ok(_service.FindById(id));
        }
        [HttpPost]
        public IActionResult RegisterDelivery([FromBody] Delivery delivery)
        {
            return Ok(_service.Register(delivery));
        }
        
         
    }
}
