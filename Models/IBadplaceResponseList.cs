using System;
using System.Collections.Generic;

namespace stalquer_server.Models
{
    public interface IBadplaceResponseList
    {
        public IEnumerable<BadPlaceResponse> BadplaceResponses { get; set; } 
    }
}