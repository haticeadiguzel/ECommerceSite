using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController] //atribute, bir class ile ilgili bilgi verme, onu imzalama yöntemidir.
    public class ProductsController : ControllerBase
    {
        //loosely coupled
        IProductService _productService; //bu bir field, _ ile başlar

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("getall")] //bu bir get requesti
        public IActionResult GetAll()
        {
            var result = _productService.GetAll();
            if (result.Success)
            {
                return Ok(result); //200
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Product product)
        {
            var result = _productService.Add(product);
            if (result.Success)
            {
                return Ok(result); //200
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _productService.GetById(id);
            if (result.Success)
            {
                return Ok(result); //200
            }
            return BadRequest(result);
        }
    }
}
