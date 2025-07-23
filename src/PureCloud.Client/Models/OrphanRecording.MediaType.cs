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
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Call for "CALL"
    /// </summary>
    Call,

    /// <summary>
    /// Enum Chat for "CHAT"
    /// </summary>
    Chat,

    /// <summary>
    /// Enum Email for "EMAIL"
    /// </summary>
    Email,

    /// <summary>
    /// Enum Screen for "SCREEN"
    /// </summary>
    Screen
}