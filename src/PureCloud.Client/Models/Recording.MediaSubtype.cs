using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// The media subtype of the recording.
/// </summary>
public enum RecordingMediaSubtype
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Trunk for "Trunk"
    /// </summary>
    [EnumMember(Value = "Trunk")]
    Trunk,

    /// <summary>
    /// Enum Station for "Station"
    /// </summary>
    [EnumMember(Value = "Station")]
    Station,

    /// <summary>
    /// Enum Consult for "Consult"
    /// </summary>
    [EnumMember(Value = "Consult")]
    Consult,

    /// <summary>
    /// Enum Screen for "Screen"
    /// </summary>
    [EnumMember(Value = "Screen")]
    Screen
}