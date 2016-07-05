using BGLTechnicalTest.Models.Interfaces;
using BGLTechnicalTest.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BGLTechnicalTest.Models
{
    public class UserRepositoryAutomator : IUserRepositoryAutomator
    {
        public UserRepositoryAutomator()
        {

        }

        public PageResponse GetUserRepositoryResponse(PageRequest request)
        {
            PageResponse pageResponse = new PageResponse();

            var webScrapeClient = new WebScrapeClient();
            var webResponse = webScrapeClient.Get(request.rawUrl);
            pageResponse.jsonValue = webResponse.Value;

            return pageResponse;
        }
    }
}
