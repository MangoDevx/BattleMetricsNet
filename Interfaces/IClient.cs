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
        /// <typeparam name="TServerInfo"></typeparam>
        /// <returns></returns>
        Task<TServerInfo> GetServerInfoAsync<TServerInfo>(string serverId) where TServerInfo : IServerInfo;

        /// <summary>
        /// Gets the specified game information by game id
        /// </summary>
        /// <param name="gameId"></param>
        /// <returns></returns>
        Task<GameInfo> GetGameInfoAsync(string gameId);
    }
}