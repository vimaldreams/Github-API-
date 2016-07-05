using BGLTechnicalTest.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BGLTechnicalTest.Models
{
    public abstract class UserRepositorySearchBase : IUserRepositorySearchBase
    {
        protected UserRepositorySearchBase()
        {

        }
       
        public abstract PageResponse GetUserRepositoryResponse(PageRequest request);
        
        public PageResponse GetUserRepositoryLiveSearch(PageRequest request)
        {
            PageResponse searchResults = GetUserRepositoryResponse(request);
            return searchResults;
        }
    }
}
