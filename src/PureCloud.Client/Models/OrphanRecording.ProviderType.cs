using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Gets or Sets ProviderType
/// </summary>
public enum OrphanRecordingProviderType
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Edge for "EDGE"
    /// </summary>
    [EnumMember(Value = "EDGE")]
    Edge,

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
    /// Enum ScreenRecording for "SCREEN_RECORDING"
    /// </summary>
    [EnumMember(Value = "SCREEN_RECORDING")]
    ScreenRecording,

    /// <summary>
    /// Enum Pureengage for "PUREENGAGE"
    /// </summary>
    [EnumMember(Value = "PUREENGAGE")]
    Pureengage,

    /// <summary>
    /// Enum Pureconnect for "PURECONNECT"
    /// </summary>
    [EnumMember(Value = "PURECONNECT")]
    Pureconnect
}