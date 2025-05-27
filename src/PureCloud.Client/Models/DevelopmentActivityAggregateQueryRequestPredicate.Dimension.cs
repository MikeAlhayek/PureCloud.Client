using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum DevelopmentActivityAggregateQueryRequestPredicateDimensionEnum
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
    /// Enum Type for "type"
    /// </summary>
    [EnumMember(Value = "type")]
    Type,

    /// <summary>
    /// Enum Moduleid for "moduleId"
    /// </summary>
    [EnumMember(Value = "moduleId")]
    Moduleid,

    /// <summary>
    /// Enum Ispassed for "isPassed"
    /// </summary>
    [EnumMember(Value = "isPassed")]
    Ispassed
}
