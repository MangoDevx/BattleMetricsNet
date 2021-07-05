using System.Threading.Tasks;
using BattlemetricsWrapper.Interfaces;
using BattlemetricsWrapper.ResponseModels;

namespace BattlemetricsWrapper
{
    public class BmClient : IClient
    {
        private readonly string _authToken;
        private readonly BmService _bmService;

        public BmClient(string authToken)
        {
            _authToken = authToken;
            _bmService = new BmService(authToken);
        }

        public async Task<ServerInfoResponse> GetServerInfoAsync(string serverId) => await _bmService.GetServerInfo(serverId);
    }
}