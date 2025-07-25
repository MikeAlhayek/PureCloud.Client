using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// The state of the bot after completion of the request
/// </summary>
public enum PostTextResponseBotState
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Complete for "Complete"
    /// </summary>
    [EnumMember(Value = "Complete")]
    Complete,

    /// <summary>
    /// Enum Failed for "Failed"
    /// </summary>
    [EnumMember(Value = "Failed")]
    Failed,

    /// <summary>
    /// Enum Moredata for "MoreData"
    /// </summary>
    [EnumMember(Value = "MoreData")]
    Moredata
}