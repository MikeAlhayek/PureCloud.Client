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
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Trunk for "Trunk"
    /// </summary>
    Trunk,

    /// <summary>
    /// Enum Station for "Station"
    /// </summary>
    Station,

    /// <summary>
    /// Enum Consult for "Consult"
    /// </summary>
    Consult,

    /// <summary>
    /// Enum Screen for "Screen"
    /// </summary>
    Screen
}