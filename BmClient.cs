using System.Threading.Tasks;
using BattlemetricsWrapper.Interfaces;
using BattlemetricsWrapper.ResponseModels;

namespace BattlemetricsWrapper
{
    public class BmClient : IClient
    {
        private readonly BmService _bmService;

        public BmClient(string authToken)
        {
            _bmService = new BmService(authToken);
        }

        public async Task<T> GetServerInfoAsync<T>(string serverId) where T : IServerInfo => await _bmService.GetServerInfo<T>(serverId);

        public async Task<GameInfo> GetGameInfoAsync(string gameId) => await _bmService.GetGameInfo(gameId);

        public async Task<BanInfo> GetBanInfoAsync(string banId) => await _bmService.GetBanInfo(banId);
    }
}