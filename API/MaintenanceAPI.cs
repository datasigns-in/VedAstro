﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Genso.Astrology.Library;

namespace API
{
    /// <summary>
    /// Group of API calls related to maintaining the data integrity of the system.
    /// </summary>
    public static class MaintenanceAPI
    {
        /// <summary>
        /// Function for debugging purposes
        /// Call to see if return correct IP
        /// </summary>
        [FunctionName("getipaddress")]
        public static async Task<IActionResult> GetIpAddress([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequestMessage incomingRequest)
        {
            return APITools.PassMessage(incomingRequest?.GetCallerIp()?.ToString() ?? "no ip");
        }

    }
}