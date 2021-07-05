﻿using System.Threading.Tasks;
using BattlemetricsWrapper.ResponseModels;

namespace BattlemetricsWrapper.Interfaces
{
    internal interface IService
    {
        /// <summary>
        /// Client request for getting server information
        /// </summary>
        /// <param name="serverId"></param>
        /// <returns></returns>
        Task<ServerInfoResponse> GetServerInfo(string serverId);
    }
}