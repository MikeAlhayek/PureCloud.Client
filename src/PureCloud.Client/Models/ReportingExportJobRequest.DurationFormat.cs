using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Indicates the duration format for the exports
/// </summary>
/// <value>Indicates the duration format for the exports</value>

public enum ReportingExportJobRequestDurationFormatEnum
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
    /// Enum Milliseconds for "Milliseconds"
    /// </summary>
    [EnumMember(Value = "Milliseconds")]
    Milliseconds,

    /// <summary>
    /// Enum Hhmmss for "Hhmmss"
    /// </summary>
    [EnumMember(Value = "Hhmmss")]
    Hhmmss,

    /// <summary>
    /// Enum Hms for "Hms"
    /// </summary>
    [EnumMember(Value = "Hms")]
    Hms
}
