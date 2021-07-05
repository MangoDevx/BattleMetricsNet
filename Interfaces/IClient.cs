using System.Threading.Tasks;
using BattlemetricsWrapper.ResponseModels;

namespace BattlemetricsWrapper.Interfaces
{
    public interface IClient
    {
        /// <summary>
        /// Gets the specified server information by server id
        /// </summary>
        /// <param name="serverId"></param>
        /// <returns></returns>
        Task<ServerInfoResponse> GetServerInfoAsync(string serverId);
    }
}