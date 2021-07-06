using Newtonsoft.Json;

namespace BattlemetricsWrapper.ResponseModels
{
    public class GameInfo
    {
        /// <summary>
        /// Game info data
        /// </summary>
        [JsonProperty("data")]
        public GameInfoData Data { get; set; }
    }

    public class GameInfoData
    {
        /// <summary>
        /// Game id
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Game type
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Game info attributes
        /// </summary>
        [JsonProperty("attributes")]
        public GameInfoAttributes Attributes { get; set; }
    }

    public class GameInfoAttributes
    {
        /// <summary>
        /// Game name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Game metadata
        /// </summary>
        [JsonProperty("metadata")]
        public GameInfoMetadata Metadata { get; set; }

        /// <summary>
        /// Current players online in the game
        /// </summary>
        [JsonProperty("players")]
        public long Players { get; set; }

        /// <summary>
        /// Current server count on battlemetrics
        /// </summary>
        [JsonProperty("servers")]
        public long Servers { get; set; }

        /// <summary>
        /// Servers by country data
        /// </summary>
        [JsonProperty("serversByCountry")]
        public ErsByCountry ServersByCountry { get; set; }

        /// <summary>
        /// Players by country data
        /// </summary>
        [JsonProperty("playersByCountry")]
        public ErsByCountry PlayersByCountry { get; set; }

        /// <summary>
        /// Max player count in the last 30 days
        /// </summary>
        [JsonProperty("maxPlayers30D")]
        public long MaxPlayers30D { get; set; }

        /// <summary>
        /// Max player count in the last 7 days
        /// </summary>
        [JsonProperty("maxPlayers7D")]
        public long MaxPlayers7D { get; set; }

        /// <summary>
        /// Max player count in the last 24 hours
        /// </summary>
        [JsonProperty("maxPlayers24H")]
        public long MaxPlayers24H { get; set; }

        /// <summary>
        /// Min player count in the last 30 days
        /// </summary>
        [JsonProperty("minPlayers30D")]
        public long MinPlayers30D { get; set; }

        /// <summary>
        /// Min player count in the last 7 days
        /// </summary>
        [JsonProperty("minPlayers7D")]
        public long MinPlayers7D { get; set; }

        /// <summary>
        /// Min player count in the last 24 hours
        /// </summary>
        [JsonProperty("minPlayers24H")]
        public long MinPlayers24H { get; set; }
    }

    public class GameInfoMetadata
    {
        /// <summary>
        /// Game app id
        /// </summary>
        [JsonProperty("appid")]
        public long Appid { get; set; }

        /// <summary>
        /// Game directory on battlemetrics
        /// </summary>
        [JsonProperty("gamedir")]
        public string Gamedir { get; set; }

        /// <summary>
        /// If there is no visible playerlist
        /// </summary>
        [JsonProperty("noPlayerList")]
        public bool NoPlayerList { get; set; }
    }

    public class ErsByCountry
    {
        /// <summary>
        /// United States of America
        /// </summary>
        [JsonProperty("US")]
        public long Us { get; set; }

        /// <summary>
        /// Canada
        /// </summary>
        [JsonProperty("CA")]
        public long Ca { get; set; }

        /// <summary>
        /// Great Britain
        /// </summary>
        [JsonProperty("GB")]
        public long Gb { get; set; }
    }
}