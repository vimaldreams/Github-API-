using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BGLTechnicalTest.Models
{
    public class UserProvider : UserSearchBase
    {
        private readonly UserAutomator automator;
        private readonly UserParser parser;

        public UserProvider()
        {
            automator = new UserAutomator();
            parser = new UserParser();
        }

        public override PageResponse GetUserAvailabilityResponse(PageRequest request)
        {
            PageResponse response = automator.GetUserPageResponse(request);
            return parser.GetUserPageResults(response); 
        }
    }
}
