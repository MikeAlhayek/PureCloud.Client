namespace PureCloud.Client.Models;

/// <summary>
/// CommunicationType for Cobrowse Session
/// </summary>
public enum CobrowseWebMessagingSessionCommunicationType
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Call for "Call"
    /// </summary>
    Call,

    /// <summary>
    /// Enum Message for "Message"
    /// </summary>
    Message,

    /// <summary>
    /// Enum Unknown for "Unknown"
    /// </summary>
    Unknown
}