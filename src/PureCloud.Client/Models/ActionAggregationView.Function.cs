using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Type of view you wish to create
/// </summary>
/// <value>Type of view you wish to create</value>

public enum ActionAggregationViewFunctionEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Rangebound for "rangeBound"
    /// </summary>
    [EnumMember(Value = "rangeBound")]
    Rangebound
}
