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
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Archived for "ARCHIVED"
    /// </summary>
    Archived,

    /// <summary>
    /// Enum Available for "AVAILABLE"
    /// </summary>
    Available,

    /// <summary>
    /// Enum Deleted for "DELETED"
    /// </summary>
    Deleted,

    /// <summary>
    /// Enum Restored for "RESTORED"
    /// </summary>
    Restored,

    /// <summary>
    /// Enum Restoring for "RESTORING"
    /// </summary>
    Restoring,

    /// <summary>
    /// Enum Uploading for "UPLOADING"
    /// </summary>
    Uploading,

    /// <summary>
    /// Enum Error for "ERROR"
    /// </summary>
    Error
}