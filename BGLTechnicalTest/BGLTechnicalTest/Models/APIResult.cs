using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BGLTechnicalTest.Models
{
    public class APIResult
    {
        public string UserName { get; set; }

        public string Location { get; set; }

        public string Avatar { get; set; }

        public List<UserRepository> Repositories { get; set; }
    }
}
