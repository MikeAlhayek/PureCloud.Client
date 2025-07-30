using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// The activity smoothing type for schedule generation in this business unit
/// </summary>
public enum BuSchedulingSettingsRequestActivitySmoothingType
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Reduceconcurrentactivitiesacrossbu for "ReduceConcurrentActivitiesAcrossBu"
    /// </summary>
    [EnumMember(Value = "ReduceConcurrentActivitiesAcrossBu")]
    Reduceconcurrentactivitiesacrossbu,

    /// <summary>
    /// Enum Reduceconcurrentactivitiesacrossmu for "ReduceConcurrentActivitiesAcrossMu"
    /// </summary>
    [EnumMember(Value = "ReduceConcurrentActivitiesAcrossMu")]
    Reduceconcurrentactivitiesacrossmu,

    /// <summary>
    /// Enum Consistentservicelevel for "ConsistentServiceLevel"
    /// </summary>
    [EnumMember(Value = "ConsistentServiceLevel")]
    Consistentservicelevel
}