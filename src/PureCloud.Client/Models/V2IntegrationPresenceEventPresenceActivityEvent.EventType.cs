using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum V2IntegrationPresenceEventPresenceActivityEventEventTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Userpresencestatuschanged for "UserPresenceStatusChanged"
    /// </summary>
    [EnumMember(Value = "UserPresenceStatusChanged")]
    Userpresencestatuschanged,

    /// <summary>
    /// Enum Userprimarypresencesourcechanged for "UserPrimaryPresenceSourceChanged"
    /// </summary>
    [EnumMember(Value = "UserPrimaryPresenceSourceChanged")]
    Userprimarypresencesourcechanged
}
