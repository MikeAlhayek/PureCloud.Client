using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum GetRulesQueryRuleTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Conversation for "Conversation"
    /// </summary>
    [EnumMember(Value = "Conversation")]
    Conversation,

    /// <summary>
    /// Enum Presence for "Presence"
    /// </summary>
    [EnumMember(Value = "Presence")]
    Presence,

    /// <summary>
    /// Enum All for "All"
    /// </summary>
    [EnumMember(Value = "All")]
    All
}
