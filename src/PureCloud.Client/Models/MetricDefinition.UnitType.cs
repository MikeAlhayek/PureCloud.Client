using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum MetricDefinitionUnitTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum None for "None"
    /// </summary>
    [EnumMember(Value = "None")]
    None,

    /// <summary>
    /// Enum Percent for "Percent"
    /// </summary>
    [EnumMember(Value = "Percent")]
    Percent,

    /// <summary>
    /// Enum Currency for "Currency"
    /// </summary>
    [EnumMember(Value = "Currency")]
    Currency,

    /// <summary>
    /// Enum Seconds for "Seconds"
    /// </summary>
    [EnumMember(Value = "Seconds")]
    Seconds,

    /// <summary>
    /// Enum Number for "Number"
    /// </summary>
    [EnumMember(Value = "Number")]
    Number,

    /// <summary>
    /// Enum Attendancestatus for "AttendanceStatus"
    /// </summary>
    [EnumMember(Value = "AttendanceStatus")]
    Attendancestatus,

    /// <summary>
    /// Enum Unit for "Unit"
    /// </summary>
    [EnumMember(Value = "Unit")]
    Unit
}
