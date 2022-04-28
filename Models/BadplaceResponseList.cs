using System;
using System.Collections.Generic;

namespace stalquer_server.Models
{
    public class BadPlaceResponseList : IBadplaceResponseList
    {
        public IEnumerable<BadPlaceResponse> BadplaceResponses { get; set; }
    }
}