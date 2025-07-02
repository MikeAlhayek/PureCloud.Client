using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// The user supplied csv delimiter string value either of type 'comma' or 'semicolon' permitted for the export request
/// </summary>
/// <value>The user supplied csv delimiter string value either of type 'comma' or 'semicolon' permitted for the export request</value>

public enum ReportingExportJobResponseCsvDelimiterEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Semicolon for "SEMICOLON"
    /// </summary>
    [EnumMember(Value = "SEMICOLON")]
    Semicolon,

    /// <summary>
    /// Enum Comma for "COMMA"
    /// </summary>
    [EnumMember(Value = "COMMA")]
    Comma
}
