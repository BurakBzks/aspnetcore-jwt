using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        [HttpGet]
        [HttpGet, Authorize(Roles = "Manager")]
        public IEnumerable<string> Get()
            => new string[] { "burak", "bzks" };
    }
}
