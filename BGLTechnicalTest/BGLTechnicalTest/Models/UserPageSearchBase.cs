using BGLTechnicalTest.Models.Interfaces;
using BGLTechnicalTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BGLTechnicalTest.Models
{
    public abstract class UserPageSearchBase : IUserPageSearchBase
    {
        protected UserPageSearchBase()
        { 
        
        }

        public abstract PageResponse GetUserAvailabilityResponse(PageRequest request);
        
        
        public PageResponse GetUserAvailabilityLiveSearch(PageRequest request)
        {
            PageResponse searchResults = GetUserAvailabilityResponse(request);
            return searchResults;
        }        
    }
}
