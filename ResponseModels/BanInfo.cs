using System;
using Newtonsoft.Json;

namespace BattlemetricsWrapper.ResponseModels
{
    public class BanInfo
    {
        /// <summary>
        /// Main ban info data
        /// </summary>
        [JsonProperty("data")]
        public BanInfoData Data { get; set; }
    }

    public class BanInfoData
    {
        /// <summary>
        /// Ban info type
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Ban id
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Ban info attributes
        /// </summary>
        [JsonProperty("attributes")]
        public BanInfoAttributes Attributes { get; set; }

        /// <summary>
        /// Ban info meta data
        /// </summary>
        [JsonProperty("meta")]
        public BanInfoMeta Meta { get; set; }

        /// <summary>
        /// Relationships to the banned info
        /// </summary>
        [JsonProperty("relationships")]
        public BanInfoRelationships Relationships { get; set; }
    }

    public class BanInfoAttributes
    {
        /// <summary>
        /// Ban id, typically the  same as the one in Data
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// User uid
        /// </summary>
        [JsonProperty("uid")]
        public string Uid { get; set; }

        /// <summary>
        /// DateTime of the ban
        /// </summary>
        [JsonProperty("timestamp")]
        public DateTimeOffset Timestamp { get; set; }

        /// <summary>
        /// Reason for the ban
        /// </summary>
        [JsonProperty("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// Optional note attached to the ban
        /// </summary>
        [JsonProperty("note")]
        public string Note { get; set; }

        /// <summary>
        /// DateTime if the ban expires
        /// </summary>
        [JsonProperty("expires")]
        public DateTimeOffset Expires { get; set; }

        /// <summary>
        /// Banned user identifiers
        /// </summary>
        [JsonProperty("identifiers")]
        public BanInfoIdentifierClass[] Identifiers { get; set; }

        /// <summary>
        /// If the ban is organization wide
        /// </summary>
        [JsonProperty("orgWide")]
        public bool OrgWide { get; set; }

        /// <summary>
        /// If the ban is auto added
        /// </summary>
        [JsonProperty("autoAddEnabled")]
        public bool AutoAddEnabled { get; set; }

        /// <summary>
        /// Nullable bool for native enabled
        /// </summary>
        [JsonProperty("nativeEnabled")]
        public object NativeEnabled { get; set; }
    }

    public class BanInfoIdentifierClass
    {
        /// <summary>
        /// Type of identifier
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Identifier value
        /// </summary>
        [JsonProperty("identifier")]
        public string Identifier { get; set; }

        /// <summary>
        /// Manual identifier
        /// </summary>
        [JsonProperty("manual")]
        public bool Manual { get; set; }
    }

    public class BanInfoMeta
    {
        /// <summary>
        /// Player name
        /// </summary>
        [JsonProperty("player")]
        public string Player { get; set; }
    }

    public class BanInfoRelationships
    {
        /// <summary>
        /// Relationship to the BanList data for the player
        /// </summary>
        [JsonProperty("player")]
        public BanInfoBanList Player { get; set; }

        /// <summary>
        /// Relationship to the BanList data for the server
        /// </summary>
        [JsonProperty("server")]
        public BanInfoBanList Server { get; set; }

        /// <summary>
        /// Relationship to the BanList data for the organization
        /// </summary>
        [JsonProperty("organization")]
        public BanInfoBanList Organization { get; set; }

        /// <summary>
        /// Relationship to the BanList data for the user
        /// </summary>
        [JsonProperty("user")]
        public BanInfoBanList User { get; set; }

        /// <summary>
        /// Relationship to the BanList data for the banlist
        /// </summary>
        [JsonProperty("banList")]
        public BanInfoBanList BanList { get; set; }

        /// <summary>
        /// Relationship to the BanList data for the trigger
        /// </summary>
        [JsonProperty("trigger")]
        public BanInfoBanList Trigger { get; set; }
    }

    public class BanInfoBanList
    {
        /// <summary>
        /// Links to the BanListData from the relationship
        /// </summary>
        [JsonProperty("data")]
        public BanInfoBanListData Data { get; set; }
    }

    public class BanInfoBanListData
    {
        /// <summary>
        /// Data type
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Data id
        /// </summary>
        [JsonProperty("id")]
        public BanInfoId Id { get; set; }
    }

    public struct BanInfoId
    {
        public long? Integer;
        public Guid? Uuid;

        public static implicit operator BanInfoId(long integer) => new BanInfoId {Integer = integer};
        public static implicit operator BanInfoId(Guid uuid) => new BanInfoId {Uuid = uuid};
    }
}