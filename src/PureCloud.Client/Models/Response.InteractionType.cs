using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// The interaction type for this response.
/// </summary>
public enum InteractionType
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Chat for "chat"
    /// </summary>
    [EnumMember(Value = "chat")]
    Chat,

    /// <summary>
    /// Enum Email for "email"
    /// </summary>
    [EnumMember(Value = "email")]
    Email,

    /// <summary>
    /// Enum Twitter for "twitter"
    /// </summary>
    [EnumMember(Value = "twitter")]
    Twitter
}