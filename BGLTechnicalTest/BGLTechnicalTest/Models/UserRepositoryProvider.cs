using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BGLTechnicalTest.Models
{
    public class UserRepositoryProvider : UserRepositorySearchBase
    {
        private readonly UserRepositoryAutomator automator;
        private readonly UserRepositoryParser parser;

        public UserRepositoryProvider()
        {
            automator = new UserRepositoryAutomator();
            parser = new UserRepositoryParser();
        }

        public override PageResponse GetUserRepositoryResponse(PageRequest request)
        {
            PageResponse response = automator.GetUserRepositoryResponse(request);
            return parser.GetUserRepositoryResults(response);
        }
    }
}
