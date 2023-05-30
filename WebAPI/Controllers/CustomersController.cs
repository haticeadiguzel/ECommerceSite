using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        ICustomerService _custegoryService;

        public CustomersController(ICustomerService custegoryService) //dependency injection
        {
            _custegoryService = custegoryService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _custegoryService.GetAll();
            if (result.Success)
            {
                return Ok(result); //200
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(string id)
        {
            var result = _custegoryService.GetById(id);
            if (result.Success)
            {
                return Ok(result); //200
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Customer customer)
        {
            var result = _custegoryService.Add(customer);
            if (result.Success)
            {
                return Ok(result); //200
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Customer customer)
        {
            var result = _custegoryService.Delete(customer);
            if (result.Success)
            {
                return Ok(result); //200
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Customer customer)
        {
            var result = _custegoryService.Update(customer);
            if (result.Success)
            {
                return Ok(result); //200
            }
            return BadRequest(result);
        }

    }
}
