using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Gets or Sets GroupBy
/// </summary>

public enum DevelopmentActivityAggregateParamGroupByEnum
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
    Attendeeid
}
