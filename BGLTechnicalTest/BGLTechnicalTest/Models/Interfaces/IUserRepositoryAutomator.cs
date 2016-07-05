using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace BGLTechnicalTest.Models.Interfaces
{
    public interface IUserRepositoryAutomator 
    {
        PageResponse GetUserRepositoryResponse(PageRequest request);
    }
}