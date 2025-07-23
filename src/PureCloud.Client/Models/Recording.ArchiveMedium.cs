using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// The type of archive medium used. Example: CloudArchive
/// </summary>
public enum RecordingArchiveMedium
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Cloudarchive for "CLOUDARCHIVE"
    /// </summary>
    [EnumMember(Value = "CLOUDARCHIVE")]
    Cloudarchive
}