using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Left hand side for metric predicates
/// </summary>
/// <value>Left hand side for metric predicates</value>

public enum SegmentDetailQueryPredicateMetricEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Tsegmentduration for "tSegmentDuration"
    /// </summary>
    [EnumMember(Value = "tSegmentDuration")]
    Tsegmentduration
}
