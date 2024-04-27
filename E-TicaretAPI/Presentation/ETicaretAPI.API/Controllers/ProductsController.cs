
using ETicaretAPI.Application.Repositories;
using ETicaretAPI.Domain.Entities;
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
        private readonly IOrderWriteRepository _orderWrite;
        private readonly ICustomerWriteRepository _customerWrite;
        private readonly IOrderReadRepository _orderRead;

        public ProductsController(IProductWriteRepository productWrite,
            IProductReadRepository productRead, IOrderWriteRepository orderWrite, 
            ICustomerWriteRepository customerWrite, IOrderReadRepository orderRead)
        {
            _productWrite = productWrite;
            _productRead = productRead;
            _orderWrite = orderWrite;
            _customerWrite = customerWrite;
            _orderRead = orderRead;
        }
        [HttpGet]
        public async Task Get()
        {
            var order = await _orderRead.GetByIdAsync("8F79F7FE-180F-4FE6-3C8E-08DC66EA03CF");
            order.Description = "Anh yeu em";
            await _orderWrite.SaveAsync();
        }

    }
}
