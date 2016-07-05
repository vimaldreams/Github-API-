using BGLTechnicalTest.Models.Interfaces;
using BGLTechnicalTest.Utilities;

namespace BGLTechnicalTest.Models
{
    public class UserPageAutomator : IUserPageAutomator
    {
        public UserPageAutomator()
        { 
        
        }

        public PageResponse GetUserPageResponse(PageRequest request)
        {
            PageResponse pageResponse = new PageResponse();

            var webScrapeClient = new WebScrapeClient();
            var webResponse = webScrapeClient.Get(request.rawUrl);
            pageResponse.jsonValue = webResponse.Value;

            return pageResponse;
        }
    }
}
