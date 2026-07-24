using DeliveryTracking.Models;
using DeliveryTracking.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace DeliveryTracking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController(IEmployeeService service, ILogger<EmployeeController> logger) : ControllerBase
    {
        private readonly IEmployeeService _service = service;
        private readonly ILogger<EmployeeController> _logger = logger;

        [HttpGet]
        public ActionResult GetAllEmployee()
        {
            return Ok(_service.FindAll());
        }
        [HttpGet("{id}")]
        public ActionResult GetEmployeeById(int id)
        {
            return Ok(_service.FindById(id));
        }
        [HttpPost]
        public IActionResult CreateEmployee([FromBody] Employee employee)
        {
            _logger.LogInformation("Creating Employee");
            return Ok(_service.Create(employee));
        }
        [HttpPut]
        public IActionResult UpdateEmployee([FromBody] Employee employee)
        {
            return Ok(_service.Update(employee));
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteEmployee(long Id)
        {
            _service.Delete(Id);
            return NoContent();
        }



    }
}
