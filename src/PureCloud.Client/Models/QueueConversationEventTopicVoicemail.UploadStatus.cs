using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// The voicemail data to be used when this callback is an ACD voicemail.
/// </summary>

public enum UploadStatusEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Pending for "pending"
    /// </summary>
    [EnumMember(Value = "pending")]
    Pending,

    /// <summary>
    /// Enum Complete for "complete"
    /// </summary>
    [EnumMember(Value = "complete")]
    Complete,

    /// <summary>
    /// Enum Failed for "failed"
    /// </summary>
    [EnumMember(Value = "failed")]
    Failed,

    /// <summary>
    /// Enum Timeout for "timeout"
    /// </summary>
    [EnumMember(Value = "timeout")]
    Timeout,

    /// <summary>
    /// Enum None for "none"
    /// </summary>
    [EnumMember(Value = "none")]
    None
}
