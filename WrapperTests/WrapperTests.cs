using System;
using System.Configuration;
using System.Threading.Tasks;
using BattlemetricsWrapper;
using BattlemetricsWrapper.ResponseModels;
using BattlemetricsWrapper.ResponseModels.GameInfoResponses;

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
            Console.WriteLine("\n");
            await TestGameInfo();
        }
        
        private async Task TestServerInfos()
        {
            var genericServerInfo = await _bmClient.GetServerInfoAsync<ServerInfo>("1833029");
            Console.WriteLine($"Name: {genericServerInfo.Data.Attributes.Name} | Active Players: {genericServerInfo.Data.Attributes.Players}");
            
            var arma3ServerInfo = await _bmClient.GetServerInfoAsync<Arma3Info>("1833029");
            Console.WriteLine($"Name: {arma3ServerInfo.Data.Attributes.Name} | Active Players: {arma3ServerInfo.Data.Attributes.Players} | Map {arma3ServerInfo.Data.Attributes.Details.Map}");

            var minecraftServerInfo = await _bmClient.GetServerInfoAsync<MinecraftInfo>("5873087");
            Console.WriteLine($"Name: {minecraftServerInfo.Data.Attributes.Name} | Active PLayers: {minecraftServerInfo.Data.Attributes.Players} | Clean desc: " +
                              $"{minecraftServerInfo.Data.Attributes.Details.MinecraftCleanDescription.Replace("\n", " ")}");
        }

        private async Task TestGameInfo()
        {
            var minecraftGameInfo = await _bmClient.GetGameInfoAsync("minecraft");
            Console.WriteLine($"Name: {minecraftGameInfo.Data.Attributes.Name} | Max players 24H: {minecraftGameInfo.Data.Attributes.MaxPlayers24H} | " +
                              $"Players online currently in the USA: {minecraftGameInfo.Data.Attributes.PlayersByCountry.Us}");

            var rustGameInfo = await _bmClient.GetGameInfoAsync("rust");
            Console.WriteLine($"Name: {rustGameInfo.Data.Attributes.Name} | Max players 24H: {rustGameInfo.Data.Attributes.MaxPlayers24H} | " +
                              $"Players online currently in the USA: {rustGameInfo.Data.Attributes.PlayersByCountry.Us}");
            
            var arkGameInfo = await _bmClient.GetGameInfoAsync("ark");
            Console.WriteLine($"Name: {arkGameInfo.Data.Attributes.Name} | Max players 24H: {arkGameInfo.Data.Attributes.MaxPlayers24H} | " +
                              $"Players online currently in the USA: {arkGameInfo.Data.Attributes.PlayersByCountry.Us}");
        }
    }
}