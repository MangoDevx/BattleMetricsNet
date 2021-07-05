using System;
using Newtonsoft.Json;

namespace BattlemetricsWrapper.ResponseModels
{
    public class ServerInfoResponse
    {
        [JsonProperty("data")] public Data Data { get; set; }

        [JsonProperty("included")] public object[] Included { get; set; }
    }

    public class Data
    {
        [JsonProperty("type")] public string Type { get; set; }

        [JsonProperty("id")] public long Id { get; set; }

        [JsonProperty("attributes")] public Attributes Attributes { get; set; }

        [JsonProperty("relationships")] public Relationships Relationships { get; set; }
    }

    public class Attributes
    {
        [JsonProperty("id")] public long Id { get; set; }

        [JsonProperty("name")] public string Name { get; set; }

        [JsonProperty("address")] public string Address { get; set; }

        [JsonProperty("ip")] public string Ip { get; set; }

        [JsonProperty("port")] public long Port { get; set; }

        [JsonProperty("portQuery")] public long PortQuery { get; set; }

        [JsonProperty("players")] public long Players { get; set; }

        [JsonProperty("maxPlayers")] public long MaxPlayers { get; set; }

        [JsonProperty("rank")] public long Rank { get; set; }

        [JsonProperty("createdAt")] public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("updatedAt")] public DateTimeOffset UpdatedAt { get; set; }

        [JsonProperty("location")] public double[] Location { get; set; }

        [JsonProperty("country")] public string Country { get; set; }

        [JsonProperty("status")] public string Status { get; set; }

        [JsonProperty("details")] public object Details { get; set; }

        [JsonProperty("metadata")] public Metadata Metadata { get; set; }

        [JsonProperty("rconActive")] public bool RconActive { get; set; }

        [JsonProperty("queryStatus")] public object QueryStatus { get; set; }

        [JsonProperty("rconStatus")] public object RconStatus { get; set; }

        [JsonProperty("rconLastConnected")] public DateTimeOffset RconLastConnected { get; set; }

        [JsonProperty("rconDisconnected")] public DateTimeOffset RconDisconnected { get; set; }

        [JsonProperty("private")] public bool Private { get; set; }
    }

    public class Metadata
    {
    }

    public class Relationships
    {
        [JsonProperty("game")] public Game Game { get; set; }
    }

    public class Game
    {
        [JsonProperty("data")] public GameData Data { get; set; }
    }

    public class GameData
    {
        [JsonProperty("type")] public string Type { get; set; }

        [JsonProperty("id")] public string Id { get; set; }
    }
}