using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Gets or Sets MediaType
/// </summary>
public enum OrphanRecordingMediaType
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Call for "CALL"
    /// </summary>
    [EnumMember(Value = "CALL")]
    Call,

    /// <summary>
    /// Enum Chat for "CHAT"
    /// </summary>
    [EnumMember(Value = "CHAT")]
    Chat,

    /// <summary>
    /// Enum Email for "EMAIL"
    /// </summary>
    [EnumMember(Value = "EMAIL")]
    Email,

    /// <summary>
    /// Enum Screen for "SCREEN"
    /// </summary>
    [EnumMember(Value = "SCREEN")]
    Screen
}