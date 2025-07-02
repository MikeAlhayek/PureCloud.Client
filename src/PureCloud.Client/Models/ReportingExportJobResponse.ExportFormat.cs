using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// The requested format of the exported data
/// </summary>
/// <value>The requested format of the exported data</value>

public enum ReportingExportJobResponseExportFormatEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Csv for "CSV"
    /// </summary>
    [EnumMember(Value = "CSV")]
    Csv,

    /// <summary>
    /// Enum Pdf for "PDF"
    /// </summary>
    [EnumMember(Value = "PDF")]
    Pdf
}
