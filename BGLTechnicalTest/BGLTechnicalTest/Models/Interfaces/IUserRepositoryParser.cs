using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BGLTechnicalTest.Models.Interfaces
{
    public interface IUserRepositoryParser
    {
        PageResponse GetUserRepositoryResults(PageResponse response);
    }
}
