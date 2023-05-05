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

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductResponse>>> GetAll()
        {
            var products = await _productService.GetAllAsync();
            var response = products.Select(product => ProductResponse.ConvertToResponse(product));
            return Ok(response);
        }

        [HttpPost]
        public async Task<ActionResult<int>> Add(PostProductRequest request)
        {
            var product = PostProductRequest.ConvertToEntity(request);
            var id = await _productService.AddAsync(product);
            return Ok(id);
        }
    }
}
