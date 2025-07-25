using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Old property value
/// </summary>
/// <value>Old property value</value>

public enum WorkitemsAttributeChangeWorkitemStatusCategoryOldValueEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Open for "Open"
    /// </summary>
    [EnumMember(Value = "Open")]
    Open,

    /// <summary>
    /// Enum Inprogress for "InProgress"
    /// </summary>
    [EnumMember(Value = "InProgress")]
    Inprogress,

    /// <summary>
    /// Enum Waiting for "Waiting"
    /// </summary>
    [EnumMember(Value = "Waiting")]
    Waiting,

    /// <summary>
    /// Enum Closed for "Closed"
    /// </summary>
    [EnumMember(Value = "Closed")]
    Closed,

    /// <summary>
    /// Enum Unknown for "Unknown"
    /// </summary>
    [EnumMember(Value = "Unknown")]
    Unknown
}
