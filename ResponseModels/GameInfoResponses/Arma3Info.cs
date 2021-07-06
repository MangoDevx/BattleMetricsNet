using System;
using BattlemetricsWrapper.Interfaces;
using Newtonsoft.Json;

namespace BattlemetricsWrapper.ResponseModels.GameInfoResponses
{
    public class Arma3Info : IServerInfo
    {
        [JsonProperty("data")] public Arma3InfoData Data { get; set; }

        [JsonProperty("included")] public object[] Included { get; set; }
    }

    public class Arma3InfoData
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

        [JsonProperty("address")] public object Address { get; set; }

        [JsonProperty("ip")] public string Ip { get; set; }

        [JsonProperty("port")] public long Port { get; set; }

        [JsonProperty("players")] public long Players { get; set; }

        [JsonProperty("maxPlayers")] public long MaxPlayers { get; set; }

        [JsonProperty("rank")] public long Rank { get; set; }

        [JsonProperty("location")] public double[] Location { get; set; }

        [JsonProperty("status")] public string Status { get; set; }

        [JsonProperty("details")] public Details Details { get; set; }

        [JsonProperty("private")] public bool Private { get; set; }

        [JsonProperty("createdAt")] public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("updatedAt")] public DateTimeOffset UpdatedAt { get; set; }

        [JsonProperty("portQuery")] public long PortQuery { get; set; }

        [JsonProperty("country")] public string Country { get; set; }

        [JsonProperty("queryStatus")] public string QueryStatus { get; set; }
    }

    public class Details
    {
        [JsonProperty("map")] public string Map { get; set; }

        [JsonProperty("mission")] public string Mission { get; set; }

        [JsonProperty("gameid")] public long Gameid { get; set; }

        [JsonProperty("version")] public string Version { get; set; }

        [JsonProperty("sigs")] public string[] Sigs { get; set; }

        [JsonProperty("modNames")] public object[] ModNames { get; set; }

        [JsonProperty("modHashes")] public object[] ModHashes { get; set; }

        [JsonProperty("modIds")] public object[] ModIds { get; set; }

        [JsonProperty("thirdPerson")] public bool ThirdPerson { get; set; }

        [JsonProperty("advancedFlightMode")] public bool AdvancedFlightMode { get; set; }

        [JsonProperty("difficultyAI")] public long DifficultyAi { get; set; }

        [JsonProperty("difficultyLevel")] public long DifficultyLevel { get; set; }

        [JsonProperty("crosshair")] public bool Crosshair { get; set; }

        [JsonProperty("serverSteamId")] public string ServerSteamId { get; set; }
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