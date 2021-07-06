using System;
using BattlemetricsWrapper.Interfaces;
using Newtonsoft.Json;

namespace BattlemetricsWrapper.ResponseModels.SpecificServerInfo
{
    public sealed class MinecraftInfo : IServerInfo
    {
        /// <summary>
        /// Main game Data
        /// </summary>
        [JsonProperty("data")]
        public McData Data { get; set; }

        /// <summary>
        /// Any additional included info by the api
        /// </summary>
        [JsonProperty("included")]
        public object[] Included { get; set; }
    }

    public sealed class McData
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
        public McAttributes Attributes { get; set; }

        /// <summary>
        /// Server data relationships (game info)
        /// </summary>
        [JsonProperty("relationships")]
        public McRelationships Relationships { get; set; }
    }

    public sealed class McAttributes
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
        public McDetails Details { get; set; }

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

    public sealed class McDetails
    {
        /// <summary>
        /// Cleaned minecraft server description
        /// </summary>
        [JsonProperty("minecraft_clean_description")]
        public string MinecraftCleanDescription { get; set; }

        /// <summary>
        /// Full minecraft server description
        /// </summary>
        [JsonProperty("minecraft_description")]
        public string MinecraftDescription { get; set; }

        /// <summary>
        /// Minecraft server version
        /// </summary>
        [JsonProperty("minecraft_version")]
        public MinecraftVersion MinecraftVersion { get; set; }

        /// <summary>
        /// If the Minecraft server is modded
        /// </summary>
        [JsonProperty("minecraft_modded")]
        public bool MinecraftModded { get; set; }

        /// <summary>
        /// Minecraft server hash
        /// </summary>
        [JsonProperty("minecraft_hash")]
        public string MinecraftHash { get; set; }

        /// <summary>
        /// Minecraft server version name
        /// </summary>
        [JsonProperty("minecraft_version_name")]
        public string MinecraftVersionName { get; set; }
    }

    public sealed class MinecraftVersion
    {
        /// <summary>
        /// Minecraft version name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Minecraft version protocol
        /// </summary>
        [JsonProperty("protocol")]
        public long Protocol { get; set; }
    }

    public sealed class McRelationships
    {
        /// <summary>
        /// Game class holder the server is hosting
        /// </summary>
        [JsonProperty("game")]
        public McGame Game { get; set; }

        /// <summary>
        /// Contains Meta and Game data
        /// </summary>
        [JsonProperty("serverGroup")]
        public McServerGroup ServerGroup { get; set; }
    }

    public sealed class McGame
    {
        /// <summary>
        /// Game data for the returned game details
        /// </summary>
        [JsonProperty("data")]
        public McGameData Data { get; set; }
    }

    public sealed class McGameData
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

    public class McServerGroup
    {
        /// <summary>
        /// Meta information
        /// </summary>
        [JsonProperty("meta")]
        public McMeta Meta { get; set; }
    }

    public class McMeta
    {
        /// <summary>
        /// Leader flag
        /// </summary>
        [JsonProperty("leader")]
        public bool Leader { get; set; }
    }
}