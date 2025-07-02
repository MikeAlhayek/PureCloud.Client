using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum TranscriptAsyncAggregationQueryGroupByEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Addressfrom for "addressFrom"
    /// </summary>
    [EnumMember(Value = "addressFrom")]
    Addressfrom,

    /// <summary>
    /// Enum Addressto for "addressTo"
    /// </summary>
    [EnumMember(Value = "addressTo")]
    Addressto,

    /// <summary>
    /// Enum Ani for "ani"
    /// </summary>
    [EnumMember(Value = "ani")]
    Ani,

    /// <summary>
    /// Enum Channel for "channel"
    /// </summary>
    [EnumMember(Value = "channel")]
    Channel,

    /// <summary>
    /// Enum Conversationid for "conversationId"
    /// </summary>
    [EnumMember(Value = "conversationId")]
    Conversationid,

    /// <summary>
    /// Enum Direction for "direction"
    /// </summary>
    [EnumMember(Value = "direction")]
    Direction,

    /// <summary>
    /// Enum Divisionid for "divisionId"
    /// </summary>
    [EnumMember(Value = "divisionId")]
    Divisionid,

    /// <summary>
    /// Enum Dnis for "dnis"
    /// </summary>
    [EnumMember(Value = "dnis")]
    Dnis,

    /// <summary>
    /// Enum Flowid for "flowId"
    /// </summary>
    [EnumMember(Value = "flowId")]
    Flowid,

    /// <summary>
    /// Enum Flowversion for "flowVersion"
    /// </summary>
    [EnumMember(Value = "flowVersion")]
    Flowversion,

    /// <summary>
    /// Enum Mediatype for "mediaType"
    /// </summary>
    [EnumMember(Value = "mediaType")]
    Mediatype,

    /// <summary>
    /// Enum Messagetype for "messageType"
    /// </summary>
    [EnumMember(Value = "messageType")]
    Messagetype,

    /// <summary>
    /// Enum Queueid for "queueId"
    /// </summary>
    [EnumMember(Value = "queueId")]
    Queueid,

    /// <summary>
    /// Enum Teamid for "teamId"
    /// </summary>
    [EnumMember(Value = "teamId")]
    Teamid,

    /// <summary>
    /// Enum Topicid for "topicId"
    /// </summary>
    [EnumMember(Value = "topicId")]
    Topicid,

    /// <summary>
    /// Enum Userid for "userId"
    /// </summary>
    [EnumMember(Value = "userId")]
    Userid,

    /// <summary>
    /// Enum Wrapupcode for "wrapUpCode"
    /// </summary>
    [EnumMember(Value = "wrapUpCode")]
    Wrapupcode
}
