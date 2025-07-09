using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// The type of data for the criteria (string, int, etc).
/// </summary>
/// <value>The type of data for the criteria (string, int, etc).</value>

public enum QueryCriteriaDataTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum String for "string"
    /// </summary>
    [EnumMember(Value = "string")]
    String,

    /// <summary>
    /// Enum Guid for "guid"
    /// </summary>
    [EnumMember(Value = "guid")]
    Guid,

    /// <summary>
    /// Enum Datetime for "dateTime"
    /// </summary>
    [EnumMember(Value = "dateTime")]
    Datetime
}
