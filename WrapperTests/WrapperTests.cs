﻿using System;
using System.Configuration;
using System.Threading.Tasks;
using BattlemetricsWrapper;
using BattlemetricsWrapper.ResponseModels;
using BattlemetricsWrapper.ResponseModels.GameInfoResponses.ArmA3;

namespace WrapperTests
{
    public class WrapperTests
    {
        // ArmA test server: https://www.battlemetrics.com/servers/arma3/1833029
        // Minecraft test server: https://www.battlemetrics.com/servers/minecraft/5873087
        
        private readonly BmClient _bmClient;
        public WrapperTests()
        {
            _bmClient = new BmClient(ConfigurationManager.AppSettings["Token"]);
        }
        
        public async Task BeginTests()
        {
            await TestServerInfos();
        }
        
        private async Task TestServerInfos()
        {
            var genericServerInfo = await _bmClient.GetServerInfoAsync<ServerInfo>("1833029");
            var armaServerInfo = await _bmClient.GetServerInfoAsync<Arma3Info>("1833029");
            Console.WriteLine($"Name: {genericServerInfo.Data.Attributes.Name} | Active Players: {genericServerInfo.Data.Attributes.Players}");
            Console.WriteLine($"Name: {armaServerInfo.Data.Attributes.Name} | Active Players: {armaServerInfo.Data.Attributes.Players} | Map: {armaServerInfo.Data.Attributes.Details.Map}");
        }
    }
}