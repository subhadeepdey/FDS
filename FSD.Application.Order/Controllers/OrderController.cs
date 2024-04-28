using Microsoft.AspNetCore.Mvc;

namespace FSD.Application.Order.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {

        public OrderController()
        {
        }

        [HttpPost]
        [Route("orders")]
        public async Task<IActionResult> GetOrders()
        {
            throw new NotImplementedException();
        }
    }
}
