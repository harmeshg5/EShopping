using Asp.Versioning;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.API.Controllers
{
    [ApiVersion("1")]
    [Route("api/[controller]")]
    [ApiController]
    public class ApiController : ControllerBase
    {
    }
}
