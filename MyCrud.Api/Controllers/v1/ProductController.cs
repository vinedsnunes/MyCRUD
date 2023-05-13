using Microsoft.AspNetCore.Mvc;
using MyCrud.Application.DTOs.Reponse;
using MyCrud.Application.DTOs.Request;
using MyCrud.Domain.Interfaces.Services;

namespace MyCrud.Api.Controllers.v1
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService) =>
            _productService = productService;

        [HttpPost]
        public async Task<ActionResult<int>> Add(PostProductRequest request)
        {
            var product = PostProductRequest.ConvertToEntity(request);
            var id = await _productService.AddAsync(product);
            return Ok(id);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductResponse>>> GetAll()
        {
            var products = await _productService.GetAllAsync();
            var response = products.Select(ProductResponse.ConvertToResponse);
            return Ok(response);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<ProductResponse>> GetById(int id)
        {
            var product = await _productService.GetByIdAsync(id);
            var response = ProductResponse.ConvertToResponse(product);
            return Ok(response);
        }

        [HttpPut]
        public async Task<ActionResult<ProductResponse>> Put(PutProductRequest request)
        {
            var product = PutProductRequest.ConvertToEntity(request);
            await _productService.UpdateAsync(product);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _productService.RemoveByIdAsync(id);
            return Ok();
        }
    }
}
