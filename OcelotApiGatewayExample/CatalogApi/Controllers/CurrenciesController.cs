using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Logging;

namespace CatalogApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CurrenciesController : ControllerBase
    {

        [Authorize]
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "usd", "inr", "jpy" };
        }
    }
}