namespace PureCloud.Client.Models;

/// <summary>
/// Status of a recording that cannot be returned because of an error
/// </summary>
public enum RecordingErrorStatus
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    OutdatedSdkVersion,

    /// <summary>
    /// Enum EmailTranscriptTooLarge for "EMAIL_TRANSCRIPT_TOO_LARGE"
    /// </summary>
    EmailTranscriptTooLarge
}