﻿using BGLTechnicalTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BGLTechnicalTest.Models.Interfaces
{
    public interface IUserAutomator
    {
        PageResponse GetUserPageResponse(PageRequest request);
    }
}
