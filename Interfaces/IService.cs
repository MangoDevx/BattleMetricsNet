using System.Threading.Tasks;
using BattlemetricsWrapper.ResponseModels;

namespace BattlemetricsWrapper.Interfaces
{
    internal interface IService
    {
        /// <summary>
        /// Client request for getting server information
        /// </summary>
        /// <param name="serverId"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        Task<T> GetServerInfo<T>(string serverId) where T : IServerInfo;

        /// <summary>
        /// Client request for getting game info
        /// </summary>
        /// <param name="gameId"></param>
        /// <returns></returns>
        Task<GameInfo> GetGameInfo(string gameId);

        /// <summary>
        /// Client request for getting ban info
        /// </summary>
        /// <param name="banId"></param>
        /// <returns></returns>
        Task<BanInfo> GetBanInfo(string banId);
    }
}