﻿using Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public interface IMajorIndexService
    {
        Task<MajorIndex> GetMajorIndex(MajorIndexType CharCode);

    }
}
