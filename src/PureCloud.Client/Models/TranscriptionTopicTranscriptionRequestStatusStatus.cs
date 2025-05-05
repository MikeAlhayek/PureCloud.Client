using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum TranscriptionTopicTranscriptionRequestStatusStatus
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
    /// Enum SessionOngoing for "SESSION_ONGOING"
    /// </summary>
    [EnumMember(Value = "SESSION_ONGOING")]
    SessionOngoing,

    /// <summary>
    /// Enum SessionEnded for "SESSION_ENDED"
    /// </summary>
    [EnumMember(Value = "SESSION_ENDED")]
    SessionEnded
}
