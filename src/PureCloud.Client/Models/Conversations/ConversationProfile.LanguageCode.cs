using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum ConversationProfileLanguageCodeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum En for "en"
    /// </summary>
    [EnumMember(Value = "en")]
    En,

    /// <summary>
    /// Enum Enau for "en-AU"
    /// </summary>
    [EnumMember(Value = "en-AU")]
    Enau,

    /// <summary>
    /// Enum Enca for "en-CA"
    /// </summary>
    [EnumMember(Value = "en-CA")]
    Enca,

    /// <summary>
    /// Enum Engb for "en-GB"
    /// </summary>
    [EnumMember(Value = "en-GB")]
    Engb,

    /// <summary>
    /// Enum Enin for "en-IN"
    /// </summary>
    [EnumMember(Value = "en-IN")]
    Enin,

    /// <summary>
    /// Enum Enus for "en-US"
    /// </summary>
    [EnumMember(Value = "en-US")]
    Enus
}
