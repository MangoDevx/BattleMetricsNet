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
        Task<TServerInfo> GetServerInfoAsync<TServerInfo>(string serverId) where TServerInfo : IServerInfo;
    }
}