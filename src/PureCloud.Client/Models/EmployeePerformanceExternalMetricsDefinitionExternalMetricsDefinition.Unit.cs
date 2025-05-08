using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum EmployeePerformanceExternalMetricsDefinitionExternalMetricsDefinitionUnitEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Seconds for "Seconds"
    /// </summary>
    [EnumMember(Value = "Seconds")]
    Seconds,

    /// <summary>
    /// Enum Percent for "Percent"
    /// </summary>
    [EnumMember(Value = "Percent")]
    Percent,

    /// <summary>
    /// Enum Number for "Number"
    /// </summary>
    [EnumMember(Value = "Number")]
    Number,

    /// <summary>
    /// Enum Currency for "Currency"
    /// </summary>
    [EnumMember(Value = "Currency")]
    Currency,

    /// <summary>
    /// Enum Unknown for "Unknown"
    /// </summary>
    [EnumMember(Value = "Unknown")]
    Unknown
}
