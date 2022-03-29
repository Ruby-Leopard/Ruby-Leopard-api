using Microsoft.AspNetCore.Mvc;
using Ruby.Leopard.Domain.Catalog;

namespace Ruby.Leopard.Api.Controllers
{
    [ApiController]
    [Route("/catalog")]
    public class CatalogController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetItems()
        {
            return Ok("hello world.");
        }
    }
}


