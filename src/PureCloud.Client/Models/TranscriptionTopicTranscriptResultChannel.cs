using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum TranscriptionTopicTranscriptResultChannel
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Unknown for "UNKNOWN"
    /// </summary>
    [EnumMember(Value = "UNKNOWN")]
    Unknown,

    /// <summary>
    /// Enum Internal for "INTERNAL"
    /// </summary>
    [EnumMember(Value = "INTERNAL")]
    Internal,

    /// <summary>
    /// Enum External for "EXTERNAL"
    /// </summary>
    [EnumMember(Value = "EXTERNAL")]
    External,

    /// <summary>
    /// Enum Both for "BOTH"
    /// </summary>
    [EnumMember(Value = "BOTH")]
    Both
}
