using BGLTechnicalTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BGLTechnicalTest.Models.Interfaces
{
    public interface IUserPageSearchBase
    {
        PageResponse GetUserAvailabilityLiveSearch(PageRequest request);
    }
}
