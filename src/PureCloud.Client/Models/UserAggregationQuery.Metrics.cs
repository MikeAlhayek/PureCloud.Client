using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Gets or Sets Metrics
/// </summary>

public enum UserAggregationQueryMetricsEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Tagentroutingstatus for "tAgentRoutingStatus"
    /// </summary>
    [EnumMember(Value = "tAgentRoutingStatus")]
    Tagentroutingstatus,

    /// <summary>
    /// Enum Torganizationpresence for "tOrganizationPresence"
    /// </summary>
    [EnumMember(Value = "tOrganizationPresence")]
    Torganizationpresence,

    /// <summary>
    /// Enum Tsystempresence for "tSystemPresence"
    /// </summary>
    [EnumMember(Value = "tSystemPresence")]
    Tsystempresence
}
