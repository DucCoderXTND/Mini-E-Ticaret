
using ETicaretAPI.Application.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductWriteRepository _productWrite;
        private readonly IProductReadRepository _productRead;

        public ProductsController(IProductWriteRepository productWrite, IProductReadRepository productRead)
        {
            _productWrite = productWrite;
            _productRead = productRead;
        }
        [HttpGet]
        public async void Get()
        {
            await _productWrite.AddRangeAsync(new()
            {
                new(){Id = Guid.NewGuid(), Name = "Product 1", Price = 100, CreatedDate = DateTime.UtcNow, Stock = 10},
                new(){Id = Guid.NewGuid(), Name = "Product 2", Price = 200, CreatedDate = DateTime.UtcNow, Stock = 20},
                new(){Id = Guid.NewGuid(), Name = "Product 3", Price = 300, CreatedDate = DateTime.UtcNow, Stock = 30},
                new(){Id = Guid.NewGuid(), Name = "Product 4", Price = 400, CreatedDate = DateTime.UtcNow, Stock = 40},
            });
           var count = await _productWrite.SaveAsync();
        }
    }
}
