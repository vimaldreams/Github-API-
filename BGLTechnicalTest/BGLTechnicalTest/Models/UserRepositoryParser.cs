using BGLTechnicalTest.Models.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BGLTechnicalTest.Models
{
    public class UserRepositoryParser : IUserRepositoryParser
    {
        public UserRepositoryParser()
        {

        }

        public PageResponse GetUserRepositoryResults(PageResponse response)
        {
            List<UserRepository> userRepoList = JsonConvert.DeserializeObject<List<UserRepository>>(response.jsonValue);
            response.userRepository = userRepoList;

            return response;
        }
    }
}
