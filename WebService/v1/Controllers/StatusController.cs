﻿// Copyright (c) Microsoft. All rights reserved.

using System.Web.Http;
using Microsoft.Azure.IoTSolutions.DeviceSimulation.WebService.v1.Models;
using Microsoft.Web.Http;

namespace Microsoft.Azure.IoTSolutions.DeviceSimulation.WebService.v1.Controllers
{
    [ApiVersion(Version.Number)]
    public sealed class StatusController : ApiController
    {
        public StatusApiModel Get()
        {
            return new StatusApiModel(true, "Alive and well");
        }
    }
}
