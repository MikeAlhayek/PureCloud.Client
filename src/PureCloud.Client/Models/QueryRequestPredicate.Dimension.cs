using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum QueryRequestPredicateDimensionEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Attendeeid for "attendeeId"
    /// </summary>
    [EnumMember(Value = "attendeeId")]
    Attendeeid,

    /// <summary>
    /// Enum Facilitatorid for "facilitatorId"
    /// </summary>
    [EnumMember(Value = "facilitatorId")]
    Facilitatorid,

    /// <summary>
    /// Enum Status for "status"
    /// </summary>
    [EnumMember(Value = "status")]
    Status
}
