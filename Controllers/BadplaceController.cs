using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using stalquer_server.Models;

namespace stalquer_server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BadPlaceController : ControllerBase
    {
        private IBadplaceResponseList _badplaceResponseList;
        public BadPlaceController(IBadplaceResponseList badplaceResponseList)
        {
            _badplaceResponseList = badplaceResponseList;
        }

        [HttpGet]
        public IEnumerable<BadPlaceResponse> Get()
        {
            return _badplaceResponseList.BadplaceResponses;
        }
    }
}
