using System.Runtime.Serialization;

namespace PureCloud.Client.Models.Users;

public enum IntegrationPresenceSource
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Microsoftteams for "MicrosoftTeams"
    /// </summary>
    [EnumMember(Value = "MicrosoftTeams")]
    Microsoftteams,

    /// <summary>
    /// Enum Zoomphone for "ZoomPhone"
    /// </summary>
    [EnumMember(Value = "ZoomPhone")]
    Zoomphone,

    /// <summary>
    /// Enum Eightbyeight for "EightByEight"
    /// </summary>
    [EnumMember(Value = "EightByEight")]
    Eightbyeight
}
