using System;
using BattlemetricsWrapper.Interfaces;
using Newtonsoft.Json;

namespace BattlemetricsWrapper.ResponseModels.SpecificServerInfoResponses
{
    public sealed class Arma3Info : IServerInfo
    {
        /// <summary>
        /// Main game Data
        /// </summary>
        [JsonProperty("data")]
        public Arma3Data Data { get; set; }

        /// <summary>
        /// Any additional included info by the api
        /// </summary>
        [JsonProperty("included")]
        public object[] Included { get; set; }
    }

    public sealed class Arma3Data
    {
        /// <summary>
        /// Type of info should be server for server model
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Server id
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Server data attributes (server info)
        /// </summary>
        [JsonProperty("attributes")]
        public Arma3Attributes Attributes { get; set; }

        /// <summary>
        /// Server data relationships (game info)
        /// </summary>
        [JsonProperty("relationships")]
        public Arma3Relationships Relationships { get; set; }
    }

    public sealed class Arma3Attributes
    {
        /// <summary>
        /// Same as id in Data
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Server name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Connection address
        /// </summary>
        [JsonProperty("address")]
        public object Address { get; set; }

        /// <summary>
        /// Ip address
        /// </summary>
        [JsonProperty("ip")]
        public string Ip { get; set; }

        /// <summary>
        /// Port number
        /// </summary>
        [JsonProperty("port")]
        public long Port { get; set; }

        /// <summary>
        /// Port query
        /// </summary>
        [JsonProperty("portQuery")]
        public long PortQuery { get; set; }

        /// <summary>
        /// Current amount of active players in the server
        /// </summary>
        [JsonProperty("players")]
        public long Players { get; set; }

        /// <summary>
        /// Max players allowed to connect to the server
        /// </summary>
        [JsonProperty("maxPlayers")]
        public long MaxPlayers { get; set; }

        /// <summary>
        /// Server's listing rank
        /// </summary>
        [JsonProperty("rank")]
        public long Rank { get; set; }

        /// <summary>
        /// Locational coordinates
        /// </summary>
        [JsonProperty("location")]
        public double[] Location { get; set; }

        /// <summary>
        /// Server status. Online, offline, etc
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Ingame details
        /// </summary>
        [JsonProperty("details")]
        public Arma3Details Details { get; set; }

        /// <summary>
        /// Private server indicator
        /// </summary>
        [JsonProperty("private")]
        public bool Private { get; set; }

        /// <summary>
        /// Server listing creation date
        /// </summary>
        [JsonProperty("createdAt")]
        public DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// Server listing updated date
        /// </summary>
        [JsonProperty("updatedAt")]
        public DateTimeOffset UpdatedAt { get; set; }

        /// <summary>
        /// Server country
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }

        /// <summary>
        /// Query status - nullable
        /// </summary>
        [JsonProperty("queryStatus")]
        public string QueryStatus { get; set; }

        /// <summary>
        /// Optional MetaData
        /// </summary>
        [JsonProperty("metadata")]
        public object[] MetaData { get; set; }
    }

    public sealed class Arma3Details
    {
        /// <summary>
        /// The current map ingame
        /// </summary>
        [JsonProperty("map")]
        public string Map { get; set; }

        /// <summary>
        /// The current mission ingame
        /// </summary>
        [JsonProperty("mission")]
        public string Mission { get; set; }

        /// <summary>
        /// The ingame game id
        /// </summary>
        [JsonProperty("gameid")]
        public long Gameid { get; set; }

        /// <summary>
        /// The game server version
        /// </summary>
        [JsonProperty("version")]
        public string Version { get; set; }

        /// <summary>
        /// Game signatures
        /// </summary>
        [JsonProperty("sigs")]
        public string[] Sigs { get; set; }

        /// <summary>
        /// Mod names
        /// </summary>
        [JsonProperty("modNames")]
        public object[] ModNames { get; set; }

        /// <summary>
        /// Mod hashes
        /// </summary>
        [JsonProperty("modHashes")]
        public object[] ModHashes { get; set; }

        /// <summary>
        /// Mod ids
        /// </summary>
        [JsonProperty("modIds")]
        public object[] ModIds { get; set; }

        /// <summary>
        /// Third person setting value
        /// </summary>
        [JsonProperty("thirdPerson")]
        public bool ThirdPerson { get; set; }

        /// <summary>
        /// Advanced flight mode setting value
        /// </summary>
        [JsonProperty("advancedFlightMode")]
        public bool AdvancedFlightMode { get; set; }

        /// <summary>
        /// AI difficulty level
        /// </summary>
        [JsonProperty("difficultyAI")]
        public long DifficultyAi { get; set; }

        /// <summary>
        /// Game difficulty level
        /// </summary>
        [JsonProperty("difficultyLevel")]
        public long DifficultyLevel { get; set; }

        /// <summary>
        /// Crosshairs enabled setting value
        /// </summary>
        [JsonProperty("crosshair")]
        public bool Crosshair { get; set; }

        /// <summary>
        /// Server steam id
        /// </summary>
        [JsonProperty("serverSteamId")]
        public string ServerSteamId { get; set; }
    }

    public sealed class Arma3Relationships
    {
        /// <summary>
        /// Game class holder the server is hosting
        /// </summary>
        [JsonProperty("game")]
        public Arma3Game Game { get; set; }
    }

    public sealed class Arma3Game
    {
        /// <summary>
        /// Game data for the returned game details
        /// </summary>
        [JsonProperty("data")]
        public Arma3GameData Data { get; set; }
    }

    public sealed class Arma3GameData
    {
        /// <summary>
        /// The type of service the server is hosting
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// The name of the service
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }
    }
}