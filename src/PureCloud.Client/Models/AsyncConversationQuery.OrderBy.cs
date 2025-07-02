using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Specify which data element within the result set to use for sorting. The options  to use as a basis for sorting the results: conversationStart, segmentStart, and segmentEnd. If not specified, the default is conversationStart
/// </summary>
/// <value>Specify which data element within the result set to use for sorting. The options  to use as a basis for sorting the results: conversationStart, segmentStart, and segmentEnd. If not specified, the default is conversationStart</value>

public enum AsyncConversationQueryOrderByEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Conversationstart for "conversationStart"
    /// </summary>
    [EnumMember(Value = "conversationStart")]
    Conversationstart,

    /// <summary>
    /// Enum Conversationend for "conversationEnd"
    /// </summary>
    [EnumMember(Value = "conversationEnd")]
    Conversationend,

    /// <summary>
    /// Enum Segmentstart for "segmentStart"
    /// </summary>
    [EnumMember(Value = "segmentStart")]
    Segmentstart,

    /// <summary>
    /// Enum Segmentend for "segmentEnd"
    /// </summary>
    [EnumMember(Value = "segmentEnd")]
    Segmentend
}
