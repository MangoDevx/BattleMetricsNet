using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using BattlemetricsWrapper.Interfaces;
using BattlemetricsWrapper.ResponseModels;
using Newtonsoft.Json;

namespace BattlemetricsWrapper
{
    internal class BmService : IService
    {
        private readonly HttpClient _http;
        private const string BaseUri = "https://api.battlemetrics.com";
        private const string AuthHeader = "Authorization";
        private readonly string _authKey = "Bearer ";
        private readonly JsonSerializer _serializer;


        public BmService(string authKey)
        {
            _http = new HttpClient();
            _authKey += authKey;
            _http.DefaultRequestHeaders.Add(AuthHeader, _authKey);
            _serializer = new JsonSerializer();
        }

        public async Task<T> GetServerInfo<T>(string serverId) where T : IServerInfo => await Get<T>("servers", serverId);

        public async Task<GameInfo> GetGameInfo(string gameId) => await Get<GameInfo>("games", gameId.ToLower());

        private async Task<T> Get<T>(params string[] paths)
        {
            using var response = await _http.GetAsync(BuildUri(paths)).ConfigureAwait(false);
            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                throw new BMException(error);
            }

            var content = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
            return ProcessStream<T>(content);
        }

        private string BuildUri(params string[] paths) => $"{BaseUri}/{string.Join("/", paths)}";

        private T ProcessStream<T>(Stream stream)
        {
            using var reader = new StreamReader(stream);
            using var jsonReader = new JsonTextReader(reader);
            return _serializer.Deserialize<T>(jsonReader);
        }
    }
}