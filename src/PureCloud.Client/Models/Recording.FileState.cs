using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Represents the current file state for a recording. Examples: Uploading, Archived, etc
/// </summary>
public enum RecordingFileState
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Archived for "ARCHIVED"
    /// </summary>
    [EnumMember(Value = "ARCHIVED")]
    Archived,

    /// <summary>
    /// Enum Available for "AVAILABLE"
    /// </summary>
    [EnumMember(Value = "AVAILABLE")]
    Available,

    /// <summary>
    /// Enum Deleted for "DELETED"
    /// </summary>
    [EnumMember(Value = "DELETED")]
    Deleted,

    /// <summary>
    /// Enum Restored for "RESTORED"
    /// </summary>
    [EnumMember(Value = "RESTORED")]
    Restored,

    /// <summary>
    /// Enum Restoring for "RESTORING"
    /// </summary>
    [EnumMember(Value = "RESTORING")]
    Restoring,

    /// <summary>
    /// Enum Uploading for "UPLOADING"
    /// </summary>
    [EnumMember(Value = "UPLOADING")]
    Uploading,

    /// <summary>
    /// Enum Error for "ERROR"
    /// </summary>
    [EnumMember(Value = "ERROR")]
    Error
}