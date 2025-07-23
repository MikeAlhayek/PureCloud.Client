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
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Edge for "EDGE"
    /// </summary>
    Edge,

    /// <summary>
    /// Enum Chat for "CHAT"
    /// </summary>
    Chat,

    /// <summary>
    /// Enum Email for "EMAIL"
    /// </summary>
    Email,

    /// <summary>
    /// Enum ScreenRecording for "SCREEN_RECORDING"
    /// </summary>
    ScreenRecording,

    /// <summary>
    /// Enum Pureengage for "PUREENGAGE"
    /// </summary>
    Pureengage,

    /// <summary>
    /// Enum Pureconnect for "PURECONNECT"
    /// </summary>
    Pureconnect
}