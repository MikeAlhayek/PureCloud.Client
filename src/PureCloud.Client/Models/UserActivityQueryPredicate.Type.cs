using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum UserActivityQueryPredicateTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Dimension for "dimension"
    /// </summary>
    [EnumMember(Value = "dimension")]
    Dimension,

    /// <summary>
    /// Enum Property for "property"
    /// </summary>
    [EnumMember(Value = "property")]
    Property,

    /// <summary>
    /// Enum Metric for "metric"
    /// </summary>
    [EnumMember(Value = "metric")]
    Metric
}
