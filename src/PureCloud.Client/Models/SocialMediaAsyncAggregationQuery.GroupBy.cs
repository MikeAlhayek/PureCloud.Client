using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Gets or Sets GroupBy
/// </summary>
public enum SocialMediaAsyncAggregationQueryGroupBy
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Country for "country"
    /// </summary>
    [EnumMember(Value = "country")]
    Country,

    /// <summary>
    /// Enum Language for "language"
    /// </summary>
    [EnumMember(Value = "language")]
    Language,

    /// <summary>
    /// Enum Platform for "platform"
    /// </summary>
    [EnumMember(Value = "platform")]
    Platform,

    /// <summary>
    /// Enum Topic for "topic"
    /// </summary>
    [EnumMember(Value = "topic")]
    Topic,

    /// <summary>
    /// Enum Escalationstatus for "escalationStatus"
    /// </summary>
    [EnumMember(Value = "escalationStatus")]
    Escalationstatus,

    /// <summary>
    /// Enum Messagecontenttype for "messageContentType"
    /// </summary>
    [EnumMember(Value = "messageContentType")]
    Messagecontenttype,

    /// <summary>
    /// Enum Sentiment for "sentiment"
    /// </summary>
    [EnumMember(Value = "sentiment")]
    Sentiment,

    /// <summary>
    /// Enum Dataingestionrule for "dataIngestionRule"
    /// </summary>
    [EnumMember(Value = "dataIngestionRule")]
    Dataingestionrule,

    /// <summary>
    /// Enum Text for "text"
    /// </summary>
    [EnumMember(Value = "text")]
    Text
}