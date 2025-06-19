using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// The field to sort responses by.  The accepted choices are Name and DateStart
/// </summary>
/// <value>The field to sort responses by.  The accepted choices are Name and DateStart</value>

public enum GetAlertQuerySortByEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Name for "Name"
    /// </summary>
    [EnumMember(Value = "Name")]
    Name,

    /// <summary>
    /// Enum Datestart for "DateStart"
    /// </summary>
    [EnumMember(Value = "DateStart")]
    Datestart
}
