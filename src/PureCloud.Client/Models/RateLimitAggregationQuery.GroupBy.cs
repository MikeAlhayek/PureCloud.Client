using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum RateLimitAggregationQueryGroupByEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Correlationid for "correlationId"
    /// </summary>
    [EnumMember(Value = "correlationId")]
    Correlationid,

    /// <summary>
    /// Enum Entityid for "entityId"
    /// </summary>
    [EnumMember(Value = "entityId")]
    Entityid,

    /// <summary>
    /// Enum Limitname for "limitName"
    /// </summary>
    [EnumMember(Value = "limitName")]
    Limitname,

    /// <summary>
    /// Enum Max for "max"
    /// </summary>
    [EnumMember(Value = "max")]
    Max,

    /// <summary>
    /// Enum Namespace for "namespace"
    /// </summary>
    [EnumMember(Value = "namespace")]
    Namespace,

    /// <summary>
    /// Enum Timeunit for "timeUnit"
    /// </summary>
    [EnumMember(Value = "timeUnit")]
    Timeunit,

    /// <summary>
    /// Enum Userid for "userId"
    /// </summary>
    [EnumMember(Value = "userId")]
    Userid
}
