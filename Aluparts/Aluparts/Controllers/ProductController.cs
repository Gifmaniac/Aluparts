using BLL.Services;
using Microsoft.AspNetCore.Mvc;

namespace Aluparts.Controllers
{
    [ApiController]

    [Route("api/store/product")]
    public class ProductController(ProductService service) : ControllerBase
    {
        public IActionResult GetProductById([FromQuery] int id)
        {
            
        }
    }
}
