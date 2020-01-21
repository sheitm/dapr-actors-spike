﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IMeteringPointActor : IActor
    {
        Task ReceiveMeasurement(Measurement measurement);
    }
}
