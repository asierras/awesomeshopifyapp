using awesomeshopifyapp.Services;
using Microsoft.AspNetCore.Mvc;

namespace awesomeshopifyapp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShopifyController : ControllerBase
    {
        [HttpGet("install")]
        public string Install()
        {
            return "It's working";
        }
    }
}