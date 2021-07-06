using System;
using System.Configuration;
using System.Threading.Tasks;
using BattlemetricsWrapper;
using BattlemetricsWrapper.ResponseModels.GameInfoResponses;

namespace BattlemetricsWrapperTest
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await new Program().TestWrapper();
        }

        private BmClient _bmClient;

        private async Task TestWrapper()
        {
            _bmClient = new BmClient(ConfigurationManager.AppSettings["Token"]);
            var serverInfo = await _bmClient.GetServerInfoAsync<Arma3Info>("1833029");
            Console.WriteLine($"Server name: {serverInfo.Data.Attributes.Name} | Current Players: {serverInfo.Data.Attributes.Players}");

            Console.ReadKey();
        }
    }
}