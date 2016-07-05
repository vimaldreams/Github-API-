using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BGLTechnicalTest.Models
{
    public class UserPageProvider : UserPageSearchBase
    {
        private readonly UserPageAutomator automator;
        private readonly UserPageParser parser;

        public UserPageProvider()
        {
            automator = new UserPageAutomator();
            parser = new UserPageParser();
        }

        public override PageResponse GetUserAvailabilityResponse(PageRequest request)
        {
            PageResponse response = automator.GetUserPageResponse(request);
            return parser.GetUserPageResults(response); 
        }
    }
}
