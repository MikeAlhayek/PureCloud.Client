using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Left hand side for metric predicates
/// </summary>
/// <value>Left hand side for metric predicates</value>

public enum ResolutionDetailQueryPredicateMetricEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Nnextcontactavoided for "nNextContactAvoided"
    /// </summary>
    [EnumMember(Value = "nNextContactAvoided")]
    Nnextcontactavoided
}
