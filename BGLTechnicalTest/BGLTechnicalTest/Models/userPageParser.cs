﻿using BGLTechnicalTest.Models.Interfaces;
using BGLTechnicalTest.Utilities;
using Newtonsoft.Json;
using System;

namespace BGLTechnicalTest.Models
{
    public class UserPageParser : IUserPageParser
    {
        public UserPageParser() 
        {
 
        }

        public PageResponse GetUserPageResults(PageResponse response)
        {
            UserDetail userData = JsonConvert.DeserializeObject<UserDetail>(response.jsonValue);
            response.userDetail = userData;

            return response;
        }
    }
}
