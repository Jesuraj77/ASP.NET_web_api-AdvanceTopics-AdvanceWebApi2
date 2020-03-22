using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AdvanceWebApi2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EtagController : ControllerBase
    {

        // code here toPerform HHTP caching.
        //Create Etag middleware and configure middleware. Run multiple scenarios
    }
}